using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Arena.Game.Network
{
	class EnemyUpdateMessage : Message
	{
		int MaxHP;
		int HP;

		public EnemyUpdateMessage(Dragon enemy)
		{
			MaxHP = enemy.MaxHealth;
			HP = enemy.Health;
		}

		public EnemyUpdateMessage() { }

		protected override void ExecuteMessage()
		{
			if (BattleArena.Instance.Enemy == null) {
				BattleArena.Instance.Enemy = new Dragon();
			}
			BattleArena.Instance.Enemy.MaxHealth = this.MaxHP;
			BattleArena.Instance.Enemy.Health = this.HP;
			BattleArena.Instance.UpdateRequired = true;
			this.Forward();
		}
	}
}
