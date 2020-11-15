using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Walls
{
    public class RoundPaneGlassWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            Main.tileBlockLight[Type] = false;
            drop = ItemType<Items.RoundPaneGlassWallItem>();
        }
    }
}
