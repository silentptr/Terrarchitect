using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class DeerSkullTrophyItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deer Skull Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 46;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 1);

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.DeerSkullTrophy>();
        }
    }
}
