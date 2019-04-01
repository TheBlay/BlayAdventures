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
    public class DevilsGold : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Devil's Gold");
            Tooltip.SetDefault("\'Every sin have a price\'\nSummons lots of golden coins!");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 60;
            item.height = 60;
            item.value = 100000;
            item.mana = 60;
            item.shootSpeed = 2f;
            item.rare = 8;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.shoot = 518;
            item.reuseDelay = 25;
            item.UseSound = new Terraria.Audio.LegacySoundStyle(SoundID.Coins, 0);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.AddBuff(BuffID.ManaSickness, 300);

            if (Main.rand.NextFloat() < .4200f) player.AddBuff((Main.hardMode ? BuffID.CursedInferno : BuffID.OnFire), 275);
            if (Main.rand.NextFloat() < .2730f) { player.AddBuff(BuffID.Cursed, 250); player.AddBuff(BuffID.WitheredArmor, 350); }
            if (Main.rand.NextFloat() < .740f) {
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.Wraith);
                NPC.SpawnOnPlayer(player.whoAmI, NPCID.Wraith);
                if(Main.rand.NextFloat() < .3000f) NPC.SpawnOnPlayer(player.whoAmI, NPCID.Wraith);
            }
            return true;
        }

        public override bool UseItem(Player player)
        {
           
            return base.UseItem(player);
        }

        
        

    }
}
