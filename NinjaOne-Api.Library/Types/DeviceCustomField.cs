namespace NinjaOne_Api.Library.Types;

public class DeviceCustomField
{
    [JsonPropertyName(Property.EntityType)]
    public EntityType? EntityType { get; set; }
    [JsonPropertyName(Property.Scope)]
    public Scope? Scope { get; set; }
    [JsonPropertyName(Property.Type)]
    public FieldType? Type { get; set; }
    [JsonPropertyName(Property.Label)]
    public string? Label { get; set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; set; }
    [JsonPropertyName(Property.DefaultValue)]
    public string? DefaultValue { get; set; }
    [JsonPropertyName(Property.EndUserPermission)]
    public EndUserPermission? EndUserPermission { get; set; }
    [JsonPropertyName(Property.TechnicianPermission)]
    public TechnicianPermission? TechnicianPermission { get; set; }
    [JsonPropertyName(Property.ScriptPermission)]
    public ScriptPermission? ScriptPermission { get; set; }
    [JsonPropertyName(Property.Content)]
    public DeviceCustomFieldContent? Content { get; set; }
    [JsonPropertyName(Property.System)]
    public bool? System { get; set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; set; }
    [JsonPropertyName(Property.CreateTime)]
    public DateTime? CreateTime { get; set; }
    [JsonPropertyName(Property.UpdateTime)]
    public DateTime? UpdateTime { get; set; }
}