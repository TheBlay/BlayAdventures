using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items
{
    public class TraevBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Traev Bar");
            Tooltip.SetDefault("A doomed bar filled with terrific heat");
        }

        public override void SetDefaults()
        {
            item.material = true;
            item.maxStack = 999;
            item.value = 22000;
            item.rare = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(mod, "TerrorFlask");
            a.AddIngredient(ItemID.HellstoneBar, 10);
            a.AddIngredient(ItemID.LivingDemonFireBlock, 50);
            a.AddIngredient(ItemID.CrystalShard, 5);
            a.AddTile(TileID.DemonAltar);
            a.SetResult(this, 10);
            a.AddRecipe();
        }

    }
}
