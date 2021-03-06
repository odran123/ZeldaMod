﻿using Terraria.ID;
using Terraria.ModLoader;

namespace ZeldaMod.Items.Medallions
{
    public class VioletMedallion : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Violet Medallion";
            item.width = 25;
            item.height = 25;
            item.toolTip = "One of the six medallions";
            item.value = 10000;
            item.rare = 2;
        }
    }
}
