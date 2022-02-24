using System;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace D.Model
{
	public class MBlock
	{
		public const int SPRITE_SIZE = 50;
		protected int SPRITE_X;
		protected int SPRITE_Y;

		public Sprite Sprite;
		protected Texture2D SpriteSheet;
		public Vector2 PositionCoo; //0, 50
		public Vector2 PositionTab; //0, 1

		public bool doBlock;
		public bool doGravity = true;

        public MBlock(Texture2D spriteSheet, Vector2 position)
		{
			this.PositionTab = position;
			this.PositionCoo.X = this.PositionTab.X * SPRITE_SIZE;
			this.PositionCoo.Y = this.PositionTab.Y * SPRITE_SIZE;
		}

		public void Draw(SpriteBatch spriteBatch)
        {
			this.Sprite.DrawCoo(spriteBatch, this.PositionCoo);
        }

	}
}

