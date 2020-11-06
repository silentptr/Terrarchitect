using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class AxeWallMountItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Axe Wall Mount");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 32;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.AxeWallMount>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadAxe);
            recipe.AddIngredient(ItemID.IronBar);
            recipe.anyIronBar = true;
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.IronAxe);
            recipe2.AddIngredient(ItemID.IronBar);
            recipe2.anyIronBar = true;
            recipe2.SetResult(this, 1);
            recipe2.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.AddRecipe();
        }
    }
}
