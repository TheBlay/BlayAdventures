using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items
{
    public class OrnovBar : ModItem
    {
       public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ornov Bar");
            Tooltip.SetDefault("\'Otherwordly sturdy bless!\'");
        }

        public override void SetDefaults()
        {
            item.material = true;
            item.maxStack = 999;
            item.value = 25000;
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(ItemID.HallowedBar, 2);
            a.AddIngredient(ItemID.MeteoriteBar, 2);
            a.AddIngredient(ItemID.LunarBar, 1);
            a.AddIngredient(ItemID.BeetleHusk, 4);
            a.AddTile(TileID.AdamantiteForge);
            a.SetResult(this, 2);
            a.AddRecipe();
        }
    }
}
