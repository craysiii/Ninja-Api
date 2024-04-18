namespace NinjaOne_Api.Library;

public class NinjaApiError
{
    [JsonPropertyName(Property.ResultCode)]
    public string? ResultCode { get; init; }
    [JsonPropertyName(Property.ErrorMessage)]
    public string? ErrorMessage { get; init; }
    [JsonPropertyName(Property.IncidentId)]
    public string? IncidentCode { get; init; }
    [JsonPropertyName(Property.Error)]
    public string? Error { get; init; }
    [JsonPropertyName(Property.ErrorDescription)]
    public string? ErrorDescription { get; init; }
    [JsonPropertyName(Property.ErrorCode)]
    public int? ErrorCode { get; init; }
}