using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;
using Lidgren.Messages;
using System.Timers;

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

		public BattleArena()
		{
			Self = new Player();
			Players.Add(Self);

			timer = new Timer(1000.0 / 30); //30 fps
			timer.AutoReset = false;
			timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
			timer.Start();

			Instance = this;
		}

		Random rand = new Random();
		void timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			Message.Update();

			if (Host == Self) {
				Enemy.ActionPoints += 1.0 / 30.0;

				if (Enemy.ActionPoints >= 4) {
					Enemy.ActionPoints -= 3;

					int UnluckySoul = rand.Next(Players.Count);
					Players[UnluckySoul].Health -= 3;
					Players[UnluckySoul].SendUpdate();
					this.UpdateRequired = true;
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
			new Network.EnemyUpdateMessage(Enemy).Send();
			UpdateRequired = true;
		}
	}
}
