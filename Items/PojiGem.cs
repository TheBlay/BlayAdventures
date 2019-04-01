using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items
{
    public class PojiGem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Poji Gem");
            Tooltip.SetDefault("The great, the unique, the legendary..." +
                "\nthe most beautiful cross-over content!" +
                "THE ALL-MIGHTY POJI JEWEL!");
        }

        public override void SetDefaults()
        {
            item.rare = -12;
            item.value = 10000;
            item.consumable = false;
            item.material = true;
            item.maxStack = 99;
        }

        //Drop 13.33% HM Caverns

    }
}
