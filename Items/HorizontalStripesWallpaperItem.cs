using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class HorizontalStripesWallpaperItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Horizontal Stripes Wallpaper");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 99;
            item.value = 50;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createWall = WallType<Walls.HorizontalStripesWallpaper>();
        }
    }
}
