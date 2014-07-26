//
//  StructsAndEnums.cs
//
//  Author:
//       Safwan Choudhury <im@safwanc.com>
//
using System;

namespace WFConnector
{
    [Flags]
    public enum WFHardwareConnectorState
    {
        /** The fisica device is not physically connected to the iPod. */
        WF_HWCONN_STATE_NOT_CONNECTED                = 0,
        /** The fisica device is physically connected to the iPod. */
        WF_HWCONN_STATE_CONNECTED                    = 0x01,
        /** The fisica device is connected and communication is established (norml operating mode). */
        WF_HWCONN_STATE_ACTIVE                       = 0x02,
        /** The fisica device is performing a reset operation. */
        WF_HWCONN_STATE_RESET                        = 0x04,
        /** The BTLE hardware is enabled. */
        WF_HWCONN_STATE_BT40_ENABLED                 = 0x08,
        /** The BTLE controller is in bonding mode. */
        WF_HWCONN_STATE_BT_BONDING_MODE              = 0x10,
    }

    [Flags]
    public enum WFNetworkType
    {
        /**
         * The network type is not specified.
         *
         * This value may not be used for connection requests.  If used, the connection
         * request will fail.
         */
        WF_NETWORKTYPE_UNSPECIFIED                      = 0,
        /** Default, ANT+ standard network */
        WF_NETWORKTYPE_ANTPLUS                          = 0x01,
        /** Specifies BTLE devices */
        WF_NETWORKTYPE_BTLE                             = 0x02,
        /** Specifies Suunto devices */
        WF_NETWORKTYPE_SUUNTO                           = 0x04,

        /**
         * Wildcard for any available network.
         *
         * This value may be specified in connection request.  When used, connection
         * attempt is made on any available network.  The first connection to be
         * established will be used.  Connection requests on other network types
         * will be cancelled.
         */

        WF_NETWORKTYPE_ANY                              = 0x01 | 0x04 | 0x02,
    }

    [Flags]
    public enum WFSensorType
    {
        /** Specifies non-existent sensor. */
        WF_SENSORTYPE_NONE                           = 0,
        /** Specifies the bike power sensor. */
        WF_SENSORTYPE_BIKE_POWER                     = 0x00000001,
        /** Specifies the bike speed sensor. */
        WF_SENSORTYPE_BIKE_SPEED                     = 0x00000002,
        /** Specifies the bike cadence sensor. */
        WF_SENSORTYPE_BIKE_CADENCE                   = 0x00000004,
        /** Specifies the combined bike speed and cadence sensor. */
        WF_SENSORTYPE_BIKE_SPEED_CADENCE             = 0x00000008,
        /** Specifies the FootPod stride and distance sensor. */
        WF_SENSORTYPE_FOOTPOD                        = 0x00000010,
        /** Specifies the heart rate monitor sensor. */
        WF_SENSORTYPE_HEARTRATE                      = 0x00000020,
        /** Specifies the Weight Scale monitor sensor */
        WF_SENSORTYPE_WEIGHT_SCALE                   = 0x00000040,
        /** Specifies a generic ANT FS device. */
        WF_SENSORTYPE_ANT_FS                         = 0x00000080,
        /** Specifies the GPS location sensor. */
        WF_SENSORTYPE_LOCATION                       = 0x00000100,
        /** Specifies the calorimeter sensor. */
        WF_SENSORTYPE_CALORIMETER                    = 0x00000200,
        /** Specifies the GeoCache sensor. */
        WF_SENSORTYPE_GEO_CACHE                      = 0x00000400,
        /** Specifies the Fitness Equipment sensor. */
        WF_SENSORTYPE_FITNESS_EQUIPMENT              = 0x00000800,
        /** Specifies the Multi-Sport Speed and Distance sensor. */
        WF_SENSORTYPE_MULTISPORT_SPEED_DISTANCE      = 0x00001000,
        /** Specifies the BTLE Proximity sensor. */
        WF_SENSORTYPE_PROXIMITY                      = 0x00002000,
        /** Specifies the BTLE Health Thermometer sensor. */
        WF_SENSORTYPE_HEALTH_THERMOMETER             = 0x00004000,
        /** Specifies the BTLE Blood Pressure sensor. */
        WF_SENSORTYPE_BLOOD_PRESSURE                 = 0x00008000,
        /** Specifies the BTLE Blood Glucose Monitor sensor. */
        WF_SENSORTYPE_BTLE_GLUCOSE                   = 0x00010000,
        /** Specifies the ANT+ Blood Glucose Monitor sensor. */
        WF_SENSORTYPE_GLUCOSE                        = 0x00020000,
        /** Specifies the BTLE Display sensor. */
        WF_SENSORTYPE_DISPLAY                        = 0x00800000,
    }

    [Flags]
    public enum WFSensorConnectionStatus
    {
        /** No active connection. */
        WF_SENSOR_CONNECTION_STATUS_IDLE,
        /** The connection is in process of being established. */
        WF_SENSOR_CONNECTION_STATUS_CONNECTING,
        /** The sensor connection is established and active. */
        WF_SENSOR_CONNECTION_STATUS_CONNECTED,
        /** The connection was interrupted (usually occurs when fisica is disconnected). */
        WF_SENSOR_CONNECTION_STATUS_INTERRUPTED,
        /** The connection is in process of being disconnected. */
        WF_SENSOR_CONNECTION_STATUS_DISCONNECTING,
    }

    public enum WFProximityRange
    {
        /** Proximity searching is disabled. */
        WF_PROXIMITY_RANGE_DISABLED,
        /** Proximity range 1 of 10 (closest range). */
        WF_PROXIMITY_RANGE_1,
        /** Proximity range 2 of 10. */
        WF_PROXIMITY_RANGE_2,
        /** Proximity range 3 of 10. */
        WF_PROXIMITY_RANGE_3,
        /** Proximity range 4 of 10. */
        WF_PROXIMITY_RANGE_4,
        /** Proximity range 5 of 10. */
        WF_PROXIMITY_RANGE_5,
        /** Proximity range 6 of 10. */
        WF_PROXIMITY_RANGE_6,
        /** Proximity range 7 of 10. */
        WF_PROXIMITY_RANGE_7,
        /** Proximity range 8 of 10. */
        WF_PROXIMITY_RANGE_8,
        /** Proximity range 9 of 10. */
        WF_PROXIMITY_RANGE_9,
        /** Proximity range 10 of 10 (farthest range). */
        WF_PROXIMITY_RANGE_10,
    }
}