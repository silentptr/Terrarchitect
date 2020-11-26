using Terraria;
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
			
			recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bunny);
            recipe.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(ItemID.Leather);
            recipe.AddRecipe();	
			
			recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("IronBar");
            recipe.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(ItemID.Spike, 10);
            recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
            recipe.AddIngredient(ModContent.GetInstance<Items.Paper>(), 4);
            recipe.AddTile(ModContent.TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(ItemID.Book);
            recipe.AddRecipe();
        }
    }
}
