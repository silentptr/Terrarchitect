using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace Terrarchitect.Tiles
{
    public class RoundPaneGlass : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLavaDeath[Type] = false;
            Main.tileMergeDirt[Type] = false;
            TileID.Sets.DrawsWalls[Type] = true;
            Main.tileBlockLight[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            drop = ItemType<Items.RoundPaneGlassItem>();
        }
    }
}
