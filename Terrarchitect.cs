using Terraria.ID;
using Terraria.ModLoader;

namespace Terrarchitect
{
	public class Terrarchitect : Mod
	{
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.anyWood = true;
            recipe.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(ItemID.Book);
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(this);
            recipe2.AddIngredient(ItemID.IronBar);
            recipe2.anyIronBar = true;
            recipe2.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.SetResult(ItemID.Spike, 10);
            recipe2.AddRecipe();
        }
    }
}