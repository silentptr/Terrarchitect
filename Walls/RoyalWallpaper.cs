using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class RoyalWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.RoyalWallpaperItem>();
			AddMapEntry(new Color(204, 124, 59));
		}
}
	}
