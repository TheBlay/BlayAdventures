using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace BlayAdventures.Items.Weapons
{
	public class HadesSlasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hades Slasher");
			Tooltip.SetDefault("It slashes through even the fear!");
		}
		public override void SetDefaults()
		{
			item.damage = 267;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 78900;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.scale = 1.8f;
            item.useTurn = false;
            
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "OrnovBar", 2);
            recipe.AddIngredient(mod, "TraevBar", 10);
            recipe.AddIngredient(ItemID.BloodButcherer);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            
            player.HealEffect((int)(damage * 0.04));
            player.statLife += (int)(damage * 0.04);

            if(player.statLife <= (player.statLifeMax2) * 0.5)
            {
                player.AddBuff(BuffID.Wrath, 300);
            }

            Random r = new Random();
            int prob = r.Next(2);
            if(prob == 1) target.AddBuff(BuffID.CursedInferno, 200);
            prob = r.Next(3);
            if(prob == 1) target.AddBuff(BuffID.ShadowFlame, 175);
        }
    }
}
