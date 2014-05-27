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

		public PlayerUpdateMessage(Player p)
		{
			this.PlayerID = p.PlayerID;

			this.Ready = p.Ready;
			this.Class = p.Class;
			this.Name = p.Name;
			this.Host = (p == BattleArena.Instance.Host);
		}

		public PlayerUpdateMessage() { }

		protected override void ExecuteMessage()
		{
			bool Found = false;
			foreach (Player player in BattleArena.Instance.Players){
				if (player.PlayerID == PlayerID) {
					player.Ready = this.Ready;
					player.Class = this.Class;
					player.Name = this.Name;
					
					if (Host) {
						BattleArena.Instance.Host = player;
					}

					Found = true;
					break;
				}
			}

			if (!Found) {
				Player player = new Player();
				player.PlayerID = this.PlayerID;
				player.Ready = this.Ready;
				player.Class = this.Class;
				player.Name = this.Name;

				if (Host) {
					BattleArena.Instance.Host = player;
				}

				BattleArena.Instance.Players.Add(player);
			}

			BattleArena.Instance.RefreshRequired = true;
			this.Forward();
		}
	}
}
