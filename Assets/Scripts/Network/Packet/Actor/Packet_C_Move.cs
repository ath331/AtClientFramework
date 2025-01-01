using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Network;
using Protocol;
using Google.Protobuf;


namespace Assets.Scripts.Network.Packet.Actor
{
	public class Packet_C_Move : MonoBehaviour
	{
		// base.Start() block
		public void Start() {}

		public void Send_C_Move()
		{
			C_Move pkt = new C_Move();

			Network.Instance.Send( pkt );
		}
	}
}