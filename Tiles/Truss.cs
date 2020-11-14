using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Terrarchitect.Tiles
{
	public class Truss : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			TileID.Sets.DrawsWalls[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Items.TrussItem>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}
