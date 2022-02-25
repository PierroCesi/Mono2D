using System;
using D.Model.Entity.HeroAnimation;
using La2Dcbien.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace D.Model
{
	public class MDisplay
	{
		public int SPRITE_X;
		public int SPRITE_Y;

		public Vector2 PositionCoo; //0, 50
		public Vector2 PositionTab; //0, 1

		public Sprite Sprite;
		public MAnimation AnimationModel;

		public MDisplay(Texture2D spriteSheet, Vector2 position)
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			this.Sprite.DrawCoo(spriteBatch, this.PositionCoo);
		}

		public void Animate()
        {
			int indexCurrentSprite = this.AnimationModel.Sprites.IndexOf(this.Sprite);
			int sizeSPrite = this.AnimationModel.Sprites.Count;

			if (indexCurrentSprite == sizeSPrite-1)
            {
				this.Sprite = this.AnimationModel.Sprites[0];
			}
			else
            {
				this.Sprite = this.AnimationModel.Sprites[indexCurrentSprite + 1];

			}

		}
		
	}
}

