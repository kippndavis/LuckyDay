using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using LuckyDay.Projectiles;

namespace LuckyDay.Items
{
    public class modPlayer : ModPlayer
    {

        public bool luckyDayItem = false;

        public override void ResetEffects()
        {
            luckyDayItem = false;
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (this.luckyDayItem == true && Main.rand.Next(6) == 0) // Lucky Day is equipped
            {   
                playSound = false;
                hitDirection = 0;
                player.AddBuff(mod.BuffType("Dodge"), (player.longInvince ? 120 : 80));
                Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/LuckyDayOggQuieter"));
                Projectile.NewProjectile(Main.player[Main.myPlayer].position.X, Main.player[Main.myPlayer].position.Y, 0, 0, ModContent.ProjectileType<LuckyDayAnim>(), 0, 0f);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

            
        