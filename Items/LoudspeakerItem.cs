using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class LoudspeakerItem : ModItem
    {
        public override void SetStaticDefaults(){DisplayName.SetDefault("Loudspeaker");}
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
            item.createTile = TileType<Tiles.Loudspeaker>();
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlasticBar",4);
			recipe.AddIngredient(mod, "ElectronicComponent",2);
			recipe.AddIngredient(ItemID.Wire,2);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
