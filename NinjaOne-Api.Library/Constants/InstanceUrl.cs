// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Constants;

public static class InstanceUrl
{
    private const string EU = "https://eu.ninjarmm.com";
    private const string OC = "https://oc.ninjarmm.com";
    private const string US = "https://app.ninjarmm.com";

    public static string GetInstanceUrl(Instance instance)
    {
        return instance switch
        {
            Instance.EU => EU,
            Instance.OC => OC,
            Instance.US => US,
            _ => throw new ArgumentOutOfRangeException(nameof(instance), instance, null)
        };
    }
}