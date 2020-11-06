using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Tiles
{
    public class SmallCrystalBall : ModTile
    {
        private const float glowDecrease = 0.8f;

        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            drop = ItemType<Items.SmallCrystalBallItem>();
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.6f / glowDecrease;
            g = 0.3568627450980392f / glowDecrease;
            b = 0.9607843137254902f / glowDecrease;
        }

        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Lighting.AddLight(new Vector2(i, j + 2), new Vector3(1.0f, 1.0f, 1.0f));
            return true;
        }
    }
}
