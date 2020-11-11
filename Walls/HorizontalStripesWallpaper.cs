using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Walls
{
    public class HorizontalStripesWallpaper : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            drop = ItemType<Items.HorizontalStripesWallpaperItem>();
            AddMapEntry(new Color(224, 155, 141));
        }
    }
}
