﻿// ReSharper disable InconsistentNaming
namespace NinjaOne_Api.Library.Enums;

public enum SourceType
{
    AGENT_OFFLINE,
    CONDITION_AGENT_CPU,
    CONDITION_AGENT_MEMORY,
    CONDITION_AGENT_NETWORK,
    CONDITION_AGENT_DISK_IO,
    CONDITION_AGENT_DISK_FREE_SPACE,
    CONDITION_AGENT_DISK_USAGE,
    CONDITION_AGENT_PATCH_LAST_INSTALLED,
    CONDITION_NMS_CPU,
    CONDITION_NMS_MEMORY,
    CONDITION_NMS_NETWORK_TRAFFIC_BITS,
    CONDITION_NMS_NETWORK_TRAFFIC_PERCENT,
    CONDITION_NMS_NETWORK_STATUS,
    CONDITION_NMS_NETWORK_STATUS_CHANGE,
    CONDITION_PING,
    CONDITION_PING_LATENCY,
    CONDITION_PING_PACKET_LOSS,
    CONDITION_PING_RESPONSE,
    CONDITION_SYSTEM_UPTIME,
    CONDITION_SMART_STATUS_DEGRATED,
    CONDITION_RAID_HEALTH_STATUS,
    CONDITION_SCRIPT_RESULT,
    CONDITION_HTTP,
    CONDITION_PORT,
    CONDITION_PORT_SCAN,
    CONDITION_SYSLOG,
    CONDITION_CONFIGURATION_FILE,
    CONDITION_SNMPTRAP,
    CONDITION_CRITICAL_EVENT,
    CONDITION_DNS,
    CONDITION_EMAIL,
    SHADOWPROTECT_BACKUPJOB_CREATE,
    SHADOWPROTECT_BACKUPJOB_UPDATE,
    SHADOWPROTECT_BACKUPJOB_DELETE,
    SHADOWPROTECT_BACKUPJOB_EXECUTE,
    IMAGEMANAGER_MANAGEDFOLDER_CREATE,
    IMAGEMANAGER_MANAGEDFOLDER_UPDATE,
    IMAGEMANAGER_MANAGEDFOLDER_DELETE,
    IMAGEMANAGER_MANAGEDFOLDER_EXECUTE,
    TEAMVIEWER_CONNECTION,
    RETRIEVE_AGENT_LOGS,
    SCHEDULED_TASK,
    CONDITION_WINDOWS_EVENT_LOG_TRIGGERED,
    CONDITION_WINDOWS_SERVICE_STATE_CHANGED,
    UI_MESSAGE_ACTION_REBOOT,
    UI_MESSAGE_BD_INSTALLATION_ISSUES,
    GRAVITYZONE_UI_MESSAGE_INSTALLATION_ISSUES,
    AV_QUARANTINE_THREAT,
    AV_RESTORE_THREAT,
    AV_DELETE_THREAT,
    AV_REMOVE_THREAT,
    BITDEFENDER_RESTORE_THREAT,
    BITDEFENDER_DELETE_THREAT,
    CONDITION_BITLOCKER_STATUS,
    CONDITION_FILEVAULT_STATUS,
    CONDITION_LINUX_PROCESS,
    CONDITION_LINUX_Daemon,
    CONDITION_LINUX_PROCESS_RESOURCE,
    CONDITION_LINUX_PROCESS_RESOURCE_CPU,
    CONDITION_LINUX_PROCESS_RESOURCE_MEMORY,
    CONDITION_LINUX_DISK_FREE_SPACE,
    CONDITION_LINUX_DISK_USAGE,
    CONDITION_VM_AGGREGATE_CPU_USAGE,
    CONDITION_VM_DISK_USAGE,
    CONDITION_VM_HOST_DATASTORE,
    CONDITION_VM_HOST_UPTIME,
    CONDITION_VM_HOST_DEVICE_DOWN,
    CONDITION_VM_HOST_BAD_SENSORS,
    CONDITION_VM_HOST_SENSOR_HEALTH,
    CONDITION_VM_GUEST_GUEST_OPERATIONAL_MODE,
    CONDITION_VM_GUEST_SNAPSHOT_SIZE,
    CONDITION_VM_GUEST_SNAPSHOT_LIFESPAN,
    CONDITION_VM_GUEST_TOOLS_NOT_RUNNING,
    CONDITION_HV_GUEST_CHECKPOINT_SIZE,
    CONDITION_HV_GUEST_CHECKPOINT_LIFESPAN,
    CONDITION_SOFTWARE,
    CONDITION_WINDOWS_PROCESS_STATE,
    CONDITION_WINDOWS_PROCESS_RESOURCE_CPU,
    CONDITION_WINDOWS_PROCESS_RESOURCE_MEMORY,
    CONDITION_MAC_PROCESS_STATE,
    CONDITION_MAC_PROCESS_RESOURCE_CPU,
    CONDITION_MAC_PROCESS_RESOURCE_MEMORY,
    CONDITION_MAC_DEAMON,
    CONDITION_CUSTOM_FIELD,
    CONDITION_PENDING_REBOOT
}