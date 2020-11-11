using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Terrarchitect.Walls
{
	public class LeadlightWall : ModWall
	{
		public override void SetDefaults() {
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.LeadlightWallItem>();
			AddMapEntry(new Color(73, 110, 115));
		}
}
	}
