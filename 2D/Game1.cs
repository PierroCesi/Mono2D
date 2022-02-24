using System.Collections.Generic;
using D.Maps;
using D.Model;
using D.Physics;
using D.Utils;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2D
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _spriteSheetTexture;
        private List<MBlock> blockMap = new List<MBlock>();
        private MHero Hero;

        private Utils Utils = new Utils(); //todo singletone
        private Physics physics = new Physics(); //todo singletone

        public const int W_WIDTH = 1000;
        public const int W_HEIGHT = 600;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            _graphics.PreferredBackBufferHeight = W_HEIGHT;
            _graphics.PreferredBackBufferWidth = W_WIDTH;
            _graphics.ApplyChanges();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _spriteSheetTexture = Content.Load<Texture2D>("sprite");

            Maps maps = new Maps(_spriteSheetTexture);
            blockMap = maps.readMaps();

            //Hero = Utils.getObjectBytype(blockMap, typeof(MHero));
            Hero = (MHero)Utils.getObjectBytype(blockMap, typeof(MHero));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Z))
            {
                Hero.PositionCoo.Y = Hero.PositionCoo.Y - 10;
            } else if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Hero.PositionCoo.Y = Hero.PositionCoo.Y + 10;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Q))
            {
                Hero.PositionCoo.X = Hero.PositionCoo.X - 10;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Hero.PositionCoo.X = Hero.PositionCoo.X + 10;
            }

            if (Hero.doGravity)
            {
                physics.ApplyGravity(Hero);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);            

            _spriteBatch.Begin();

            foreach(MBlock block in blockMap)
            {
                block.Draw(_spriteBatch);
            }

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
