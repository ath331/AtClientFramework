using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Network;
using Protocol;
using Google.Protobuf;


namespace Assets.Scripts.Network.Packet.Game
{
	public class Packet_C_LeaveGame : MonoBehaviour
	{
		// base.Start() block
		public void Start() {}

		public void Send_C_LeaveGame()
		{
			C_LeaveGame pkt = new C_LeaveGame();

			Network.Instance.Send( pkt );
		}
	}
}