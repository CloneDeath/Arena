using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arena.Game;

namespace Arena.GameStates
{
	public partial class BattleState : UserControl, IGameState
	{
		public BattleState()
		{
			InitializeComponent();
		}

		public GameAreaUserControl State
		{
			get;
			set;
		}

		public Game.BattleArena Arena
		{
			get;
			set;
		}

		public UserControl GetUI()
		{
			return this;
		}

		public override void Refresh()
		{
			if (Arena.Enemy == null) return;

			this.pbDragonHealth.Maximum = Arena.Enemy.MaxHealth;
			this.pbDragonHealth.Value = Arena.Enemy.Health;
			this.lblDragonHealth.Text = Arena.Enemy.Health + "/" + Arena.Enemy.MaxHealth;


			lbPlayerName.Text = Arena.Self.Name;
			pbPlayerHealth.Maximum = Arena.Self.MaxHealth;
			pbPlayerHealth.Value = Arena.Self.Health;
			lbPlayerHealth.Text = Arena.Self.Health + "/" + Arena.Self.MaxHealth;

			lbPlayers.Items.Clear();
			lbPlayers.DisplayMember = "Display";
			lbPlayers.ValueMember = "Value";
			foreach (Player p in Arena.Players) {
				if (p == Arena.Self) continue;

				var temp_obj = new {
					Display = p.Name + " (" + p.Class + ") - HP:" + p.Health + "/" + p.MaxHealth,
					Value = p,
				};
				lbPlayers.Items.Add(temp_obj);
			}
		}

		private void btnAttack_Click(object sender, EventArgs e)
		{
			Arena.Enemy.Health -= 1;
			Arena.Enemy.SendUpdate();
			this.Refresh();
		}
	}
}
