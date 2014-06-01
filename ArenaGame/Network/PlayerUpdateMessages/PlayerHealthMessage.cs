using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network.PlayerUpdateMessages
{
	class PlayerHealthMessage : Message
	{
		public int HealthChange;
		public int PlayerID;

		protected override void ExecuteMessage()
		{
			BattleArena.Instance.GetPlayer(PlayerID).Health += HealthChange;
			BattleArena.Instance.UpdateRequired = true;
			this.Forward();
		}
	}
}
