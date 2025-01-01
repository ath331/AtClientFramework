using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Assets.Scripts.Network;
using Protocol;
using Google.Protobuf;


namespace Assets.Scripts.Network.Packet.Login
{
	public class Packet_C_Login : MonoBehaviour
	{
		public void Send_C_Login()
		{
			C_Login pkt = new C_Login();
            pkt.Id = "ath331";
            pkt.Pw = 1234;

            Network.Instance.Send( pkt );
		}
	}
}