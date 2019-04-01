using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace BlayAdventures
{
    public class GlobalNPCDrops : GlobalNPC         //Leia também como GlobalNPCM
    {
        
        public override void SetDefaults(NPC npc)
        {
            if (BlayAdventures.GetLab1())
            {
                if (!npc.friendly && !npc.boss && (npc.lifeMax > 1) && (npc.value > 0f)) {
                    npc.scale *= 2f;
                    npc.lifeMax *= 3;
                    npc.friendlyRegen = 20;
                }
            }

            
        }

        public override void NPCLoot(NPC npc)
        {
            //Drops summon

            //Worm Food
            if(npc.type == 6 || npc.type == -11 || npc.type == -12)
            {
                if (Main.rand.NextFloat() < .0600f)
                {
                    Item.NewItem(npc.getRect(), ItemID.WormFood);
                }
            }

            //Ivy Whip
            if(npc.TypeName == "Hornet")
            {
                if (Main.rand.NextFloat() < .1000f)
                {
                    Item.NewItem(npc.getRect(), ItemID.IvyWhip);
                }
            }


            //Fim drops summon
            //Devils Gold
            if(npc.type == NPCID.RedDevil)
            {
                if(Main.rand.NextFloat() < .1230f)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("DevilsGold"));
                }
            }

            //Poji Gem
            if (Main.hardMode && !npc.boss && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.position.Y > Main.rockLayer * 16.0 && npc.value > 0f)
            {
                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRockLayerHeight)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("PojiGem"));
                }
            }

            //Enchanted Shard
            if (Main.hardMode && !npc.boss && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.value > 0f && (NPC.downedMechBoss1 || NPC.downedMechBoss2 || NPC.downedMechBoss3))
            {
                
                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDungeon)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("EnchantedShard"));
                }
            }

        }
    }
}
