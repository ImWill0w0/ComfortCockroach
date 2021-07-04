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
				Pos = player.Position;
				Rot = player.Rotation;
			}

			base.Activated();
		}

		public override void Update()
		{
			if (Local.Pawn is Player player)
			{
				FieldOfView = 65f;
				Pos = Pos.LerpTo(100f,0f);
				Rot = player.Rotation;
			}

			Viewer = null;
		}
	}
}
