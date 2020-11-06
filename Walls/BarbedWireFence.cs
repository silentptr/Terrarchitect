using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Walls
{
    public class BarbedWireFence : ModWall
    {
        public override void SetDefaults()
        {
            drop = ItemType<Items.BarbedWireFenceItem>();
        }
    }
}
