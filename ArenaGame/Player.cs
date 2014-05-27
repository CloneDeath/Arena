using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena.Game
{
	public class Player
	{
		internal int PlayerID = -1;

		public int Health = 100;
		public int MaxHealth = 100;
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
			new Network.PlayerUpdateMessage(this).Send();
		}
	}
}
