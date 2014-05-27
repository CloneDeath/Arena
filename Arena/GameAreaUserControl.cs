using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arena.Game;
using Arena.GameStates;

namespace Arena
{
	public partial class GameAreaUserControl : UserControl
	{
		public GameAreaUserControl()
		{
			InitializeComponent();
			Refresh();
		}

		private void SetState(IGameState NewState)
		{
			this.Controls.Clear();
			this.Controls.Add(NewState.GetUI());
			NewState.GetUI().Dock = DockStyle.Fill;

			CurrentState = NewState;

			Refresh();
		}

		public BattleArena Arena { get; set; }
		IGameState CurrentState = null;

		public override void Refresh()
		{
			if (Arena == null) {
				CurrentState = null;
				this.Controls.Clear();
				return;
			}

			switch (Arena.CurrentState) {
				case BattleArena.GameState.Lobby:
					if (CurrentState is LobbyState) {
						CurrentState.Arena = this.Arena;
						CurrentState.Refresh();
					} else {
						SetState(new LobbyState());
					}
					break;
				case BattleArena.GameState.Arena:
					if (CurrentState is BattleState) {
						CurrentState.Arena = this.Arena;
						CurrentState.Refresh();
					} else {
						SetState(new BattleState());
					}
					break;
			}
			
		}
	}
}
