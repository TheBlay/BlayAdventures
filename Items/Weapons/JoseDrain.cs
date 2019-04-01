using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items.Weapons
{
    public class JoseDrain : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Drain");
            Tooltip.SetDefault("\'Drains even the existence!\'\nW.I.P");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            //item.CloneDefaults(3006);
            item.useTime = 17;
            item.useAnimation = 17;
            item.value = 60000;
            item.rare = 4;
            
            item.magic = true;
            item.damage = 137;
            item.mana = 9;
            item.width = 32;
            item.height = 30;
            item.color = Color.Purple;

        }

        public override bool CanUseItem(Player player)
        {
            return true;
        }
        /*
        public override bool UseItem(Player player)
        {
            //a.ShootSD(this, player);
            
            return true;
        }
        */

            ///*
        GlobalNPCDrops a = new GlobalNPCDrops();

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {


            //a.ShootSD(this, player);
            ModItem i = new ModItem();
            NPC npc = new NPC();
            if (!npc.friendly && !npc.boss && (npc.lifeMax > 1) && (npc.value > 0f) && npc.WithinRange(npc.position, 200))
            {
                npc.StrikeNPC(i.item.damage, 0f, npc.direction);
                player.HealEffect((int)(i.item.damage * 0.008));
                player.statLife += (int)(i.item.damage * 0.08);
                Dust.NewDust(npc.position, 2, 2, DustID.Electric);

            }

            return true;
        }
        //*/
        public override string Texture { get { return "Terraria/Item_3006"; } }
    }
}
