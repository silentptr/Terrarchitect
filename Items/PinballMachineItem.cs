using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
	public class PinballMachineItem : ModItem
	{
		public override void SetStaticDefaults(){DisplayName.SetDefault("Pinball Machine");}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 64;
            item.maxStack = 99;
			item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
			item.value = 25;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = TileType<Tiles.PinballMachine>();
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar");
			recipe.AddIngredient(mod, "PlasticBar", 4);
			recipe.AddIngredient(ItemID.Glass,2);
			recipe.AddIngredient(mod, "ElectronicComponent",2);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
	}
}