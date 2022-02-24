using System;
using D.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace La2Dcbien.Graphics
{
    public class Sprite
    {
        public Texture2D Texture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; } = Color.White;

        public Sprite(Texture2D texture, int x, int y, int width, int height)
        {
            this.Texture = texture;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public void DrawCoo(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(Texture, position, new Rectangle(this.X, this.Y, this.Width, this.Height), Color);
        }

        public void DrawPos(SpriteBatch spriteBatch, Vector2 position)
        {
            position.X = position.X * MBlock.SPRITE_SIZE;
            position.Y = position.Y * MBlock.SPRITE_SIZE;
            spriteBatch.Draw(Texture, position, new Rectangle(this.X, this.Y, this.Width, this.Height), Color);
        }

    }

}