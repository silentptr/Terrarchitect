using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class Guillotine : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Width = 4;
            TileObjectData.newTile.Height = 5;
            TileObjectData.newTile.Origin = new Point16(0, 4);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16, 16, 18 };
            TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 60, 80, ItemType<Items.GuillotineItem>());
        }

        public override bool NewRightClick(int x, int y)
        {
            NPC nearestNPC = null;
            float minDist = float.MaxValue;
            Vector2 center = new Vector2(x * 16, y * 16);
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];
                if (npc.active && npc.townNPC && npc.type != NPCID.OldMan && npc.aiStyle != 0)
                {
                    float dist = npc.DistanceSQ(center);
                    if (dist < minDist)
                    {
                        nearestNPC = npc;
                        minDist = dist;
                    }
                }
            }

            if (nearestNPC != null && minDist < 300000)
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Guillotine"), Main.LocalPlayer.position);
                nearestNPC.StrikeNPCNoInteraction(9999, 10f, -nearestNPC.direction);
            }

            return true;
        }

        public override void MouseOver(int i, int j)
        {
            Main.LocalPlayer.noThrow = 2;
            Main.LocalPlayer.showItemIcon = true;
            Main.LocalPlayer.showItemIcon2 = ItemType<Items.GuillotineItem>();
        }
    }
}
