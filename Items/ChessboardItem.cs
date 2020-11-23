using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class ChessboardItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chessboard");
        }

        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 6;
            item.maxStack = 99;
            item.value = Item.buyPrice(0, 0, 50);

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Chessboard>();
        }
         public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SmoothMarbleBlock);
            recipe.AddIngredient(ItemID.Obsidian);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
