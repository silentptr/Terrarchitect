using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class DrinkingGlass : ModTile
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
            drop = ItemType<Items.DrinkingGlassItem>();
            adjTiles = new int[] { TileID.Bottles };
        }
    }
}
