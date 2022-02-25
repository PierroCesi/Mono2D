using System;
using La2Dcbien.Graphics;

namespace D.Model.Entity.HeroAnimation
{
	public class ASword: MAnimation
	{
		private const int SPRITE_SIZE_SWORD_X = 40;
		private const int SPRITE_SIZE_SWORD_Y = 61;
		private int[] SPRITE_POSITIONS_SWORD_X = new int[] { 5, 55, 106, 151 };
		private const int SPRITE_POSITION_SWORD_Y = 360;

		public ASword(MHero hero):base(hero)
		{
			this.spriteSizeX = SPRITE_SIZE_SWORD_X;
			this.spriteSizeY = SPRITE_SIZE_SWORD_Y;
			this.spritePositionsX = SPRITE_POSITIONS_SWORD_X;
			this.spritePositionY = SPRITE_POSITION_SWORD_Y;

			foreach(int spritePositionX in spritePositionsX)
            {
				this.Sprites.Add(new Sprite(hero.SpriteSheet, spritePositionX, this.spritePositionY, this.spriteSizeX, this.spriteSizeY));
			}
		}
	}
}

