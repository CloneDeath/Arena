using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arena.Game
{
	public class Dragon
	{
		int _health;
		public int Health
		{
			get
			{
				return _health;
			}
			set
			{
				_health = (value < 0) ? 0 : value;
			}
		}

		public double ActionPoints;

		public int MaxHealth;

		public void SendUpdate()
		{
			new Network.EnemyUpdateMessage(this).Send();
		}
	}
}
