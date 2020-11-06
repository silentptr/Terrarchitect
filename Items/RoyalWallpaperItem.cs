using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace terrarchitect.Items
{
	public class RoyalWallpaperItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("RoyalWallpaper");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 50;
			item.createWall = ModContent.WallType<Walls.RoyalWallpaper>();
		}
	}
}