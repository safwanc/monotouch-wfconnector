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

        [Export("settings")]
        WFConnectorSettings Settings { get; }

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

        [Export("requestSensorConnection:withProximity:error:")]
        WFSensorConnection RequestSensorConnection(WFConnectionParams Params, WFProximityRange Proximity, NSError Error);

        [Export("resetConnections")]
        bool ResetConnections(); 

        [Export("resetSampleTimer")]
        void ResetSampleTimer(); 

        [Export("setSampleTimerDataCheck:")]
        void SetSampleTimerDataCheck(bool CheckData); 

        [Export("prepareForBackground")]
        void PrepareForBackground(); 

        [Export("returnFromBackground")]
        void ReturnFromBackground(); 

        [Export("resetAllSensorData")]
        bool ResetAllSensorData(); 

        [Static]
        [Export("sharedConnector")]
        WFHardwareConnector SharedConnector { get; }
    }

    [BaseType(typeof(NSObject))]
    interface WFDeviceParams
    {
        [Export("networkType")]
        WFNetworkType NetworkType { get; } 

        [Export("deviceIDString")]
        NSString DeviceIDString { get; }

        [Export("deviceUUIDString")]
        NSString DeviceUUIDString { get; }

        [Export("deviceNumber")]
        short DeviceNumber { get; }

        [Export("transmissionType")]
        char TransmissionType { get; }

        [Export("isValid")]
        bool IsValid(); 
    }

    [BaseType(typeof(NSObject))]
    interface WFConnectionParams
    {
        [Export("device1")]
        WFDeviceParams Device1 { get; }

        [Export("device2")]
        WFDeviceParams Device2 { get; }

        [Export("device3")]
        WFDeviceParams Device3 { get; }

        [Export("device4")]
        WFDeviceParams Device4 { get; }

        [Export("conditionalComparisonType")]
        WFComparisonType ConditionalComparisonType { get; set; }

        [Export("conditionalData")]
        NSData ConditionalData { get; set; }

        [Export("isConnectionConditional")]
        bool IsConnectionConditional { get; }

        [Export("isWildcard")]
        bool IsWildcard { get; }

        [Export("networkType")]
        WFNetworkType NetworkType { get; set; }

        [Export("searchTimeout")]
        short SearchTimeout { get; set; }

        [Export("sensorType")]
        WFSensorType SensorType { get; set; }

        [Export("sensorSubType")]
        WFSensorSubType SensorSubType { get; set; }

        [Export("hasDeviceNumber:")]
        bool HasDeviceNumber(short DeviceNumber); 

        [Export("hasDeviceUUID:")]
        bool HasDeviceUUID(NSString UUIDString); 
    }

    [BaseType(typeof(NSObject))]
    interface WFConnectorSettings
    {
        [Export("bikeCoastingTimeout")]
        double BikeCoastingTimeout { get; set; }

        [Export("bikeWheelCircumference")]
        float BikeWheelCircumference { get; set; }

        [Export("searchTimeout")]
        double SearchTimeout { get; set; }

        [Export("discoveryTimeout")]
        double DiscoveryTimeout { get; set; }

        [Export("staleDataString")]
        NSString StaleDataString { get; set; }

        [Export("staleDataTimeout")]
        double StaleDataTimeout { get; set; }

        [Export("useMetricUnits")]
        bool UseMetricUnits { get; set; }

        [Export("connectionParamsForSensorType:")]
        WFConnectionParams ConnectionParamsForSensorType(WFSensorType SensorType); 

        [Export("deviceParamsForSensorType:")]
        NSArray DeviceParamsForSensorType(WFSensorType SensorType); 

        [Export("removeDeviceParams:forSensorType:")]
        bool RemoveDeviceParamsForSensorType(WFDeviceParams DeviceParams, WFSensorType SensorType); 

        [Export("saveConnectionInfo:")]
        bool SaveConnectionInfo(WFSensorConnection ConnectionInfo); 
    }

    [Model][Protocol]
    [BaseType(typeof(NSObject))]
    interface WFSensorConnectionDelegate
    {
        [Export("connectionDidTimeout:")]
        void ConnectionDidTimeout(WFSensorConnection ConnectionInfo); 

        [Export("connection:stateChanged:")]
        void ConnectionStateChanged(WFSensorConnection ConnectionInfo, WFSensorConnectionStatus ConnectionState); 

        [Export("connection:rejectedByDeviceNamed:appAlreadyConnected:")]
        void ConnectionRejected(WFSensorConnection ConnectionInfo, NSString DeviceName, NSString AlreadyConnectedAppName); 
    }

    [BaseType(typeof(NSObject))]
    interface WFSensorConnection
    {
        [Export("connectionStatus")]
        WFSensorConnectionStatus ConnectionStatus { get; }

        [Export("delegate")]
        WFSensorConnectionDelegate Delegate { get; set; }

        [Export("deviceIDString")]
        NSString DeviceIDString { get; }

        [Export("deviceNumber")]
        short DeviceNumber { get; }

        [Export("deviceUUIDString")]
        NSString DeviceUUIDString { get; }

        [Export("didTimeout")]
        bool DidTimeout { get; }

        [Export("error")]
        WFSensorConnectionError Error { get; }

        [Export("isConnected")]
        bool IsConnected { get; }

        [Export("isBTLEConnection")]
        bool IsBTLEConnection { get; }

        [Export("isANTConnection")]
        bool IsANTConnection { get; }

        [Export("isValid")]
        bool IsValid { get; }

        [Export("hasError")]
        bool HasError { get; }

        [Export("hasValidParams")]
        bool HasValidParams { get; }

        [Export("hasWildcardParams")]
        bool HasWildcardParams { get; }

        [Export("networkType")]
        WFNetworkType NetworkType { get; }

        [Export("sensorType")]
        WFSensorType SensorType { get; }

        [Export("sensorSubType")]
        WFSensorSubType SensorSubType { get; }

        [Export("timeSinceLastMessage")]
        double TimeSinceLastMessage { get; }

        [Export("transmissionType")]
        char TransmissionType { get; }

        [Export("disconnect")]
        void Disconnect(); 

        [Export("getData")]
        WFSensorData GetData(); 

        [Export("getRawData")]
        WFSensorData GetRawData(); 

        [Export("hasData")]
        bool HasData(); 

        [Export("signalEfficiency")]
        float SignalEfficiency { get; }
    }

    [BaseType(typeof(NSObject))]
    interface WFOdometerHistory
    {
        [Export("bikeWheelCircumference")]
        float BikeWheelCircumference { get; set; }

        [Export("ulCurrentWheelRevolutions")]
        ulong CurrentWheelRevolutions { get; }

        [Export("getDistanceForWeek:")]
        float GetDistanceForWeek(char Week); 

        [Export("getOdometerForWeek:")]
        float GetOdometerForWeek(char Week); 

        [Export("getWheelRevolutionsForWeek:")]
        ulong GetWheelRevolutionsForWeek(char Week); 
    }

    [Model][Protocol]
    [BaseType(typeof(NSObject))]
    interface WFBikeSpeedCadenceDelegate
    {
        [Export("cscConnection:didReceiveOdometerHistory:")]
        void DidReceiveOdometerHistory(WFBikeSpeedCadenceConnection Connection, WFOdometerHistory History); 

        [Export("cscConnection:didResetOdometer:")]
        void DidResetOdometer(WFBikeSpeedCadenceConnection Connection, bool Success); 

        [Export("cscConnection:didReceiveGearRatio:numerator:denominator:")]
        void DidReceiveGearRatio(WFBikeSpeedCadenceConnection Connection, bool Success, short Numerator, short Denominator); 

        [Export("cscConnection:didReceiveSetGearRatioResponse:")]
        void DidReceiveSetGearRatioResponse(WFBikeSpeedCadenceConnection Connection, bool Success); 
    }

    [BaseType(typeof(WFSensorConnection))]
    interface WFBikeSpeedCadenceConnection
    {
        [Export("cscDelegate")]
        WFBikeSpeedCadenceDelegate Delegate { get; set; }

        [Export("getBikeSpeedCadenceData")]
        WFBikeSpeedCadenceData GetBikeSpeedCadenceData(); 

        [Export("getBikeSpeedCadenceRawData")]
        WFBikeSpeedCadenceData GetBikeSpeedCadenceRawData(); 

        [Export("getCSCData")]
        WFBTLEBikeSpeedCadenceData GetCSCData(); 

        [Export("requestOdometerHistoryFrom:to:")]
        bool RequestOdometerHistory(char From, char To); 

        [Export("requestOdometerReset:")]
        bool RequestOdometerReset(float ResetValue);

        [Export("setDeviceTime")]
        bool SetDeviceTime(); 

        [Export("setDeviceGearRatioWithNumerator:andDenomonator:")]
        bool SetDeviceGearRatio(short Numerator, short Denominator); 

        [Export("getDeviceGearRatio")]
        bool GetDeviceGearRatio(); 

        // NOTE: Ignoring the following commands - 
        // - (BOOL)sendRecordCommand:(WFBTLEWahooCSCOpCode_t)opCode withOperator:(WFBTLERecordOperator_t)op operands:(NSData*)operands;
    }

    [BaseType(typeof(NSObject))]
    interface WFSensorData
    {
        [Export("isDataStale")]
        bool IsDataStale { get; }

        [Export("settings")]
        WFConnectorSettings Settings { get; }

        [Export("initWithTime:")]
        NSObject InitWithTime(double DataTime); 
    }

    [BaseType(typeof(NSObject))]
    interface WFBikeSpeedCadenceData
    {
        [Export("accumCrankRevolutions")]
        ulong AccumCrankRevolutions { get; }

        [Export("accumCadenceTime")]
        float AccumCadenceTime { get; }

        [Export("instantCrankRPM")]
        char InstantCrankRPM { get; }

        [Export("cadenceTimestamp")]
        double CadenceTimestamp { get; }

        [Export("cadenceTimestampOverflow")]
        bool CadenceTimestampOverflow { get; }

        [Export("accumWheelRevolutions")]
        ulong AccumWheelRevolutions { get; }

        [Export("accumSpeedTime")]
        float AccumSpeedTime { get; }

        [Export("instantWheelRPM")]
        short InstantWheelRPM { get; }

        [Export("speedTimestamp")]
        double SpeedTimestamp { get; }

        [Export("speedTimestampOverflow")]
        bool SpeedTimestampOverflow { get; }

        [Export("formattedCadence:")]
        NSString FormattedCadence(bool ShowUnits); 

        [Export("formattedDistance:")]
        NSString FormattedDistance(bool ShowUnits); 

        [Export("formattedSpeed:")]
        NSString FormattedSpeed(bool ShowUnits); 
    }

    [BaseType(typeof(WFBikeSpeedCadenceData))]
    interface WFBTLEBikeSpeedCadenceData
    {
        // TODO
    }
}

