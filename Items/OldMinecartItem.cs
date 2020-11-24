using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class OldMinecartItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Old Minecart");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 38;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.OldMinecart>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Minecart, 1);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
