using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network.PlayerJoining
{
	class PlayerSlotAssignmentMessage : Message
	{
		public PlayerSlotAssignmentMessage() { }
		public PlayerSlotAssignmentMessage(int PlayerID)
		{
			this.PlayerID = PlayerID;
		}

		int PlayerID;
		protected override void ExecuteMessage()
		{
			BattleArena.Instance.Self.PlayerID = PlayerID;
			BattleArena.Instance.Self.SendUpdate();
			BattleArena.Instance.RefreshRequired = true;
		}
	}
}
