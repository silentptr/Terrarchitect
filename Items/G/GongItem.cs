using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class GongItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gong");
            Tooltip.SetDefault("'Give it a whack!'");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 32;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 0, 50);

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Gong>();
        }
    }
}
