using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
	public class LeadlightItem : ModItem
	{
		public override void SetStaticDefaults(){DisplayName.SetDefault("Leadlight");}
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
			item.createTile = ModContent.TileType<Tiles.Leadlight>();
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LeadlightWallItem", 4);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(this);
            recipe.AddRecipe();
			
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.Glass);
			recipe1.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
			recipe1.SetResult(this);
			recipe1.AddRecipe();
        }
	}
}
