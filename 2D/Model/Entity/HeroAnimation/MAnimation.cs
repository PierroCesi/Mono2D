using System;
using System.Collections.Generic;
using La2Dcbien.Graphics;

namespace D.Model.Entity.HeroAnimation
{
	public class MAnimation
	{
		public int spriteSizeX;
		public int spriteSizeY;
		public int[] spritePositionsX; //je vais surement devoir l'instancier
		public int spritePositionY;

		public List<Sprite> Sprites = new List<Sprite>();

		public MAnimation(MHero hero)
		{
		}
	}
}

