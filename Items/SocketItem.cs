using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class SocketItem : ModItem
    {
        public override void SetStaticDefaults(){DisplayName.SetDefault("Socket");}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 64;
            item.maxStack = 99;
			item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
			item.value = 5;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = TileType<Tiles.Socket>();
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlasticBar");
			recipe.AddIngredient(mod, "ElectronicComponent");
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
