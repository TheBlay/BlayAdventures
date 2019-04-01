using Microsoft.Xna.Framework;
using System;
using Terraria.ModLoader;

namespace BlayAdventures
{
	class BlayAdventures : Mod
	{
        private static bool lab1 = false;
        public static void SetLab1(bool state)
        {
            lab1 = state;
        }

        public static bool GetLab1()
        {
            return lab1;
        }

		public BlayAdventures()
		{
            
		}
	}
}
