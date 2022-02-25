using System;
using System.Collections.Generic;
using D.Maps;
using D.Model;
using D.Model.Entity.HeroAnimation;
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
        private Texture2D _spriteMap;
        private Texture2D _spriteSteve;

        private Behavior Behavior = new Behavior();
        private Animation Animation = new Animation();
        private List<MDisplay> Map = new List<MDisplay>();
        private MHero Hero;

        //private Utils Utils = new Utils(); //todo singletone
        //private Physics physics = new Physics(); //todo singletone

        public const int W_WIDTH = 1000;
        public const int W_HEIGHT = 600;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this.IsFixedTimeStep = true;//false;
            //this.TargetElapsedTime = TimeSpan.FromSeconds(1d / 5); //60);

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
            List<Texture2D> listTexture = new List<Texture2D>();
            _spriteMap = Content.Load<Texture2D>("sprite");
            _spriteSteve = Content.Load<Texture2D>("steve");

            listTexture.Add(_spriteMap);
            listTexture.Add(_spriteSteve);

            Maps maps = new Maps(this.Content);
            Map = maps.readMaps();

            //Hero = Utils.getObjectBytype(Map, typeof(MHero));
            Hero = (MHero)Utils.getObjectBytype(Map, typeof(MHero));
        }

        int i = 0;
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
            else if (Keyboard.GetState().IsKeyDown(Keys.K))
            {
                Hero.AnimationModel = new ABase(Hero);
                Hero.Sprite = new ABase(Hero).Sprites[0];
            }



            /*foreach(MDisplay block in Map)
            {
                //X1 = X, X2 = X+SIZE
                //Y1 = Y, Y2 = Y+SIZE
                if(Hero.PositionCoo.X >)
                {

                }
            }*/

            //Behavior.ApplyGravity(Hero); marche nikel


            i++;

            if (i == 4)
            {
                i = 0;
            }
            Hero.Animate();
            //Hero.Sprite = Hero.AnimationModel.Sprites[i];
       
            //Animation.Animate(Hero);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);            

            _spriteBatch.Begin();

            foreach(MDisplay block in Map)
            {
                block.Draw(_spriteBatch);
            }
            //Hero.Draw(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}