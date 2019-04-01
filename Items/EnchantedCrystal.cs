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
    public class EnchantedCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Crystal");
            Tooltip.SetDefault("A great arcane quartz filled with power!" +
                "\n\'Ancients used it to make enchanted weapons and equips\'");
        }

        public override void SetDefaults()
        {
            item.rare = 4;
            item.value = 19500;
            item.consumable = false;
            item.material = true;
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(mod.ItemType("PojiGem"));
            a.AddIngredient(mod.ItemType("EnchantedShard"), 6);
            a.AddIngredient(ItemID.ManaCrystal);
            a.AddIngredient(ItemID.CrystalShard, 5);
            a.AddTile(TileID.CrystalBall);
            a.SetResult(this);
            a.AddRecipe();
        }
    }
}
