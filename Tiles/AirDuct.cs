using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Terrarchitect.Tiles
{
	public class AirDuct : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Items.AirDuctItem>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}
