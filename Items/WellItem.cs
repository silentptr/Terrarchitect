using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class WellItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Well");
        }

        public override void SetDefaults()
        {
            item.width = 60;
            item.height = 80;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = TileType<Tiles.Well>();
        }
         public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.anyWood = true;
            recipe.AddIngredient(ItemType<Bucket>(), 1);
            recipe.AddIngredient(ItemID.Rope, 6);
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
