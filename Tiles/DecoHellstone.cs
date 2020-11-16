using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Terrarchitect.Tiles
{
	public class DecoHellstone : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = ModContent.ItemType<Items.DecoHellstoneItem>();
		}
		
			public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 0.15f;
			g = 0f;
			b = 0f;
		}
	}
}