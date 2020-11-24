using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class LargeMetalCageItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Large Metal Cage");
        }

        public override void SetDefaults()
        {
            item.width = 60;
            item.height = 60;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.LargeMetalCage>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.IronFence, 8);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
            
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.IronBar, 2);
            recipe2.anyIronBar = true;
            recipe2.AddIngredient(ItemID.LeadFence, 8);
            recipe2.SetResult(this, 1);
            recipe2.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.AddRecipe();
        }
    }
}
