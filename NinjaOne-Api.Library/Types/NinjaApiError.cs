namespace NinjaOne_Api.Library.Types;

public class NinjaApiError
{
    [JsonPropertyName(Property.ResultCode)]
    public string? ResultCode { get; set; }
    [JsonPropertyName(Property.ErrorMessage)]
    public string? ErrorMessage { get; set; }
    [JsonPropertyName(Property.IncidentId)]
    public string? IncidentCode { get; set; }
}