using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace terrarchitect.Items
{
	public class VintageFlowerWallpaperItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Vintage Flower Wallpaper");
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
			item.createWall = ModContent.WallType<Walls.VintageFlowerWallpaper>();
		}
	}
}