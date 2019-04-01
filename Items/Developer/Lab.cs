using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BlayAdventures.Items
{
    public class Lab : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lab Switch");
            Tooltip.SetDefault("Can change the state of Lab." +
                "\nLeft Click switches the bool." +
                "\nRight Click shows the current state.");
        }

        public override string Texture { get { return "Terraria/Item_" + ItemID.Bell; } }

        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override void SetDefaults()
        {
            item.useStyle = 4;
            item.useTime = 19;
            item.useAnimation = 19;
            item.rare = -12;
            item.maxStack = 1;
            item.consumable = false;
            item.color = Color.HotPink;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool UseItem(Player player)
        {
            if(player.altFunctionUse == 2)
            {
                Main.NewText("Status atual: " + BlayAdventures.GetLab1());
                
            } else
            {
                BlayAdventures.SetLab1(!BlayAdventures.GetLab1());
            }

            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe a = new ModRecipe(mod);
            a.SetResult(this);
            a.AddRecipe();
        }
    }
}
