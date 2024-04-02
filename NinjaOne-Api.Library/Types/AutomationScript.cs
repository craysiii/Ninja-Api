namespace NinjaOne_Api.Library.Types;

public class AutomationScript
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; set; }
    [JsonPropertyName(Property.Language)]
    public string? Language { get; set; }
    [JsonPropertyName(Property.Architecture)]
    public List<string>? Architecture { get; set; }
    [JsonPropertyName(Property.OperatingSystems)]
    public List<string>? OperatingSystems { get; set; }
    [JsonPropertyName(Property.ScriptParameters)]
    public List<string>? ScriptParameters { get; set; }
    [JsonPropertyName(Property.ScriptVariables)]
    public List<ScriptVariable>? ScriptVariables { get; set; }
}