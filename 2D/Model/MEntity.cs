using System;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace D.Model
{
	public class MEntity:MDisplay
	{
		public const int SPRITE_SIZE_X = 21;
		public const int SPRITE_SIZE_Y = 44;

		public MEntity(Texture2D spriteSheet, Vector2 position):base(spriteSheet, position)
		{
			this.PositionTab = position;
			this.PositionCoo.X = this.PositionTab.X * SPRITE_SIZE_X;
			this.PositionCoo.Y = this.PositionTab.Y * SPRITE_SIZE_Y;
		}
	}
}

