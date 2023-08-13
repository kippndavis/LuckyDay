using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace LuckyDay.Content.Buffs
{
	public class Dodge : ModBuff
    {

        public override void Update(Player player, ref int buffIndex)
        {
            player.immune = true;
        }

    }
}