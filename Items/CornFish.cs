using Terraria.ID;
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class CornFish : ModItem
	{
		public override void SetDefaults()
		{

			item.questItem = true;
			item.maxStack = 1;
			item.width = 26;
			item.height = 26;
			item.uniqueStack = true;
			item.rare = -11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corn Fish");
			Tooltip.SetDefault("");
		}


		public override bool IsQuestFish()
		{
			return true;
		}

		public override bool IsAnglerQuestAvailable()
		{
			return NPC.downedBoss1;
		}

		public override void AnglerQuestChat(ref string description, ref string catchLocation)
		{
			description = "Half-vegetable, half-fish! A real rarity for carnivorous vegetarians! How many wonderful dishes you can make with it... Go and catch it!";
			catchLocation = "Anywhere";
		}
	}
}