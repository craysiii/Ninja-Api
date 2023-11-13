namespace NinjaOne_Api.Library.Authentication;

public class AccessTokenInstance
{
    public string AccessToken { get; init; }
    public string Scope { get; init; }
    public string? RefreshToken { get; set; }
    public string TokenType { get; init; }
    private DateTime Expiry { get; init; }

    public AccessTokenInstance(TokenResponse tokenResponse)
    {
        AccessToken = tokenResponse.AccessToken!;
        Scope = tokenResponse.Scope!;
        RefreshToken = tokenResponse.RefreshToken;
        TokenType = tokenResponse.TokenType!;

        Expiry = DateTime.Now.AddSeconds(tokenResponse.ExpiresIn);
    }

    public bool IsExpired()
    {
        return DateTime.Now >= Expiry;
    }

    public bool IsRefreshable()
    {
        return !string.IsNullOrWhiteSpace(RefreshToken);
    }
}