using Terraria.ID;
using Terraria.ModLoader;

namespace Terrarchitect
{
	public class Terrarchitect : Mod
	{
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Squirrels");
            recipe.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(ItemID.Leather);
            recipe.AddRecipe();
			
			ModRecipe recipe1 = new ModRecipe(this);
            recipe1.AddIngredient(ItemID.Bunny);
            recipe1.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe1.SetResult(ItemID.Leather);
            recipe1.AddRecipe();	
			
			ModRecipe recipe2 = new ModRecipe(this);
            recipe2.AddRecipeGroup("IronBar");
            recipe2.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.SetResult(ItemID.Spike, 10);
            recipe2.AddRecipe();
			
			ModRecipe recipe3 = new ModRecipe(this);
            recipe3.AddIngredient(ModContent.GetInstance<Items.Paper>(), 4);
            recipe3.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe3.SetResult(ItemID.Book);
            recipe3.AddRecipe();
        }
    }
}
