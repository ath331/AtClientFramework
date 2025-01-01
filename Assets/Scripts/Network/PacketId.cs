using System;
using UnityEngine;


namespace Assets.Scripts.Network
{
    enum EPacketId
    {
        PKT_C_Login = 1000,
        PKT_S_Login = 1001,
        PKT_C_EnterGame = 1002,
        PKT_S_EnterGame = 1003,
        PKT_C_LeaveGame = 1004,
        PKT_S_LeaveGame = 1005,
        PKT_C_Move = 1006,
        PKT_S_Move = 1007,
        PKT_S_Spawn = 1008,
        PKT_S_DeSpawn = 1009,
        PKT_C_Chat = 1010,
        PKT_S_Chat = 1011,
    }

    public class PacketIdFactory
    {
        public static ushort GetPacketId( string packetName )
        {
            try
            {
                packetName = "PKT_" + packetName;

                if ( Enum.TryParse< EPacketId >( packetName, true, out var result ) )
                    return (ushort)( result );

                // Debug.LogError( $"Invalid packet name: {packetName}" );
                return 0;
            }
            catch ( Exception ex )
            {
                Debug.LogError( $"Error parsing packet name: {packetName}. Exception: {ex}" );
                return 0;
            }
        }
    }
}