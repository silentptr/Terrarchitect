using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;
using Terraria.DataStructures;

namespace Terrarchitect.Tiles
{
    public class Socket : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 1;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
			TileObjectData.newTile.Origin = new Point16(0, 0);
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            drop = ItemType<Items.SocketItem>();
        }
    }
}
