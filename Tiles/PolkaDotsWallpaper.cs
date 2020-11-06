using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace terrarchitect.Walls
{
	public class PolkaDotsWallpaper : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.PolkaDotsWallpaper>();
			AddMapEntry(new Color(150, 150, 150));
		}
	}
}