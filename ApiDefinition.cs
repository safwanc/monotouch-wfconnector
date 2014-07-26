//
//  ApiDefinition.cs
//
//  Author:
//       Safwan Choudhury <im@safwanc.com>
//
using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WFConnector
{
    [DisableDefaultCtorAttribute]
    [BaseType(typeof(NSObject))]
    interface WFHardwareConnector
    {
        [Export("apiVersion")]
        string APIVersion { get; }

        [Export("isBTLEEnabled")]
        bool IsBTLEEnabled { get; }

        [Export("isCommunicationHWReady")]
        bool IsCommunicationHWReady { get; }

        [Export("sampleRate")]
        double SampleRate { get; set; }

        [Export("hasBTLESupport")]
        bool HasBTLESupport { get; }

        [Export("availableChannelCount")]
        char AvailableChannelCount { get; }

        [Export("currentState")]
        WFHardwareConnectorState CurrentState { get; } 

        [Static]
        [Export("sharedConnector")]
        WFHardwareConnector SharedConnector { get; }

        [Export("discoverDevicesOfType:onNetwork:searchTimeout:")]
        bool DiscoverDevices(WFSensorType SensorType, WFNetworkType NetworkType, double SearchTimeout); 

        [Export("cancelDiscoveryOnNetwork:")]
        NSSet CancelDiscoveryOnNetwork(WFNetworkType NetworkType); 

        [Export("enableBTLE:")]
        bool EnableBTLE(bool Enable); 

        [Export("enableBTLE:inBondingMode:")]
        bool EnableBTLE(bool Enable, bool BondingMode); 

        [Export("getSensorConnections:")]
        NSArray GetSensorConnections(WFSensorType SensorType); 

        [Export("requestSensorConnection:")]
        WFSensorConnection RequestSensorConnection(WFConnectionParams Params); 

        [Export("requestSensorConnection:withProximity:")]
        WFSensorConnection RequestSensorConnection(WFConnectionParams Params, WFProximityRange Proximity); 
    }

    [BaseType(typeof(NSObject))]
    interface WFConnectionParams
    {
        // TODO
    }

    [BaseType(typeof(NSObject))]
    interface WFSensorConnection
    {
        // TODO
    }

    [BaseType(typeof(NSObject))]
    interface WFBikeSpeedCadenceConnection
    {
        // TODO
    }

    [BaseType(typeof(NSObject))]
    interface WFBikeSpeedCadenceData
    {
        // TODO
    }

}

