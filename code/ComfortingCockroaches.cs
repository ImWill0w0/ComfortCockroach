
using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Threading.Tasks;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace comfortcockroach
{
	[Library("comfortcockroach", Title = "comfortcockroach")]
	public partial class comfortcockroach : Sandbox.Game
	{
		public comfortcockroach()
		{
			if ( IsServer )
			{
				ConsoleSystem.Run("playsound cockroachmusic");
			}

			if ( IsClient )
			{
				ConsoleSystem.Run("playsound cockroachmusic");
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
