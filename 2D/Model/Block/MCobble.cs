using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;

namespace D.Model
{
	public class MCobble : MBlock
	{
		public Vector2 SPRITE_POSITION = new Vector2(5, 2);

		public MCobble(Texture2D spriteSheet, Vector2 position) :base(spriteSheet, position)
		{
			this.SPRITE_X = (int)SPRITE_POSITION.X * SPRITE_SIZE + 20;
			this.SPRITE_Y = (int)SPRITE_POSITION.Y * SPRITE_SIZE - 10;
			this.Sprite = new Sprite(spriteSheet, this.SPRITE_X, this.SPRITE_Y, SPRITE_SIZE, SPRITE_SIZE);
		}
	}
}

