using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
	public class ThatchRoofItem : ModItem
	{
		public override void SetStaticDefaults(){DisplayName.SetDefault("Thatch Roof");}
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
			item.createTile = ModContent.TileType<Tiles.ThatchRoof>();
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Hay);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
