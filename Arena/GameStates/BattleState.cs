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

			int sel_index = lbPlayers.SelectedIndex;
			lbPlayers.DisplayMember = "Display";
			lbPlayers.ValueMember = "Value";

			List<object> playerlist = new List<object>();
			foreach (Player p in Arena.Players) {
				//if (p == Arena.Self) continue;

				var temp_obj = new {
					Display = (p == Arena.Self ? "[Me] " : "" ) + p.Name + " (" + p.Class + ") - HP:" + p.Health + "/" + p.MaxHealth,
					Value = p,
				};
				playerlist.Add(temp_obj);
			}
			lbPlayers.DataSource = playerlist;
			lbPlayers.SelectedIndex = sel_index;

			if (Arena.Self.Health > 0){
				lblActionPoints.Text = Arena.Self.ActionPoints.ToString("N1") + "/10";

				btnAttack.Enabled = CanDoAttack();
				btnFierceAttack.Enabled = CanDoFierceAttack();

				btnHeal.Enabled = CanDoHeal();
				btnRevive.Enabled = CanDoRevive();
			} else {
				lblActionPoints.Text = "0/10";

				btnAttack.Enabled = false;
				btnFierceAttack.Enabled = false;
				btnHeal.Enabled = false;
				btnRevive.Enabled = false;
			}

			btnAttack.Visible = Arena.Self.Class == PlayerClass.Knight;
			lblAttackInfo.Visible = Arena.Self.Class == PlayerClass.Knight;
			btnFierceAttack.Visible = Arena.Self.Class == PlayerClass.Knight;
			lblFierceAttackInfo.Visible = Arena.Self.Class == PlayerClass.Knight;

			btnHeal.Visible = Arena.Self.Class == PlayerClass.Healer;
			lblHealInfo.Visible = Arena.Self.Class == PlayerClass.Healer;
			btnRevive.Visible = Arena.Self.Class == PlayerClass.Healer;
			lblReviveInfo.Visible = Arena.Self.Class == PlayerClass.Healer;
		}

		private bool CanDoRevive()
		{
			return Arena.Self.ActionPoints >= 8 && TargetPlayer != null && TargetPlayer.Health <= 0;
		}

		private bool CanDoHeal()
		{
			return Arena.Self.ActionPoints >= 3 && TargetPlayer != null && TargetPlayer.Health < TargetPlayer.MaxHealth && TargetPlayer.Health > 0;
		}

		private bool CanDoFierceAttack()
		{
			return Arena.Self.ActionPoints >= 5;
		}

		private bool CanDoAttack()
		{
			return Arena.Self.ActionPoints >= 1;
		}

		private void btnAttack_Click(object sender, EventArgs e)
		{
			if (!CanDoAttack()) return;

			Arena.Self.AddActionPoints(-1);

			Arena.Enemy.Health -= 1;
			Arena.Enemy.SendUpdate();
			this.Refresh();
		}

		private void btnHeal_Click(object sender, EventArgs e)
		{
			if (!CanDoHeal()) return;

			Arena.Self.AddActionPoints(-3);

			TargetPlayer.AddHealth(3);
			this.Refresh();
		}

		public Player TargetPlayer { get { return ((Player)lbPlayers.SelectedValue); } }

		private void btnFierceAttack_Click(object sender, EventArgs e)
		{
			if (!CanDoFierceAttack()) return;

			Arena.Self.AddActionPoints(-5);
			Arena.Self.AddHealth(-6);

			Arena.Enemy.Health -= 10;
			Arena.Enemy.SendUpdate();
			this.Refresh();
		}

		private void btnRevive_Click(object sender, EventArgs e)
		{
			if (!CanDoRevive()) return;

			Arena.Self.AddActionPoints(-9);

			TargetPlayer.AddHealth(3);
			this.Refresh();
		}
	}
}
