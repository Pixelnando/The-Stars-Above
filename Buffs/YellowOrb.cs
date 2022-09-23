﻿using Microsoft.Xna.Framework;
using Terraria;using Terraria.ID;
using Terraria.ModLoader;

namespace StarsAbove.Buffs
{
    public class YellowOrb : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Orb");
            Description.SetDefault("Preparing 'Dazzling Strike'");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            

        }
    }
}