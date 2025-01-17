﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace StarsAbove.Buffs.Ozma
{
    public class AnnihilationState : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Annihilation State");
            Description.SetDefault("");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false; //Add this so the nurse doesn't remove the buff when healing
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) += 0.3f;
            player.GetCritChance(DamageClass.Generic) += 0.1f;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, int buffIndex, ref BuffDrawParams drawParams)
        {


            Vector2 shake = new Vector2(Main.rand.Next(-1, 2), Main.rand.Next(-1, 2));

            drawParams.Position += shake;
            drawParams.TextPosition += shake;


            return true;
        }
    }
}
