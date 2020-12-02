using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items 
{
    public class PlasticBar : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plastic Bar");
        }
	
	public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.maxStack = 99;
	}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel,5);
			recipe.AddIngredient(ItemID.AshBlock,5);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
