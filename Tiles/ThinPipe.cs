using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Terrarchitect.Tiles
{
	public class ThinPipe : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileBrick[Type] = false;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Items.ThinPipeItem>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}
