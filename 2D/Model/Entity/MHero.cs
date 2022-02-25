using D.Model.Entity.HeroAnimation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace D.Model
{
	public class MHero:MEntity
	{
		public Vector2 SpritePosition = new Vector2(0, 0);
		public Texture2D SpriteSheet;

		public MHero(Texture2D spriteSheet, Vector2 position):base(spriteSheet, position)
		{
			this.SpriteSheet = spriteSheet;
			this.AnimationModel = new ASword(this);
			this.Sprite = AnimationModel.Sprites[0];

			this.PositionTab = position;
			this.PositionCoo.X = this.PositionTab.X * AnimationModel.spriteSizeX;
			this.PositionCoo.Y = this.PositionTab.Y * AnimationModel.spriteSizeY;

			//this.SPRITE_X = (int)SpritePosition.X * AnimationModel.spriteSizeX + AnimationModel.spritePositionsX[0];
			//this.SPRITE_Y = (int)SpritePosition.Y * AnimationModel.spriteSizeY + AnimationModel.spritePositionY;

			//this.Sprite = new Sprite(spriteSheet, this.SPRITE_X, this.SPRITE_Y, AnimationModel.spriteSizeX, AnimationModel.spriteSizeY);
		}
	}
}

