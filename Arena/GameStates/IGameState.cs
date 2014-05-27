using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arena.Game;

namespace Arena.GameStates
{
	interface IGameState
	{
		BattleArena Arena { get; set; }
		UserControl GetUI();
		void Refresh();
	}
}
