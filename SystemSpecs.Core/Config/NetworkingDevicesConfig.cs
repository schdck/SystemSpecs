﻿using System;
using System.Collections.Generic;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.Core.Config
{
    public static class NetworkingDevicesConfig
    {
        public static Dictionary<string, Type> DefaultPropertiesTypesForAdapter = new Dictionary<string, Type>
        {
            { "AdapterType", typeof(string)},
            { "AdapterTypeID", typeof(AdapterTypeID)},
            { "AutoSense", typeof(bool)},
            { "Availability", typeof(Availability)},
            { "Caption", typeof(string)},
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode)},
            { "ConfigManagerUserConfig", typeof(bool)},
            { "CreationClassName", typeof(string)},
            { "Description", typeof(string)},
            { "DeviceID", typeof(string)},
            { "ErrorCleared", typeof(bool)},
            { "ErrorDescription", typeof(string)},
            { "GUID", typeof(string)},
            { "Index", typeof(uint)},
            { "InstallDate", typeof(string)}, // datetime
            { "Installed", typeof(bool)},
            { "InterfaceIndex", typeof(uint)},
            { "LastErrorCode", typeof(uint)},
            { "MACAddress", typeof(string)},
            { "Manufacturer", typeof(string)},
            { "MaxNumberControlled", typeof(uint)},
            { "MaxSpeed", typeof(ulong)},
            { "Name", typeof(string)},
            { "NetConnectionID", typeof(string)},
            { "NetConnectionStatus", typeof(NetConnectionStatus)},
            { "NetEnabled", typeof(bool)},
            { "NetworkAddresses", typeof(string[])},
            { "PermanentAddress", typeof(string)},
            { "PhysicalAdapter", typeof(bool)},
            { "PNPDeviceID", typeof(string)},
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[])},
            { "PowerManagementSupported", typeof(bool)},
            { "ProductName", typeof(string)},
            { "ServiceName", typeof(string)},
            { "Speed", typeof(ulong)},
            { "Status", typeof(string)},
            { "StatusInfo", typeof(StatusInfo)},
            { "SystemCreationClassName", typeof(string)},
            { "SystemName", typeof(string)},
            { "TimeOfLastReset", typeof(string)}, // datetime
        };

        public static Dictionary<string, Type> DefaultPropertiesTypesForAdapterConfiguration = new Dictionary<string, Type>
        {
            { "Caption", typeof(string)},
            { "Description", typeof(string)},
            { "SettingID", typeof(string)},
            { "ArpAlwaysSourceRoute", typeof(bool)},
            { "ArpUseEtherSNAP", typeof(bool)},
            { "DatabasePath", typeof(string)},
            { "DeadGWDetectEnabled", typeof(bool)},
            { "DefaultIPGateway", typeof(string[])},
            { "DefaultTOS", typeof(ushort)},
            { "DefaultTTL", typeof(ushort)},
            { "DHCPEnabled", typeof(bool)},
            { "DHCPLeaseExpires", typeof(string)}, // datetime
            { "DHCPLeaseObtained", typeof(string)}, // datetime
            { "DHCPServer", typeof(string)},
            { "DNSDomain", typeof(string)},
            { "DNSDomainSuffixSearchOrder", typeof(string[])},
            { "DNSEnabledForWINSResolution", typeof(bool)},
            { "DNSHostName", typeof(string)},
            { "DNSServerSearchOrder", typeof(string[])},
            { "DomainDNSRegistrationEnabled", typeof(bool)},
            { "ForwardBufferMemory", typeof(uint)},
            { "FullDNSRegistrationEnabled", typeof(bool)},
            { "GatewayCostMetric", typeof(ushort[])},
            { "IGMPLevel", typeof(IGMPLevel)},
            { "Index", typeof(uint)},
            { "InterfaceIndex", typeof(uint)},
            { "IPAddress", typeof(string[])},
            { "IPConnectionMetric", typeof(uint)},
            { "IPEnabled", typeof(bool)},
            { "IPFilterSecurityEnabled", typeof(bool)},
            { "IPPortSecurityEnabled", typeof(bool)},
            { "IPSecPermitIPProtocols", typeof(string[])},
            { "IPSecPermitTCPPorts", typeof(string[])},
            { "IPSecPermitUDPPorts", typeof(string[])},
            { "IPSubnet", typeof(string[])},
            { "IPUseZeroBroadcast", typeof(bool)},
            { "IPXAddress", typeof(string)},
            { "IPXEnabled", typeof(bool)},
            { "IPXFrameType", typeof(IPXFrameType[])},
            { "IPXMediaType", typeof(IPXMediaType)},
            { "IPXNetworkNumber", typeof(string[])},
            { "IPXVirtualNetNumber", typeof(string)},
            { "KeepAliveInterval", typeof(uint)},
            { "KeepAliveTime", typeof(uint)},
            { "MACAddress", typeof(string)},
            { "MTU", typeof(uint)},
            { "NumForwardPackets", typeof(uint)},
            { "PMTUBHDetectEnabled", typeof(bool)},
            { "PMTUDiscoveryEnabled", typeof(bool)},
            { "ServiceName", typeof(string)},
            { "TcpipNetbiosOptions", typeof(TcpipNetbiosOptions)},
            { "TcpMaxConnectRetransmissions", typeof(uint)},
            { "TcpMaxDataRetransmissions", typeof(uint)},
            { "TcpNumConnections", typeof(uint)},
            { "TcpUseRFC1122UrgentPointer", typeof(bool)},
            { "TcpWindowSize", typeof(ushort)},
            { "WINSEnableLMHostsLookup", typeof(bool)},
            { "WINSHostLookupFile", typeof(string)},
            { "WINSPrimaryServer", typeof(string)},
            { "WINSScopeID", typeof(string)},
            { "WINSSecondaryServer", typeof(string)},
        };

        public static string[] DefaultDisplayedProperties =
        {
            "AdapterType",
            "Availability",
            "Caption",
            "ConfigManagerErrorCode",
            "ConfigManagerUserConfig",
            "Description",
            "DeviceID",
            "GUID",
            "Installed",
            "InterfaceIndex",
            "MACAdress",
            "Manufacturer",
            "MaxNumberControlled",
            "Name",
            "NetConnectionID",
            "NetConnectionStatus",
            "NetEnabled",
            "PhysicalAdapter",
            "PNPDeviceID",
            "PowerManagementSupported",
            "ProductName",
            "ServiceName",
            "Speed",
            "SystemCreationClassName"
        };
    }
}