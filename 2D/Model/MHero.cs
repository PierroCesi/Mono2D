using System;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace D.Model
{
	public class MHero:MEntity
	{
		public Vector2 SPRITE_POSITION = new Vector2(0, 0);

		public MHero(Texture2D spriteSheet, Vector2 position):base(spriteSheet, position)
		{
			this.SPRITE_X = (int)SPRITE_POSITION.X * SPRITE_SIZE_X + 4;
			this.SPRITE_Y = (int)SPRITE_POSITION.Y * SPRITE_SIZE_Y + 5;
			this.Sprite = new Sprite(spriteSheet, this.SPRITE_X, this.SPRITE_Y, SPRITE_SIZE_X, SPRITE_SIZE_Y);

		}

	}
}

