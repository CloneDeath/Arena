using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;

namespace Arena.Game
{
	public class Player
	{
		internal int PlayerID = -1;

		int _health;
		public int Health
		{
			get
			{
				return _health;
			}
			set
			{
				_health = (value < 0) ? 0 : value;
			}
		}

		public int MaxHealth = 10;
		public string Name = "Unknown Player";
		public bool Ready = false;
		public PlayerClass Class = PlayerClass.Knight;
		public Lidgren.Network.NetPeer Connection;

		public override string ToString()
		{
			return Name + ", " + Class.ToString() + (Ready ? " (Ready)" : "");
		}

		public void SendUpdate()
		{
			if (PlayerID != -1) {
				new Network.PlayerUpdateMessage(this).Send(NetDeliveryMethod.ReliableOrdered);
			}
		}
	}
}
