using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Terrarchitect.Tiles
{
	public class Pipe : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			TileID.Sets.DrawsWalls[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Items.PipeItem>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}
