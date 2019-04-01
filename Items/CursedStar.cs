using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items
{
    public class CursedStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Star");
            Tooltip.SetDefault("\'A different, damned star.\'");
        }

        public override void SetDefaults()
        {
            item.material = true;
            item.value = 50900;
            item.rare = 3;
            item.maxStack = 99;

        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(ItemID.FallenStar);
            a.AddIngredient(ItemID.SoulofLight, 3);
            a.AddIngredient(ItemID.Ichor, 2);
            a.AddIngredient(ItemID.CursedFlame, 2);
            a.AddTile(TileID.CrystalBall);
            a.SetResult(this);
            a.AddRecipe();
        }
    }
}
