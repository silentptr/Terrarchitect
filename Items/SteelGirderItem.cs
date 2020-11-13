using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Terrarchitect.Items
{
	public class SteelGirderItem : ModItem
	{
		public override void SetStaticDefaults(){DisplayName.SetDefault("Steel Girder");}
		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.SteelGirder>();
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar");
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
	}
}
