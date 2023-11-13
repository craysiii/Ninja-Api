namespace NinjaOne_Api.Library.Authentication;

public class NinjaAuthenticator : AuthenticatorBase
{
    private AccessTokenInstance? TokenInstance { get; set; }
    
    private readonly string _baseUrl;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _scopes;
    
    public NinjaAuthenticator(string baseUrl, string clientId, string clientSecret, string scopes) : base("")
    {
        _baseUrl = baseUrl;
        _clientId = clientId;
        _clientSecret = clientSecret;
        _scopes = scopes;
    }

    protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
    {
        if (TokenInstance is null || (TokenInstance.IsExpired() && !TokenInstance.IsRefreshable()))
        {
            TokenInstance = await GetToken();
        }

        if (TokenInstance.IsExpired() && TokenInstance.IsRefreshable())
        {
            TokenInstance = await RefreshToken();
        }

        Token = TokenInstance.AccessToken;
        return new HeaderParameter(KnownHeaders.Authorization, $"{TokenInstance.TokenType} {TokenInstance.AccessToken}");
    }

    private async Task<AccessTokenInstance> GetToken()
    {
        var options = GetAuthenticationClientOptions();
        using var client = new RestClient(options);

        var request = new RestRequest(Resource.Token)
            .AddParameter("grant_type", "client_credentials")
            .AddParameter("scope", $"{_scopes} offline_access");

        var response = await client.PostAsync<TokenResponse>(request);
        return new AccessTokenInstance(response!);
    }

    private async Task<AccessTokenInstance> RefreshToken()
    {
        var options = GetAuthenticationClientOptions();
        using var client = new RestClient(options);

        var request = new RestRequest(Resource.Token)
            .AddParameter("grant_type", "refresh_token")
            .AddParameter("refresh_token", TokenInstance!.RefreshToken); // Cannot be null

        var response = await client.PostAsync<TokenResponse>(request);
        return new AccessTokenInstance(response!);
    }

    private RestClientOptions GetAuthenticationClientOptions()
    {
        var options = new RestClientOptions(_baseUrl)
        {
            Authenticator = new HttpBasicAuthenticator(_clientId, _clientSecret)
        };

        return options;
    }
}