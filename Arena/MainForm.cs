﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arena.Game;

namespace Arena
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		BattleArena Arena = null;

		private void hostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HostSettings hs = new HostSettings();
			if (hs.ShowDialog() == DialogResult.OK) {
				Arena = new BattleArena();
				Arena.OnUpdate += Refresh;

				Arena.Self.Name = "Stranger";
				Arena.Self.Ready = false;

				Arena.ListenForPlayers();
			}

			Refresh();
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConnectSettings cs = new ConnectSettings();
			if (cs.ShowDialog() == DialogResult.OK) {
				Arena = new BattleArena();
				Arena.OnUpdate += Refresh;

				Arena.Self.Name = "Wanderer";
				Arena.Self.Ready = false;

				Arena.JoinGame(cs.IPAddress, cs.Port);
			}

			Refresh();
		}

		public override void Refresh()
		{
			if (this.InvokeRequired) {
				this.Invoke((MethodInvoker)delegate() { Refresh(); });
				return;
			}
			uiGameArea.Arena = Arena;
			uiGameArea.Refresh();

			base.Refresh();
		}
	}
}
