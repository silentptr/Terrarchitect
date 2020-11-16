using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class BlueRoofTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileBlockLight[Type] = false;
            Main.tileMergeDirt[Type] = false;
            Main.tileBlockLight[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            drop = ItemType<Items.BlueRoofTileItem>();
        }
    }
}
