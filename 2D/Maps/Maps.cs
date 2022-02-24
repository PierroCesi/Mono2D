using System;
using System.Collections.Generic;
using D.Model;
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace D.Maps
{
	public class Maps
	{
		private Texture2D SpriteBatch;
		private const string MAP_PATH = @"../../../Content/maps.txt"; //todo pas la bonne manière de récup
		private Dictionary<char, Func<Vector2, MBlock>> Mapping = new Dictionary<char, Func<Vector2, MBlock>>();

		public Maps(Texture2D spriteBatch)
		{
			this.SpriteBatch = spriteBatch;
			Mapping.Add('*', new Func<Vector2, MBlock>(InstanceCobble));
			Mapping.Add('+', new Func<Vector2, MBlock>(InstanceHero));
			
		}


		public List<MBlock> readMaps()
        {
			List<MBlock> map = new List<MBlock>();

			int column = 0;
			int row = 0;
			string[] lines = System.IO.File.ReadAllLines(MAP_PATH);
			Vector2 position;
			foreach (string line in lines)
			{
				foreach(char character in line)
                {
                    Console.WriteLine("caracatere : "+ character+" - num : "+column+" - ligne : "+row);
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
            Console.WriteLine("hello negro");
			return new MCobble(SpriteBatch, position);
        }

		private MCobble InstanceDirt(Vector2 position)
		{
			Console.WriteLine("hello negresse");
			return null;
		}

		private MHero InstanceHero(Vector2 position)
		{
			return new MHero(SpriteBatch, position);
		}
		
	}
}

