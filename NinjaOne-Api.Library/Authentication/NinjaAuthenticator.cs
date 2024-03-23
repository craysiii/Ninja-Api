using System.Security.Authentication;

namespace NinjaOne_Api.Library.Authentication;

public class NinjaAuthenticator : AuthenticatorBase
{
    private AccessTokenInstance? TokenInstance { get; set; }
    
    private readonly string _baseUrl;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _scopes;
    private readonly ILogger<NinjaAuthenticator> _log;
    
    public NinjaAuthenticator(
        string baseUrl, 
        string clientId, 
        string clientSecret, 
        ApplicationScopes scopes, 
        LoggerFactory? loggerFactory,
        LogLevel logLevel
        ) : base("")
    {
        _baseUrl = baseUrl;
        _clientId = clientId;
        _clientSecret = clientSecret;
        _scopes = scopes.ToString().ToLower().Replace(",", string.Empty);
        var logFactory = loggerFactory ?? LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter(Logging.FilterAuthenticator, logLevel)
                .AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.ColorBehavior = LoggerColorBehavior.Enabled;
                    options.UseUtcTimestamp = true;
                    options.TimestampFormat = Logging.TimestampFormat;
                });
        });
        
        _log = logFactory.CreateLogger<NinjaAuthenticator>();
    }

    protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
    {
        if (TokenInstance is null || TokenInstance.IsExpired())
        {
            TokenInstance = await GetToken(
                refresh: TokenInstance is not null && TokenInstance.IsExpired() && TokenInstance.IsRefreshable()
                );
        }
        
        return new HeaderParameter(
            KnownHeaders.Authorization, 
            $"{TokenInstance.TokenType} {TokenInstance.AccessToken}"
            );
    }

    private async Task<AccessTokenInstance> GetToken(bool refresh = false)
    {
        var options = GetAuthenticationClientOptions();
        using var client = new RestClient(options);

        var request = new RestRequest(Resource.Token);
        request.AddParameter(Param.GrantType, 
            (refresh ? GrantType.REFRESH_TOKEN : GrantType.CLIENT_CREDENTIALS).ToString().ToLower());
        if (refresh)
        {
            request.AddParameter(Param.RefreshToken, TokenInstance!.RefreshToken);
        }
        else
        {
            request.AddParameter(Param.Scope, _scopes);
        }

        var response = await client.ExecuteAsync(request, Method.Post);
        _log.LogDebug(
            "Auth Request Grant: {} Resource: {} Response: {} {}",
            request.Parameters.TryFind(Param.GrantType)!.Value,
            request.Resource,
            (int)response.StatusCode,
            response.StatusDescription
        );
        
        var jsonElement = JsonDocument.Parse(response.Content ?? string.Empty).RootElement;

        if (response.IsSuccessStatusCode)
            return new AccessTokenInstance(Serializer.DeserializeObject<TokenResponse>(jsonElement));
        
        if (!Client.IsValidJson(response.Content)) throw new AuthenticationException(response.Content);
        
        var error = Serializer.DeserializeObject<NinjaApiError>(jsonElement);
        throw new AuthenticationException(error.ErrorMessage);
    }
    
    private RestClientOptions GetAuthenticationClientOptions()
    {
        return new RestClientOptions(_baseUrl)
        {
            Authenticator = new HttpBasicAuthenticator(_clientId, _clientSecret)
        };
    }
}