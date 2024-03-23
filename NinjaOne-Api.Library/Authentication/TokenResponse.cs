namespace NinjaOne_Api.Library.Authentication;

public record TokenResponse
{
    [JsonPropertyName(Property.AccessToken)]
    public string? AccessToken { get; init; }
    [JsonPropertyName(Property.ExpiresIn)]
    public int ExpiresIn { get; init; }
    [JsonPropertyName(Property.Scope)]
    public string? Scope { get; init; }
    [JsonPropertyName(Property.RefreshToken)]
    public string? RefreshToken { get; init; }
    [JsonPropertyName(Property.TokenType)]
    public string? TokenType { get; init; }
}