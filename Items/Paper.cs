using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class Paper : ModItem
    {
        public override void SetStaticDefaults(){DisplayName.SetDefault("Paper");}
		public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.maxStack = 99;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood");
            recipe.SetResult(this,4);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}