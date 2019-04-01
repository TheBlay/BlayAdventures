using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items
{
    public class FearVial : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fear Vial");
            Tooltip.SetDefault("\'Contains a frightening, evil essence\'");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 30;
            item.material = true;
            item.maxStack = 99;
            item.value = 8790;
            item.rare = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(ItemID.SoulofFright, 2);
            a.AddIngredient(ItemID.SoulofNight, 2);
            a.AddIngredient(ItemID.BloodWater);
            a.SetResult(this);
            a.AddTile(TileID.ImbuingStation);
            a.AddRecipe();
        }
    }
}
