using Terraria;using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace StarsAbove.Buffs.EverlastingPickaxe
{
	public class EverlastingGunpowderLoaded : ModBuff
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Everlasting Gunpowder Loaded");
			Description.SetDefault("");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			StarsAbovePlayer modPlayer = player.GetModPlayer<StarsAbovePlayer>();
			


		}
	}
}