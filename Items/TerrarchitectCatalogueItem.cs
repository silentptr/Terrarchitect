using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class TerrarchitectCatalogueItem : ModItem
    {
        public override void SetStaticDefaults(){DisplayName.SetDefault("Terrarchitect Catalogue");}
		public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 99;
            item.value = 5;
			item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
			item.useStyle = 1;
            item.consumable = true;
            item.createTile = TileType<Tiles.TerrarchitectCatalogue>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 10);
			recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
