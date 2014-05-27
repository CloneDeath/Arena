using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Lidgren.Network;

namespace Arena.Game.Network.PlayerJoining
{
	class RequestPlayerSlotMessage : Message
	{
		protected override void ExecuteMessage()
		{
			foreach (Player p in BattleArena.Instance.Players) {
				new PlayerUpdateMessage(p).Reply(this, NetDeliveryMethod.ReliableOrdered);
			}

			new PlayerSlotAssignmentMessage(BattleArena.Instance.Players.Count).Reply(this, NetDeliveryMethod.ReliableOrdered);
		}
	}
}
