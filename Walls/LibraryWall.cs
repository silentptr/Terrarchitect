using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Walls
{
    public class LibraryWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = ItemType<Items.LibraryWallItem>();
        }
    }
}
