using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class TanningRackItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tanning Rack");
        }

        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 48;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = 1;
            item.consumable = true;
            item.createTile = TileType<Tiles.TanningRack>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Squirrels");
            recipe.AddRecipeGroup("Wood",8);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
			
			ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.Bunny);
            recipe1.AddRecipeGroup("Wood",8);
            recipe1.SetResult(this);
            recipe1.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe1.AddRecipe();
        }
    }
}
