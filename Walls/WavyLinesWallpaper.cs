using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class WavyLinesWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.WavyLinesWallpaperItem>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}
