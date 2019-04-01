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
    public class Box : ModItem
    {
        public override string Texture { get { return "Terraria/Item_" + ItemID.Skull; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Box");
            Tooltip.SetDefault("Right Click:\n" +
                "Changes between expert and normal mode.\n" +
                "Left Click:\n" +
                "Changes between day and night.");
        }

        public override void SetDefaults()
        {
            item.color = Color.Crimson;
            item.rare = -12;
            item.useStyle = 4;
            item.useTime = 19;
            item.useAnimation = 19;
            item.consumable = false;
            
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            Main.NewText("You are in " +
                (Main.expertMode ? "Expert" : "Normal") + 
                " Mode."
                );
        }

        public override bool UseItem(Player player)
        {
            if(player.altFunctionUse == 2)
            {
                if (!Main.expertMode)
                {
                    Main.expertMode = true;
                    Main.NewText("You are now in EXPERT MODE");
                }
                else {
                    Main.expertMode = false;
                    Main.NewText("You are now in NORMAL MODE");
                }

            } else
            {
                if (Main.dayTime)
                {
                    Main.dayTime = false;
                    Main.NewText("It is now NIGHT");
                    
                }
                else
                {
                    Main.dayTime = true;
                    Main.NewText("It is now DAY");
                }
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
