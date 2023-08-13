using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Audio;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using LuckyDay.Content.Projectiles;

namespace LuckyDay.Content.Items
{
    public class LuckyDayPlayer : ModPlayer
    {

        public bool luckyDayItem = false;

        public override void ResetEffects()
        {
            luckyDayItem = false;
        }

        public override bool FreeDodge(Player.HurtInfo info) {
            if (Player.whoAmI == Main.myPlayer) // Relevant for multi
            {
                if (this.luckyDayItem == true && Main.rand.Next(6) == 0) // Lucky Day equipped
                {
                    Player.AddBuff(Mod.Find<ModBuff>("Dodge").Type, (Player.longInvince ? 120 : 80));
                    SoundEngine.PlaySound(new SoundStyle("LuckyDay/Assets/Sounds/LuckyDayOgg"));
                    Projectile.NewProjectile(null, Main.player[Main.myPlayer].position.X, Main.player[Main.myPlayer].position.Y, 0, 0, ModContent.ProjectileType<LuckyDayAnim>(), 0, 0f, Main.myPlayer);
                    return true;
                }
            }
            return false;
        }
    }
}

            
        