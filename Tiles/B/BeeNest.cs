using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class BeeNest : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16 };
            TileObjectData.newTile.AnchorBottom = AnchorData.Empty;
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 32, ItemType<Items.BeeNestItem>());
        }

        public override bool NewRightClick(int i, int j)
        {
            SpawnBees(i, j);
            return true;
        }

        public override void MouseOver(int i, int j)
        {
            Main.LocalPlayer.noThrow = 2;
            Main.LocalPlayer.showItemIcon = true;
            Main.LocalPlayer.showItemIcon2 = ItemType<Items.BeeNestItem>();
        }

        public override void HitWire(int i, int j)
        {
            SpawnBees(i, j);
        }
        
        private void SpawnBees(int i, int j)
        {
            NPC.NewNPC(i * 16 - 8, j * 16, NPCID.BeeSmall);
            NPC.NewNPC(i * 16 + 8, j * 16, NPCID.BeeSmall);
            NPC.NewNPC(i * 16, j * 16 - 8, NPCID.BeeSmall);
        }
    }
}
