namespace NinjaOne_Api.Library.Types;

public class ScriptVariable
{
    [JsonPropertyName(Property.Id)]
    public string? Id { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Type)]
    public ScriptVariableType? ScriptVariableType { get; set; }
    [JsonPropertyName(Property.Source)]
    public ScriptVariableSource? ScriptSource { get; set; }
    [JsonPropertyName(Property.DefaultValue)]
    public string? DefaultValue { get; set; }
    [JsonPropertyName(Property.Required)]
    public bool? Required { get; set; }
    [JsonPropertyName(Property.ValueList)]
    public List<string>? ValueList { get; set; }
}