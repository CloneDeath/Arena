using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network.PlayerJoining
{
	class RequestPlayerSlotMessage : Message
	{
		protected override void ExecuteMessage()
		{
			new PlayerSlotAssignmentMessage(BattleArena.Instance.Players.Count).Reply();

			foreach (Player p in BattleArena.Instance.Players) {
				new PlayerUpdateMessage(p).Reply();
			}
		}
	}
}
