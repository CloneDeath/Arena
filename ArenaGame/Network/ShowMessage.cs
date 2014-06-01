using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network
{
	class ShowMessage : Message
	{
		string Message;

		public ShowMessage(string msg)
		{
			this.Message = msg;
		}

		public ShowMessage() { }

		protected override void ExecuteMessage()
		{
			BattleArena.Instance.ShowMessage(Message);
			this.Forward();
		}
	}
}
