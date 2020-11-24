using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class OuthouseItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Outhouse");
            Tooltip.SetDefault("'someBODY ONCE TOLD ME'");
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 62;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Outhouse>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 12);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.Toilet);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
