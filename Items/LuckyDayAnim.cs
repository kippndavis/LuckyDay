using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace LuckyDay.Items

{
    public class LuckyDayAnim : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 62; //The number of frames the sprite sheet has
        }

        public override void SetDefaults()
        {
            projectile.timeLeft = 100;
        }

        public override void AI()
        {

            projectile.rotation = 0;
            projectile.position.X = Main.player[Main.myPlayer].position.X - 45;
            projectile.position.Y = Main.player[Main.myPlayer].position.Y - 60;

            //This will cycle through all of the frames in the sprite sheet
            int frameSpeed = 1;
            projectile.frameCounter++;
            if (projectile.frameCounter >= frameSpeed)
            {
                projectile.frameCounter = 0;
                projectile.frame++;
                if (projectile.frame >= 53)
                {
                    projectile.alpha += 14; // Fade out
                }
            }
            

        }
    }
}