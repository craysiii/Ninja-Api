namespace NinjaOne_Api.Library.Types;

public class BackupUsageBase
{
    [JsonPropertyName(Property.RevisionsCurrentSize)]
    public long? RevisionsCurrentSize { get; set; }
    [JsonPropertyName(Property.RevisionsPreviousSize)]
    public long? RevisionsPreviousSize { get; set; }
    [JsonPropertyName(Property.RevisionsDeletedSize)]
    public long? RevisionsDeletedSize { get; set; }
    [JsonPropertyName(Property.LocalFileFolderSize)]
    public long? LocalFileFolderSize { get; set; }
    [JsonPropertyName(Property.LocalImageSize)]
    public long? LocalImageSize { get; set; }
    [JsonPropertyName(Property.CloudFileFolderSize)]
    public long? CloudFileFolderSize { get; set; }
    [JsonPropertyName(Property.CloudImageSize)]
    public long? CloudImageSize { get; set; }
    [JsonPropertyName(Property.RevisionsTotalSize)]
    public long? RevisionsTotalSize { get; set; }
    [JsonPropertyName(Property.CloudTotalSize)]
    public long? CloudTotalSize { get; set; }
    [JsonPropertyName(Property.LocalTotalSize)]
    public long? LocalTotalSize { get; set; }
}