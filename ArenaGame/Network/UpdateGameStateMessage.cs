using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network
{
	class UpdateGameStateMessage : Message
	{
		BattleArena.GameState CurrentState;

		public UpdateGameStateMessage(BattleArena.GameState state)
		{
			CurrentState = state;
		}

		public UpdateGameStateMessage() { }

		protected override void ExecuteMessage()
		{
			BattleArena.Instance.CurrentState = this.CurrentState;
			BattleArena.Instance.UpdateRequired = true;
			this.Forward();
		}
	}
}
