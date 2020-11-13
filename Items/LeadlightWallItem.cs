using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
	public class LeadlightWallItem : ModItem
	{
		public override void SetStaticDefaults() {DisplayName.SetDefault("Leadlight Wall");}
		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 50;
			item.createWall = ModContent.WallType<Walls.LeadlightWall>();
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LeadlightItem");
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
		}
	}
}
