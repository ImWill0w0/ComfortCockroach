
using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Threading.Tasks;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace ComfortCockroach
{
	public partial class ComfortCockroach : Sandbox.Game
	{
		public ComfortCockroach()
		{
			if ( IsServer )
			{
				ConsoleSystem.Run("playsound cockroachmusic");
			}

			if ( IsClient )
			{
			}
		}

		/// <summary>
		/// A client has joined the server. Make them a pawn to play with
		/// </summary>
		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			var player = new MinimalPlayer();
			client.Pawn = player;

			player.Respawn();
		}
	}
}
