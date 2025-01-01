using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Network;
using UnityEngine;


namespace Assets.Scripts.Network.Handler
{
	public partial class PacketHandler
	{
		public void ProcessHandler( ushort protocolId, byte[] data )
		{
			EPacketId packetId = (EPacketId)( protocolId );
			switch ( packetId )
			{
			case EPacketId.PKT_S_Login: { _Process_S_Login_Handler( protocolId, data ); } break;
			case EPacketId.PKT_S_EnterGame: { _Process_S_EnterGame_Handler( protocolId, data ); } break;
			case EPacketId.PKT_S_LeaveGame: { _Process_S_LeaveGame_Handler( protocolId, data ); } break;
			case EPacketId.PKT_S_Move: { _Process_S_Move_Handler( protocolId, data ); } break;
			case EPacketId.PKT_S_Spawn: { _Process_S_Spawn_Handler( protocolId, data ); } break;
			case EPacketId.PKT_S_DeSpawn: { _Process_S_DeSpawn_Handler( protocolId, data ); } break;
			case EPacketId.PKT_S_Chat: { _Process_S_Chat_Handler( protocolId, data ); } break;
			default:
				{
					Debug.LogWarning( $"Invalid Protocol ID : {protocolId}" );
				}
				break;
			}
		}
	}
}