using Terraria.ID;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class EvilCornMask : ModItem
	{



		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 22;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Evil Corn Mask");
			Tooltip.SetDefault("");
		}

	}
}