using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class IroningBoardItem : ModItem
    {
        public override void SetStaticDefaults(){DisplayName.SetDefault("Ironing Board");}
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 26;
            item.maxStack = 99;
            item.value = 25;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = TileType<Tiles.IroningBoard>();
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood",4);
			recipe.AddIngredient(ItemID.Silk,2);
			recipe.AddIngredient(mod, "PlasticBar");
			recipe.AddIngredient(mod, "ElectronicComponent");
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}