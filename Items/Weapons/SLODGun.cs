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
    public class SLODGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("S.L.O.D");
            Tooltip.SetDefault("SLOD stands for:" +
                "\nSpectral Laser Of Destruction" +
                "\nTravels through tiles.");
        }

        public override void SetDefaults()
        {
            item.width = 60;
            item.height = 40;
            item.damage = 310;
            item.knockBack = 0.3f;
            item.value = 950000;
            item.rare = -12;
            item.useTime = 8;
            item.useAnimation = 8;
            item.shoot = mod.ProjectileType("ModP_Laser");
            item.shootSpeed = 15f;
            item.useStyle = 5;
            item.melee = false;
            item.autoReuse = true;
            item.ranged = true;
            item.UseSound = SoundID.Item12.WithPitchVariance(.44f);
            
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2, 0);
        }

        


    }
}
