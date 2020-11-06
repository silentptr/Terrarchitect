using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class BirdHouseItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bird House");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 48;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.BirdHouse>();
        }
    }
}
