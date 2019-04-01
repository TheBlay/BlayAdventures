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
    public class EnchantedGlobe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Globe");
            Tooltip.SetDefault("The name says it all!");
        }

        public override void SetDefaults()
        {
            item.rare = 8;
            item.value = 20000;
            item.material = true;
            item.consumable = false;
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(ItemID.HallowedBar, 6);
            a.AddIngredient(ItemID.Ectoplasm, 5);
            a.AddIngredient(ItemID.PixieDust, 15);
            a.SetResult(this);
            a.AddTile(TileID.CrystalBall);
            a.AddRecipe();
        }
    }
}
