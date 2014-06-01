using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;
using Lidgren.Messages;
using System.Timers;
using System.Diagnostics;

namespace Arena.Game
{
	public class BattleArena
	{
		public enum GameState
		{
			Lobby,
			Arena
		}

		public GameState CurrentState = GameState.Lobby;

		public static BattleArena Instance
		{
			get;
			private set;
		}

		Timer timer;
		Stopwatch sw = new Stopwatch();

		public BattleArena()
		{
			Self = new Player();
			Players.Add(Self);

			timer = new Timer(1000.0 / 30); //30 fps
			timer.AutoReset = false;
			timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
			sw.Start();
			timer.Start();

			Instance = this;
		}

		Random rand = new Random();
		void timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			double dt = sw.Elapsed.TotalMilliseconds / 1000.0;
			sw.Restart();

			Message.Update();
			
			if (Host == Self) {
				if (this.CurrentState == GameState.Arena) {
					/* Update Enemy Action Points */
					Enemy.ActionPoints += 1.0 * dt;

					if (Enemy.ActionPoints >= 2) {
						Enemy.ActionPoints -= 1;

						int UnluckySoul = rand.Next(Players.Count);
						Players[UnluckySoul].AddHealth(-1);
						this.UpdateRequired = true;
					}

					/* Update each player */
					foreach (Player p in Players) {
						p.Update(dt);
					}
					this.UpdateRequired = true;

					/* Check if dragon is dead */
					if (Enemy.Health <= 0) {
						new Network.ShowMessage("The Dragon has been defeated! Congratulations!").Send();
						CurrentState = GameState.Lobby;
						new Network.UpdateGameStateMessage(GameState.Lobby).Send();
						this.ShowMessage("The Dragon has been defeated! Congratulations!");
						this.UpdateRequired = true;
					}

					/* Check for game over */
					bool GameOver = true;
					for (int i = 0; i < Players.Count; i++) {
						if (Players[i].Health > 0) {
							GameOver = false;
						}
					}
					if (GameOver) {
						new Network.ShowMessage("You have all died, and the dragon has won...\r\nYou got him down to " + this.Enemy.Health + "hp.").Send();
						CurrentState = GameState.Lobby;
						new Network.UpdateGameStateMessage(GameState.Lobby).Send();
						this.ShowMessage("You have all died, and the dragon has won...\r\nYou got him down to " + this.Enemy.Health + "hp.");
						this.UpdateRequired = true;
					}
				}
			}

			if (UpdateRequired) {
				UpdateRequired = false;
				if (OnUpdate != null) {
					OnUpdate();
				}
			}

			timer.Start();
		}

		public Dragon Enemy;

		public List<Player> Players = new List<Player>();
		public Player Self;
		public Player Host;

		internal bool UpdateRequired = false;

		public void ListenForPlayers()
		{
			NetPeerConfiguration config = new NetPeerConfiguration("Arena");
			config.Port = 45673;
			config.MaximumConnections = 8;

			Self.PlayerID = 0;
			Self.Connection = new NetServer(config);
			Self.Connection.Start();
			Message.RegisterServer(Self.Connection);

			Host = Self;
		}

		public void JoinGame(string ipaddress, int port)
		{
			NetPeerConfiguration config = new NetPeerConfiguration("Arena");
			Self.Connection = new NetClient(config);
			Self.Connection.Start();
			Self.Connection.Connect(ipaddress, port);

			while (((NetClient)Self.Connection).ConnectionStatus != NetConnectionStatus.Connected) {
				System.Threading.Thread.Sleep(100);
				Self.Connection.ReadMessages(new List<NetIncomingMessage>());
			}
			Message.RegisterClient(Self.Connection);

			new Network.PlayerJoining.RequestPlayerSlotMessage().Send();
		}

		public event Action OnUpdate;
		
		public void BeginBattle()
		{
			CurrentState = GameState.Arena;
			new Network.UpdateGameStateMessage(CurrentState).Send();

			Enemy.Health = Enemy.MaxHealth;
			new Network.EnemyUpdateMessage(Enemy).Send();

			foreach (Player p in Players) {
				p.AddHealth(p.MaxHealth);
				p.AddActionPoints(-10);
				p.Ready = false;
				p.SendUpdate();
			}

			UpdateRequired = true;
		}

		public event Action<string> OnShowMessage;
		internal void ShowMessage(string Message)
		{
			if (OnShowMessage != null) {
				OnShowMessage(Message);
			}
		}

		internal Player GetPlayer(int PlayerID)
		{
			foreach (Player player in BattleArena.Instance.Players) {
				if (player.PlayerID == PlayerID) {
					return player;
				}
			}
			return null;
		}
	}
}
