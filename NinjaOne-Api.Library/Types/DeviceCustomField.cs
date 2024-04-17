using System.Runtime.InteropServices.JavaScript;

namespace NinjaOne_Api.Library.Types;

public class DeviceCustomField
{
    [JsonPropertyName(Property.EntityType)]
    public EntityType? EntityType { get; internal set; }
    [JsonPropertyName(Property.Scope)]
    public Scope? Scope { get; internal set; }
    [JsonPropertyName(Property.Type)]
    public FieldType? Type { get; internal set; }
    [JsonPropertyName(Property.Label)]
    public string? Label { get; internal set; }
    [JsonPropertyName(Property.Description)]
    public string? Description { get; internal set; }
    [JsonPropertyName(Property.Name)]
    public string? Name { get; internal set; }
    [JsonPropertyName(Property.DefaultValue)]
    public string? DefaultValue { get; internal set; }
    [JsonPropertyName(Property.EndUserPermission)]
    public EndUserPermission? EndUserPermission { get; internal set; }
    [JsonPropertyName(Property.TechnicianPermission)]
    public TechnicianPermission? TechnicianPermission { get; internal set; }
    [JsonPropertyName(Property.ScriptPermission)]
    public ScriptPermission? ScriptPermission { get; internal set; }
    [JsonPropertyName(Property.Content)]
    public DeviceCustomFieldContent? Content { get; internal set; }
    [JsonPropertyName(Property.System)]
    public bool? System { get; internal set; }
    [JsonPropertyName(Property.Active)]
    public bool? Active { get; internal set; }
    [JsonPropertyName(Property.CreateTime)]
    public DateTime? CreateTime { get; internal set; }
    [JsonPropertyName(Property.UpdateTime)]
    public DateTime? UpdateTime { get; internal set; }

    [JsonConstructor]
    internal DeviceCustomField(
        EntityType? entityType,
        Scope? scope,
        FieldType? type,
        string? label,
        string? description,
        string? name,
        string? defaultValue,
        EndUserPermission? endUserPermission,
        TechnicianPermission? technicianPermission,
        ScriptPermission? scriptPermission,
        DeviceCustomFieldContent? content,
        bool? system,
        bool? active,
        DateTime? createTime,
        DateTime? updateTime
    )
    {
        EntityType = entityType;
        Scope = scope;
        Type = type;
        Label = label;
        Description = description;
        Name = name;
        DefaultValue = defaultValue;
        EndUserPermission = endUserPermission;
        TechnicianPermission = technicianPermission;
        ScriptPermission = scriptPermission;
        Content = content;
        System = system;
        Active = active;
        CreateTime = createTime;
        UpdateTime = updateTime;
    }
}