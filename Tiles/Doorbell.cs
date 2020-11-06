using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class Doorbell : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.AnchorLeft = new AnchorData(AnchorType.AlternateTile, TileObjectData.newTile.Height, 0);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.StyleTorch);
            TileObjectData.newAlternate.Width = 2;
            TileObjectData.newAlternate.Height = 2;
            TileObjectData.newAlternate.CoordinateWidth = 16;
            TileObjectData.newAlternate.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newAlternate.UsesCustomCanPlace = true;
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.AlternateTile, TileObjectData.newAlternate.Height, 0);
            TileObjectData.addAlternate(1);

            TileObjectData.addTile(Type);

            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 22, 32, ItemType<Items.DoorbellItem>());
        }
    }
}
