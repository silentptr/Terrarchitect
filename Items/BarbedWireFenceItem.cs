using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.Items
{
    public class BarbedWireFenceItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barbed Wire Fence");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 30;
            item.maxStack = 99;
            item.value = 5;

            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createWall = WallType<Walls.BarbedWireFence>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chain);
            recipe.AddIngredient(ItemID.Spike);
            recipe.anyWood = true;
            recipe.SetResult(this);
            recipe.AddTile(TileType<Tiles.TerrarchitectCatalogue>());
            recipe.AddRecipe();
        }
    }
}
