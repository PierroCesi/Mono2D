using System;
using System.Collections.Generic;
using D.Model;

namespace D.Physics
{
	public class Behavior
	{
		public const int SHIFT = 20;

		public Behavior()
		{
		}

		public void ApplyGravity(MEntity entity)
        {
			entity.PositionCoo.Y = entity.PositionCoo.Y + 5;
            //Console.WriteLine("oui");
		}
		/*
		public bool canMove(List<MBlock> map, MHero hero)
        {
			foreach(MBlock block in map)
            {

			}
		}*/
	}
}

