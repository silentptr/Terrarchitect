using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class GlobeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Globe");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 30;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 1);

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Globe>();
        }
    }
}
