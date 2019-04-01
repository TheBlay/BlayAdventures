using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items
{
    public class TerrorFlask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terror Flask");
            Tooltip.SetDefault("\'A flask with pure terror!\'");
        }

        public override void SetDefaults()
        {
            item.material = true;
            item.maxStack = 99;
            item.value = 10110;
            item.rare = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(mod, "FearVial", 1);
            a.AddIngredient(ItemID.BlackFairyDust);
            a.AddIngredient(ItemID.VilePowder);
            a.AddTile(TileID.ImbuingStation);
            a.SetResult(this);
            a.AddRecipe();
            
        }
    }
}
