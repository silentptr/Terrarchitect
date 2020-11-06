using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class WoodcuttingStumpItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Woodcutting Stump");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.WoodcuttingStump>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronAxe);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.anyWood = true;
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.LeadAxe);
            recipe2.AddIngredient(ItemID.Wood, 5);
            recipe2.anyWood = true;
            recipe2.SetResult(this, 1);
            recipe2.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.AddRecipe();
        }
    }
}
