using System;
using System.Collections.Generic;
using D.Model;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using D.Model.Entity.HeroAnimation;

namespace D.Maps
{
	public struct Struct
    {
		public Func<Vector2, Texture2D, MDisplay> func;
		public Texture2D texture;
	}

	public class Maps
	{
		private const string MAP_PATH = @"../../../Content/maps.txt"; //todo pas la bonne manière de récup
		//private Dictionary<char, Func<Struct, MDisplay>> Mapping = new Dictionary<char, Func<Struct, MDisplay>>();
		private Dictionary<char, Func<Vector2, MDisplay>> Mapping = new Dictionary<char, Func<Vector2, MDisplay>>();

		private Texture2D _spriteMap;
		private Texture2D _spriteSteve;
		private Texture2D _spriteAmogus;

		public Maps(ContentManager content)
		{
			_spriteMap = content.Load<Texture2D>("sprite");
			_spriteSteve = content.Load<Texture2D>("steve");
			_spriteAmogus = content.Load<Texture2D>("amogus");

			Mapping.Add('*', new Func<Vector2, MBlock>(InstanceCobble));
			Mapping.Add('+', new Func<Vector2, MEntity>(InstanceHero));



			/*
			 * 
			 			_spriteMap = content.Load<Texture2D>("sprite");
			_spriteSteve = content.Load<Texture2D>("steve");

			Struct cobbleStruct = new Struct();
			cobbleStruct.func = new Func<Vector2, Texture2D, MBlock>(InstanceCobble);
			cobbleStruct.texture = _spriteMap;

			Struct heroStruct = new Struct();
			heroStruct.func = new Func<Vector2, Texture2D, MHero>(InstanceHero);
			heroStruct.texture = _spriteSteve;

			this.SpriteBatch = spriteBatch;

			Mapping.Add('*', new Func<Struct, MDisplay>(InstanceCobble));
			//Mapping.Add('*', new Func<Vector2, Texture2D, MBlock>(InstanceCobble));
			//Mapping.Add('+', new Func<Vector2, Texture2D, MHero>(InstanceHero));
			*/

		}


		public List<MDisplay> readMaps()
        {
			List<MDisplay> map = new List<MDisplay>();

			int column = 0;
			int row = 0;
			string[] lines = File.ReadAllLines(MAP_PATH);
			Vector2 position;
			foreach (string line in lines)
			{
				foreach(char character in line)
                {
					if (Mapping.ContainsKey(character))
					{
						position.X = column;
						position.Y = row;
						map.Add(Mapping[character](position));
					}
					column++;
				}
				column = 0;
				row++;
			}
			return map;
        }

		private MCobble InstanceCobble(Vector2 position)
        {
			return new MCobble(_spriteMap, position);
        }

		private MHero InstanceHero(Vector2 position)
		{
			return new MHero(_spriteSteve, position);
		}
		
	}
}

