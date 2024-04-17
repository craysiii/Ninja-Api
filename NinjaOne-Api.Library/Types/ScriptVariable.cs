namespace NinjaOne_Api.Library.Types;

public class ScriptVariable
{
    [JsonPropertyName(Property.Id)]
    public string? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Type)]
    public ScriptVariableType? ScriptVariableType { get; internal set; }
    [JsonPropertyName(Property.Source)]
    public ScriptVariableSource? ScriptSource { get; internal set; }
    [JsonPropertyName(Property.DefaultValue)]
    public string? DefaultValue { get; internal set; }
    [JsonPropertyName(Property.Required)]
    public bool? Required { get; internal set; }
    [JsonPropertyName(Property.ValueList)]
    public List<string>? ValueList { get; internal set; }

    [JsonConstructor]
    internal ScriptVariable(
        string? id,
        string? name,
        string? description,
        ScriptVariableType? scriptVariableType,
        ScriptVariableSource? scriptSource,
        string? defaultValue,
        bool? required,
        List<string>? valueList
    )
    {
        Id = id;
        Name = name;
        Description = description;
        ScriptVariableType = scriptVariableType;
        ScriptSource = scriptSource;
        DefaultValue = defaultValue;
        Required = required;
        ValueList = valueList;
    }
}