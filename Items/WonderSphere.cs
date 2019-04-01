using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace BlayAdventures.Items
{
    public class WonderSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wonder Sphere");
            Tooltip.SetDefault("\'We could call it \'Galaxy in a Globe\'!\'");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 6));
        }

        

        public override void SetDefaults()
        {
            
            item.width = 15;
            item.height = 15;
            item.rare = 9;
            item.value = 500000;
            item.material = true;
            item.consumable = false;
            item.maxStack = 99;
            //item.noUseGraphic = true;
        }

        

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.AddIngredient(mod.ItemType("EnchantedGlobe"));
            a.AddIngredient(ItemID.FragmentSolar, 8);
            a.AddIngredient(ItemID.FragmentNebula, 8);
            a.AddIngredient(ItemID.FragmentVortex, 8);
            a.AddIngredient(ItemID.FragmentStardust, 8);
            a.AddIngredient(ItemID.SoulofNight, 10);
            a.AddIngredient(ItemID.SoulofLight, 10);
            a.AddIngredient(ItemID.SoulofFright, 10);
            a.AddIngredient(ItemID.SoulofMight, 10);
            a.AddIngredient(ItemID.SoulofSight, 10);
            a.AddIngredient(mod.ItemType("OrnovBar"), 5);
            a.AddTile(TileID.LunarCraftingStation);
            a.SetResult(this);
            a.AddRecipe();
        }
    }
}
