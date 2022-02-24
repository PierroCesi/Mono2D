using System;
using System.Collections.Generic;
using D.Model;

namespace D.Physics
{
	public class Physics
	{
		public const int SHIFT = 20;

		public Physics()
		{
		}

		public void ApplyGravity(MBlock block)
        {
            block.PositionCoo.Y = block.PositionCoo.Y + 5;
            //Console.WriteLine("oui");
		}

		public bool canMove(List<MBlock> map, MHero hero)
        {
			foreach(MBlock block in map)
            {

			}
		}
	}
}

