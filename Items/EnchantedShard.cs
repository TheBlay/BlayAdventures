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
    public class EnchantedShard : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Shard");
            Tooltip.SetDefault("\'A mere fraction of the enchanting power!\'");
        }

        public override void SetDefaults()
        {
            item.rare = 5;
            item.value = 15000;
            item.consumable = false;
            item.material = true;
            item.maxStack = 99;
        }

      //Drop 20% @Dungeon after 1 mech downed
    }
}
