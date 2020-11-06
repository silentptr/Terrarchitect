using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class WaterBowlItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Bowl");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 10;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.WaterBowl>();
        }
    }
}
