using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class PolkaDotsWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.PolkaDotsWallpaperItem>();
			AddMapEntry(new Color(224, 154, 140));
		}
	}
}
