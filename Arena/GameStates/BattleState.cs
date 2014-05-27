using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
	}
}
