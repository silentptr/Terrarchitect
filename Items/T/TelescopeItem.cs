using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class TelescopeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Telescope");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 48;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 2);

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Telescope>();
        }
    }
}
