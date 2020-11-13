using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items 
{
    public class Paper : ModItem //Is not calling it PaperItem too confusing? I don't know. It didn't have a tile variant so I just stuck with Paper instead
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
			recipe.AddRecipeGroup("Wood");
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
