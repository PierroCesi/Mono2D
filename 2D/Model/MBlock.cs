using System;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace D.Model
{
	public class MBlock:MDisplay
	{
		public const int SPRITE_SIZE = 50;

        public MBlock(Texture2D spriteSheet, Vector2 position):base(spriteSheet, position)
		{
			this.PositionTab = position;
			this.PositionCoo.X = this.PositionTab.X * SPRITE_SIZE;
			this.PositionCoo.Y = this.PositionTab.Y * SPRITE_SIZE;
		}
	}
}

