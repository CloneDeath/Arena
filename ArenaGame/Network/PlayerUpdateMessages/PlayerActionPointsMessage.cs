using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network.PlayerUpdateMessages
{
	class PlayerActionPointsMessage : Message
	{
		public double ActionPointsChange;
		public int PlayerID;

		protected override void ExecuteMessage()
		{
			BattleArena.Instance.GetPlayer(PlayerID).ActionPoints += ActionPointsChange;
			BattleArena.Instance.UpdateRequired = true;
			this.Forward();
		}
	}
}
