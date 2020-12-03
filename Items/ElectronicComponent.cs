using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items 
{
    public class ElectronicComponent : ModItem 
    {
		public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.maxStack = 99;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock,1);
			recipe.AddIngredient(ItemID.GoldOre);
			recipe.AddIngredient(ItemID.Wire,1);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandBlock,1);
			recipe.AddIngredient(ItemID.Wire,1);
			recipe.AddIngredient(ItemID.PlatinumOre);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
