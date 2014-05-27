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
	public partial class LobbyState : UserControl, IGameState
	{
		public LobbyState()
		{
			InitializeComponent();
		}

		public BattleArena Arena { get; set; }

		public UserControl GetUI()
		{
			return this;
		}

		public override void Refresh()
		{
			RefreshList();

			if (Arena == null) {
				btnReady.Enabled = false;
				gbClasses.Enabled = false;
				tbPlayerName.Enabled = false;
				btnStart.Enabled = false;

			} else {
				btnReady.Enabled = true;
				btnReady.Text = Arena.Self.Ready ? "Unready" : "Ready";

				gbClasses.Enabled = true;
				rbClassKnight.Checked = Arena.Self.Class == PlayerClass.Knight;
				rbClassHealer.Checked = Arena.Self.Class == PlayerClass.Healer;

				tbPlayerName.Enabled = true;
				tbPlayerName.Text = Arena.Self.Name;

				if (Arena.Host == Arena.Self) {
					btnStart.Enabled = true;
				}
			}

			base.Refresh();
		}

		private void RefreshList()
		{
			lbPlayers.Items.Clear();

			if (Arena != null) {
				foreach (Player p in Arena.Players) {
					lbPlayers.Items.Add(p);
				}
			}
		}

		private void btnReady_Click(object sender, EventArgs e)
		{
			Arena.Self.Ready = !Arena.Self.Ready;
			Arena.Self.SendUpdate();

			this.Refresh();
		}

		private void rbClassKnight_CheckedChanged(object sender, EventArgs e)
		{
			if (rbClassKnight.Checked) {
				Arena.Self.Class = PlayerClass.Knight;
				Arena.Self.SendUpdate();

				this.Refresh();
			}
		}

		private void rbClassHealer_CheckedChanged(object sender, EventArgs e)
		{
			if (rbClassHealer.Checked) {
				Arena.Self.Class = PlayerClass.Healer;
				Arena.Self.SendUpdate();

				this.Refresh();
			}
		}

		private void tbPlayerName_TextChanged(object sender, EventArgs e)
		{
			Arena.Self.Name = tbPlayerName.Text;
			Arena.Self.SendUpdate();

			RefreshList();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Arena.BeginBattle();
		}
	}
}
