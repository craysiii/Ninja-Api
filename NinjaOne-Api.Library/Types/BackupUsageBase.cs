namespace NinjaOne_Api.Library.Types;

public class BackupUsageBase
{
    [JsonPropertyName(Property.RevisionsCurrentSize)]
    public long? RevisionsCurrentSize { get; internal set; }
    [JsonPropertyName(Property.RevisionsPreviousSize)]
    public long? RevisionsPreviousSize { get; internal set; }
    [JsonPropertyName(Property.RevisionsDeletedSize)]
    public long? RevisionsDeletedSize { get; internal set; }
    [JsonPropertyName(Property.LocalFileFolderSize)]
    public long? LocalFileFolderSize { get; internal set; }
    [JsonPropertyName(Property.LocalImageSize)]
    public long? LocalImageSize { get; internal set; }
    [JsonPropertyName(Property.CloudFileFolderSize)]
    public long? CloudFileFolderSize { get; internal set; }
    [JsonPropertyName(Property.CloudImageSize)]
    public long? CloudImageSize { get; internal set; }
    [JsonPropertyName(Property.RevisionsTotalSize)]
    public long? RevisionsTotalSize { get; internal set; }
    [JsonPropertyName(Property.CloudTotalSize)]
    public long? CloudTotalSize { get; internal set; }
    [JsonPropertyName(Property.LocalTotalSize)]
    public long? LocalTotalSize { get; internal set; }

    [JsonConstructor]
    internal BackupUsageBase(
        long? revisionsCurrentSize,
        long? revisionsPreviousSize,
        long? revisionsDeletedSize,
        long? localFileFolderSize,
        long? localImageSize,
        long? cloudFileFolderSize,
        long? cloudImageSize,
        long? revisionsTotalSize,
        long? cloudTotalSize,
        long? localTotalSize
    )
    {
        RevisionsCurrentSize = revisionsCurrentSize;
        RevisionsPreviousSize = revisionsPreviousSize;
        RevisionsDeletedSize = revisionsDeletedSize;
        LocalFileFolderSize = localFileFolderSize;
        LocalImageSize = localImageSize;
        CloudFileFolderSize = cloudFileFolderSize;
        CloudImageSize = cloudImageSize;
        RevisionsTotalSize = revisionsTotalSize;
        CloudTotalSize = cloudTotalSize;
        LocalTotalSize = localTotalSize;
    }
}