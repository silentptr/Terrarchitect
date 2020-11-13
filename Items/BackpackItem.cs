using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class BackpackItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Backpack");
        }

        public override void SetDefaults()
        {
            item.width = 44;
            item.height = 40;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 1);

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Backpack>();
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Leather,4);
			recipe.AddIngredient(ItemID.Silk,2);
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
