using Terraria;
using Terraria.ID;
using Terraria.ObjectData;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class ChampagneGlass : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.StyleOnTable1x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            drop = ItemType<Items.ChampagneGlassItem>();
            adjTiles = new int[] { TileID.Bottles };
        }
    }
}
