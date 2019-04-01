using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Items.Weapons
{
    public class NinaGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nina");
            Tooltip.SetDefault("Meow? Meow!");
        }

        public override void SetDefaults()
        {
            item.autoReuse = true;
            item.ranged = true;
            item.noMelee = true;
            item.useStyle = 5;
            item.damage = 30;
            item.shootSpeed = 18;
            item.shoot = ProjectileID.ChlorophyteBullet;
            item.width = 58;
            item.height = 44;
            item.useAnimation = 17;
            item.useTime = 17;
            item.rare = 6;
            item.value = 59000;
            item.knockBack = 2f;
            item.UseSound = SoundID.Item96;
            item.useAmmo = AmmoID.Bullet;
            item.value = 500000;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            
            Projectile.NewProjectile(position.X + 20f, position.Y - 15f, (speedX), (speedY), ProjectileID.ExplosiveBullet, damage, knockBack, player.whoAmI);
            return true;
        }
    
        
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(10, -1);
        }
        
    }
}
