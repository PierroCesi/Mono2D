using System;
using System.Collections.Generic;
using D.Model;

namespace D.Utils
{
	public class Utils
	{
		public Utils()
		{
		}

		public Object getObjectBytype(List<MBlock> list, Type typeWanted)
        {

			foreach(Object objects in list){
				if(objects.GetType() == typeWanted)
                {
                    Console.WriteLine("ONIiiiiiiiiii");
					return objects;
                }
            }
			return null;
        }

	}
}

