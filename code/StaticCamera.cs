using Sandbox;
using System;

namespace comfortcockroach
{
	public partial class StaticCamera : Camera
	{
		public override void Activated()
		{
			if (Local.Pawn is Player player)
			{
				Position = player.Position;
				Rotation = player.Rotation;
			}

			base.Activated();
		}

		public override void Update()
		{
			if (Local.Pawn is Player player)
			{
				FieldOfView = 65f;
				Position = Position.LerpTo(100f,0f);
				Rotation = player.Rotation;
			}

			Viewer = null;
		}
	}
}
