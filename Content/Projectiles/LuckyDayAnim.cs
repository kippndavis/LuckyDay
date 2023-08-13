using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace LuckyDay.Content.Projectiles

{
    public class LuckyDayAnim : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 62; //The number of frames the sprite sheet has
        }

        public override void SetDefaults()
        {
            Projectile.timeLeft = 100;
            Projectile.light = 0.5f;
        }

        public override void AI()
        {

            Projectile.rotation = 0;
            Projectile.position.X = Main.player[Projectile.owner].position.X - 45;
            Projectile.position.Y = Main.player[Projectile.owner].position.Y - 68;

            //This will cycle through all of the frames in the sprite sheet
            int frameSpeed = 1;
            Projectile.frameCounter++;
            if (Projectile.frameCounter >= frameSpeed)
            {
                Projectile.frameCounter = 0;
                Projectile.frame++;
                if (Projectile.frame >= 53)
                {
                    Projectile.alpha += 14; // Fade out
                }
            }
            

        }
    }
}