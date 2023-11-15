namespace NinjaOne_Api.Library;

public partial class Client
{
    private const int DefaultMaxPageSize = 1000;
    private readonly RestClient _restClient;
    private NinjaAuthenticator NinjaAuthenticator { get; }

    public Client(string clientId, string clientSecret, string scopes, Instance instance = Instance.US)
    {
        var instanceUrl = InstanceUrl.GetInstanceUrl(instance);
        NinjaAuthenticator = new NinjaAuthenticator(instanceUrl, clientId, clientSecret, scopes);
        var options = new RestClientOptions($"{instanceUrl}/api/v2")
        {
            Authenticator = NinjaAuthenticator
        };
        
        _restClient = new RestClient(options);
    }
    
    private async Task<T> GetResource<T>(RestRequest request, string? property = null)
    {
        var response = await Get(request);
        var toSerialize = response.RootElement;
        if (property is not null) toSerialize = response.RootElement.GetProperty(property);
        return Serializer.DeserializeObject<T>(toSerialize);
    }

    private async Task<IList<T>> GetResources<T>(RestRequest request, string? property = null)
    {
        var response = await Get(request);
        var toSerialize = response.RootElement;
        if (property is not null) toSerialize = response.RootElement.GetProperty(property);
        return Serializer.DeserializeList<T>(toSerialize);
    }
    
    private async Task<bool> PostResource(RestRequest request, object payload, Method method = Method.Post)
    {
        return await PostNoResponseBody(request, payload, method);
    }

    private async Task<T> PostResource<T>(RestRequest request, object payload, Method method = Method.Post,
        string? property = null)
    {
        var response = await Post(request, payload, method);
        var toSerialize = response.RootElement;
        if (property is not null) toSerialize = response.RootElement.GetProperty(property);
        return Serializer.DeserializeObject<T>(toSerialize);
    }
    
    
    // TODO: Throw exceptions when receiving non-successful HTTP status codes for Get (or return null)
    private async Task<JsonDocument> Get(RestRequest request)
    {
        var response = await _restClient.ExecuteAsync(request);
        // TODO: Implement verbosity settings
// #if DEBUG
//         var parameters = string.Join("&", request.Parameters.ToList()
//             .Where(r => !r.Name!.Equals("Authorization")).Select(r => $"{r.Name}={r.Value}"));
//         Console.WriteLine(parameters == string.Empty
//             ? $"{Method.Get} {request.Resource}"
//             : $"{Method.Get} {request.Resource}?{parameters}");
//         Console.WriteLine($"Response Content: \n{response.Content}");
// #endif
        return JsonDocument.Parse(response.Content!);
    }

    // TODO: Throw exceptions when receiving non-successful HTTP status codes for Post (or return null)
    // TODO: Refactor actual serialization and ExecuteAsync call into separate base method
    private async Task<JsonDocument> Post(RestRequest request, object payload, Method method = Method.Post)
    {
        request.Method = method;
        request.AddBody(Serializer.SerializeObject(payload), contentType: ContentType.Json);
        var response = await _restClient.ExecuteAsync(request);
        return JsonDocument.Parse(response.Content!);
    }

    private async Task<bool> PostNoResponseBody(RestRequest request, object payload, Method method = Method.Post)
    {
        request.Method = method;
        request.AddBody(Serializer.SerializeObject(payload), contentType: ContentType.Json);
        var response = await _restClient.ExecuteAsync(request);
        return response.IsSuccessStatusCode;
    }

    private static long UnixTime(DateTime dateTime)
    {
        return ((DateTimeOffset)dateTime.ToUniversalTime()).ToUnixTimeSeconds();
    }
}