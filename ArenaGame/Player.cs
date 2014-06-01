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

		public int Health { get; internal set; }
		public int MaxHealth = 10;
		public string Name = "Unknown Player";
		public bool Ready = false;
		public PlayerClass Class = PlayerClass.Knight;

		public double ActionPoints { get; internal set; }


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

		public void AddActionPoints(double AP)
		{
			if (this.ActionPoints + AP > 10) AP = 10 - this.ActionPoints;
			if (this.ActionPoints + AP < 0) AP = -this.ActionPoints;
			this.ActionPoints += AP;

			new Network.PlayerUpdateMessages.PlayerActionPointsMessage() { PlayerID = this.PlayerID, ActionPointsChange = AP }.Send();
		}

		public void AddHealth(int HP)
		{
			if (this.Health + HP > this.MaxHealth) HP = this.MaxHealth - this.Health;
			if (this.Health + HP < 0) HP = -this.Health;
			this.Health += HP;

			new Network.PlayerUpdateMessages.PlayerHealthMessage() { PlayerID = this.PlayerID, HealthChange = HP }.Send();
		}

		internal void Update(double dt)
		{
			this.AddActionPoints(1.0 * dt);
		}
	}
}
