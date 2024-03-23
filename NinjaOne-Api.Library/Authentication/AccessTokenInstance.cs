namespace NinjaOne_Api.Library.Authentication;

public class AccessTokenInstance(TokenResponse tokenResponse)
{
    public string AccessToken { get; } = tokenResponse.AccessToken!;
    public string Scope { get; init; } = tokenResponse.Scope!;
    public string? RefreshToken { get; } = tokenResponse.RefreshToken;
    public string TokenType { get; } = tokenResponse.TokenType!;
    private DateTime Expiry { get; } = DateTime.Now.AddSeconds(tokenResponse.ExpiresIn);

    public bool IsExpired()
    {
        return DateTime.Now >= Expiry;
    }

    public bool IsRefreshable()
    {
        return !string.IsNullOrWhiteSpace(RefreshToken);
    }
}