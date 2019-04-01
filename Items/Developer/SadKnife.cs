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
    public class SadKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sad Knife");
            Tooltip.SetDefault("Deals damage to player" +
                "\n25 on Left Click"
                + "\n50 on Right Click");
            
        }

        public override string Texture { get { return "Terraria/Item_" + ItemID.PsychoKnife; } }

        public override void SetDefaults()
        {
            item.useStyle = 2;
            item.useTime = 18;
            item.useAnimation = 18;
            item.rare = -12;
            item.autoReuse = false;
            item.consumable = false;
            item.maxStack = 1;
            item.UseSound = new Terraria.Audio.LegacySoundStyle(SoundID.PlayerHit, 0);
            
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {

            return true;
        }
        public override bool UseItem(Player player)
        {

            if (player.altFunctionUse == 2)
            {
                player.Hurt(new Terraria.DataStructures.PlayerDeathReason(), 50, 0);
            }
            else
            {
                player.Hurt(new Terraria.DataStructures.PlayerDeathReason(), 25, 0);
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
