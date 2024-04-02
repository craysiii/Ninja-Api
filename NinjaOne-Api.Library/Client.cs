namespace NinjaOne_Api.Library;

public partial class Client
{
    private const int DefaultMaxPageSize = 1000;
    private readonly RestClient _restClient;
    private readonly ILogger<Client> _log;

    /// <summary>
    /// Create a new NinjaApi Client
    /// </summary>
    /// <param name="clientId">Ninja Api Client Id</param>
    /// <param name="clientSecret">Ninja Api Client Secret</param>
    /// <param name="scopes">Application Scope(s) to request - accepts multiple scopes</param>
    /// <param name="instance">Ninja Api Server Instance</param>
    /// <param name="loggerFactory">Optional LoggingFactory</param>
    /// <param name="logLevel">Optional LogLevel - default is LogLevel.None</param>
    /// <example>
    /// <code>
    /// var client = new Client(
    ///     clientId: "clientid",
    ///     clientSecret: "clientsecret",
    ///     scopes: ApplicationScopes.MONITORING | ApplicationScopes.OFFLINE_ACCESS,
    ///     instance: Instance.US,
    ///     logLevel: LogLevel.Trace
    /// );
    /// </code>
    /// </example>
    public Client(
        string clientId,
        string clientSecret,
        ApplicationScopes scopes,
        Instance instance = Instance.US,
        LoggerFactory? loggerFactory = null,
        LogLevel logLevel = LogLevel.None
        )
    {
        _log = InitializeLogging(loggerFactory, logLevel);
        
        var instanceUrl = InstanceUrl.GetInstanceUrl(instance);
        var options = new RestClientOptions($"{instanceUrl}/api/v2")
        {
            Authenticator = new NinjaAuthenticator(instanceUrl, clientId, clientSecret, scopes, loggerFactory, logLevel)
        };
        
        _restClient = new RestClient(options);
    }

    private static ILogger<Client> InitializeLogging(LoggerFactory? loggerFactory = null, LogLevel logLevel = LogLevel.None)
    {
        var logFactory = loggerFactory ?? LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter(Logging.FilterClient, logLevel)
                .AddSimpleConsole(options =>
                    {
                        options.SingleLine = true;
                        options.ColorBehavior = LoggerColorBehavior.Enabled;
                        options.UseUtcTimestamp = true;
                        options.TimestampFormat = Logging.TimestampFormat;
                    });
        });
        
        return logFactory.CreateLogger<Client>();
    }
    
    private async Task<(T?, NinjaApiError?)> GetResource<T>(RestRequest request, string? property = null)
    {
        var response = await ExecuteRequest(request);
        
        if (!response.Element.HasValue)
        {
            return (default, response.Error);
        }

        if (!string.IsNullOrWhiteSpace(property))
        {
            response.Element = response.Element.Value.GetProperty(property);
        }

        return (Serializer.DeserializeObject<T>(response.Element.Value), null);
    }

    private async Task<(List<T>?, NinjaApiError?)> GetResources<T>(RestRequest request, string? property = null)
    {
        var response = await ExecuteRequest(request);
        
        if (!response.Element.HasValue)
        {
            return (default, response.Error);
        }

        if (!string.IsNullOrWhiteSpace(property))
        {
            response.Element = response.Element.Value.GetProperty(property);
        }

        return (Serializer.DeserializeList<T>(response.Element.Value), null);
    }

    private async Task<(T? Resource, NinjaApiError? Error)> PostResource<T>(
        RestRequest request, 
        object payload, 
        Method method = Method.Post,
        string? property = null
        )
    {
        var response = await ExecuteRequest(request, payload, method);
        
        if (!response.Element.HasValue)
        {
            return (default, response.Error);
        }

        if (!string.IsNullOrWhiteSpace(property))
        {
            response.Element = response.Element.Value.GetProperty(property);
        }

        return (Serializer.DeserializeObject<T>(response.Element.Value), null);
    }
    
    private async Task<(bool Success, NinjaApiError? Error)> PostResource(
        RestRequest request,
        object payload,
        Method method = Method.Post
        )
    {
        var response = await ExecuteRequest(request, payload, method);
        
        return response.Error is not null ? (false, response.Error) : (true, null);
    }

    private async Task<(JsonElement? Element, NinjaApiError? Error)> ExecuteRequest(
        RestRequest request, 
        object? payload = null, 
        Method method = Method.Get
        )
    {
        request.Method = method;
        if (payload is not null)
        {
            request.AddBody(Serializer.SerializeObject(payload), contentType: ContentType.Json);
        }
        
        var parameters = string.Join("&", request.Parameters
            .ToList()
            .Where(r => !r.Name!.Equals("Authorization"))
            .Select(r => $"{r.Name}={r.Value}"));
        
        var response = await _restClient.ExecuteAsync(request);
        _log.LogDebug(
            "Method: {} Resource: {} Parameters: {} Response: {} {}", 
            request.Method.ToString(),
            request.Resource,
            parameters,
            (int)response.StatusCode,
            response.StatusDescription
        );
        _log.LogTrace("Response Body: {}", response.Content);

        var isValidJson = IsValidJson(response.Content);
        JsonElement? jsonElement = isValidJson ? JsonDocument.Parse(response.Content ?? string.Empty).RootElement : null;
        
        // Successful request
        if (response.IsSuccessStatusCode)
        {
            return (jsonElement, null);
        }

        return string.IsNullOrWhiteSpace(response.Content) switch
        {
            // Non-successful request - parse Json error
            false when isValidJson =>
                (null, Serializer.DeserializeObject<NinjaApiError>(jsonElement!.Value)),
            // Non-successful request - no Json to parse, so add whatever content exists to new NinjaApiError
            false when !isValidJson =>
                (null, new NinjaApiError { ErrorMessage = response.Content }),
            // We should never reach this
            _ => (null, null)
        };
    }

    private static long UnixTime(DateTime dateTime)
    {
        return ((DateTimeOffset)dateTime.ToUniversalTime()).ToUnixTimeSeconds();
    }

    public static bool IsValidJson(string? content)
    {
        if (string.IsNullOrWhiteSpace(content)) return false;
        
        try
        {
            JsonDocument.Parse(content);
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}