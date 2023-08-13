using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace LuckyDay.Content.Items
{
	internal class LuckyDay : ModItem
	{

        public override void SetDefaults() 
		{
            Item.accessory = true;
            Item.value = 50000;
            Item.rare = -12;
        }

        public override void UpdateInventory(Player player)
        {
            Item.rare = -12;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<LuckyDayPlayer>().luckyDayItem = true;
            Item.rare = -12;
        }

        public override void AddRecipes()
        {

            Recipe recipe = Recipe.Create(ModContent.ItemType<Items.LuckyDay>(), 1);
            recipe.AddIngredient(ItemID.BrainOfConfusion, 1);
            recipe.AddTile(114); // Tinkerer's Workbench
            recipe.Register();
        }

    }
}