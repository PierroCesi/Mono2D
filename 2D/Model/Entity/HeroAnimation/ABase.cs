using System;
using La2Dcbien.Graphics;

namespace D.Model.Entity.HeroAnimation
{
	public class ABase: MAnimation
	{
		protected int SPRITE_SIZE_BASE_X = 21;
		protected int SPRITE_SIZE_BASE_Y = 44;
		public int[] SPRITE_POSITIONS_BASE_X = new int[] { 3, 27, 51, 77 };
		private int SPRITE_POSITION_BASE_Y = 4;

		public ABase(MHero hero):base(hero)
		{
			this.spriteSizeX = SPRITE_SIZE_BASE_X;
			this.spriteSizeY = SPRITE_SIZE_BASE_Y;
			this.spritePositionsX = SPRITE_POSITIONS_BASE_X;
			this.spritePositionY = SPRITE_POSITION_BASE_Y;

			foreach (int spritePositionX in spritePositionsX)
			{
				this.Sprites.Add(new Sprite(hero.SpriteSheet, spritePositionX, this.spritePositionY, this.spriteSizeX, this.spriteSizeY));
			}
		}
	}
}

