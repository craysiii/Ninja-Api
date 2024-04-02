namespace NinjaOne_Api.Library;

public class NinjaApiError
{
    [JsonPropertyName(Property.ResultCode)]
    public string? ResultCode { get; init; }
    [JsonPropertyName(Property.ErrorMessage)]
    public string? ErrorMessage { get; init; }
    [JsonPropertyName(Property.IncidentId)]
    public string? IncidentCode { get; init; }
}