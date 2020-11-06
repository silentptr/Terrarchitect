using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class PickaxeRackItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pickaxe Rack");
        }

        public override void SetDefaults()
        {
            item.width = 46;
            item.height = 40;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.PickaxeRack>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 8);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemID.IronPickaxe);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Wood, 8);
            recipe2.anyWood = true;
            recipe2.AddIngredient(ItemID.LeadPickaxe);
            recipe2.SetResult(this, 1);
            recipe2.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe2.AddRecipe();
        }
    }
}
