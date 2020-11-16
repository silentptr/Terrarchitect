using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Terrarchitect.Tiles
{
	public class SkullColumn : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			TileID.Sets.DrawsWalls[Type] = true;
			drop = ModContent.ItemType<Items.SkullColumnItem>();
			//AddMapEntry(new Color());
		}
	}
}