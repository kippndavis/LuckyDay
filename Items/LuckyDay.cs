using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace LuckyDay.Items
{
	public class LuckyDay : ModItem
	{

        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lucky Day");
			Tooltip.SetDefault("Sometimes makes enemies fail to attack you");
		}

		public override void SetDefaults() 
		{
            item.accessory = true;
            item.value = 10000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            modPlayer mPlayer = (modPlayer)(player.GetModPlayer(mod, "modPlayer"));
            mPlayer.luckyDayItem = true;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrainOfConfusion, 1);
            recipe.AddTile(114); // Tinkerer's Workshop;
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}