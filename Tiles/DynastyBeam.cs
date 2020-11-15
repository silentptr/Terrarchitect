using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class DynastyBeam : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = false;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.IsBeam[Type] = true;
            Main.tileMergeDirt[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            drop = ItemType<Items.DynastyBeamItem>();
        }
    }
}
