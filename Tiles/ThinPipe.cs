using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Terrarchitect.Tiles
{
	public class ThinPipe : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			TileID.Sets.DrawsWalls[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Items.ThinPipeItem>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}
