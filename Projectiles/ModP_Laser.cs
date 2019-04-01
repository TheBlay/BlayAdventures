using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BlayAdventures.Projectiles
{
    public class ModP_Laser : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Destruction Laser");
        }

        public override void SetDefaults()
        {
            projectile.width = 2;
            projectile.height = 42;
            projectile.alpha = 170;
            projectile.extraUpdates = 2;
            projectile.friendly = true;
            projectile.aiStyle = 1;
            aiType = ProjectileID.DeathLaser;
            projectile.scale = 1.6f;
            projectile.timeLeft = 70;
            projectile.penetrate = -1;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.light = 0.2f;
            projectile.tileCollide = false;
        }

    }
}
