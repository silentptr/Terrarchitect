using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class VacuumCleanerItem : ModItem
    {
        public override void SetStaticDefaults(){DisplayName.SetDefault("Vacuum Cleaner");}
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
            item.createTile = TileType<Tiles.VacuumCleaner>();
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlasticBar",6);
			recipe.AddIngredient(mod, "ElectronicComponent");
			recipe.AddIngredient(ItemID.Silk);
			recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
