using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class VerticalStripesWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.VerticalStripesWallpaperItem>();
			AddMapEntry(new Color(224, 155, 141));
		}
	}
}
