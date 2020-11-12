using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class VintageVineWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.VintageVineWallpaperItem>();
			AddMapEntry(new Color(190, 162, 132));
		}
	}
}
