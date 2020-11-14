using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Terrarchitect.Tiles
{
	public class Leadlight : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			TileID.Sets.DrawsWalls[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Items.LeadlightItem>();
		}
	}
}
