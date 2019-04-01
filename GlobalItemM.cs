using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlayAdventures 
{
    public class GlobalItemM : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (BlayAdventures.GetLab1())
            {
                if (item.mana > 2)
                {
                    item.mana = (int)item.mana/2;
                }
            }
        }
    }
}
