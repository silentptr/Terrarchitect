using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Walls
{
    public class BarbedWireFence : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            Main.wallLight[Type] = true;
            drop = ItemType<Items.BarbedWireFenceItem>();
        }
    }
}
