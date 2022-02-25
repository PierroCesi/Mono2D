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

		public static MDisplay getObjectBytype(List<MDisplay> list, Type typeWanted)
        {

			foreach(MDisplay objects in list){
				if(objects.GetType() == typeWanted)
                {
					return objects;
                }
            }
			return null;
        }

	}
}

