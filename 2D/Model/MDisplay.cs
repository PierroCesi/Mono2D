using System;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace D.Model
{
	public class MDisplay
	{
		protected int SPRITE_X;
		protected int SPRITE_Y;

		public Vector2 PositionCoo; //0, 50
		public Vector2 PositionTab; //0, 1

		public Sprite Sprite;

		public MDisplay(Texture2D spriteSheet, Vector2 position)
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			this.Sprite.DrawCoo(spriteBatch, this.PositionCoo);
		}
	}
}

