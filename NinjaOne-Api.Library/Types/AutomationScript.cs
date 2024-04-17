namespace NinjaOne_Api.Library.Types;

public class AutomationScript
{
    [JsonPropertyName(Property.Id)]
    public int? Id { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; internal set; }
    [JsonPropertyName(Property.Language)]
    public string? Language { get; internal set; }
    [JsonPropertyName(Property.Architecture)]
    public List<string>? Architecture { get; internal set; }
    [JsonPropertyName(Property.OperatingSystems)]
    public List<string>? OperatingSystems { get; internal set; }
    [JsonPropertyName(Property.ScriptParameters)]
    public List<string>? ScriptParameters { get; internal set; }
    [JsonPropertyName(Property.ScriptVariables)]
    public List<ScriptVariable>? ScriptVariables { get; internal set; }

    [JsonConstructor]
    internal AutomationScript(
        int? id,
        string? name,
        string? description,
        bool? active,
        string? language,
        List<string>? architecture,
        List<string>? operatingSystems,
        List<string>? scriptParameters,
        List<ScriptVariable>? scriptVariables
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Active = active;
        Language = language;
        Architecture = architecture;
        OperatingSystems = operatingSystems;
        ScriptParameters = scriptParameters;
        ScriptVariables = scriptVariables;
    }
}