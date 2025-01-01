using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Network.Handler;
using Protocol;
using UnityEngine;


namespace Assets.Scripts.Network.Handler
{
	public partial class PacketHandler
	{
		private void _Process_S_Spawn_Handler( ushort protocolId, byte[] data )
		{
			S_Spawn message = S_Spawn.Parser.ParseFrom( data );
		}
	}
}