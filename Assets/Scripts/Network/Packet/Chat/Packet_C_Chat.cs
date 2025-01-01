using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Network;
using Protocol;
using Google.Protobuf;


namespace Assets.Scripts.Network.Packet.Chat
{
	public class Packet_C_Chat : MonoBehaviour
	{
		// base.Start() block
		public void Start() {}

		public void Send_C_Chat()
		{
			C_Chat pkt = new C_Chat();

			Network.Instance.Send( pkt );
		}
	}
}