using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network
{
	class PlayerUpdateMessage : Message
	{
		int PlayerID;
		bool Ready;
		PlayerClass Class;
		string Name;
		bool Host = false;
		int MaxHealth;

		public PlayerUpdateMessage(Player p)
		{
			this.PlayerID = p.PlayerID;

			this.Ready = p.Ready;
			this.Class = p.Class;
			this.Name = p.Name;
			this.Host = (p == BattleArena.Instance.Host);

			this.MaxHealth = p.MaxHealth;
		}

		public PlayerUpdateMessage() { }

		protected override void ExecuteMessage()
		{
			bool Found = false;
			foreach (Player player in BattleArena.Instance.Players){
				if (player.PlayerID == PlayerID) {

					UpdatePlayerInfo(player);
					
					Found = true;
					break;
				}
			}

			if (!Found) {
				Player player = new Player();
				player.PlayerID = this.PlayerID;

				UpdatePlayerInfo(player);

				BattleArena.Instance.Players.Add(player);
			}

			BattleArena.Instance.UpdateRequired = true;
			this.Forward();
		}

		private void UpdatePlayerInfo(Player player)
		{
			player.Ready = this.Ready;
			player.Class = this.Class;
			player.Name = this.Name;

			player.MaxHealth = this.MaxHealth;

			if (Host) {
				BattleArena.Instance.Host = player;
			}
		}
	}
}
