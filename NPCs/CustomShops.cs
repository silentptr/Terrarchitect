using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Terrarchitect.NPCs
{
    public class CustomShops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.BirdHouseItem>()); // needs to be zoologist
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.CashRegisterItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.DogHouseItem>()); // needs to be zoologist
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.FoodBowlItem>()); // needs to be zoologist
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.GoldenBellItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.ParchmentItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.PileOfScrollsItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 5);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.PinnedNoteItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.ScalesItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.ScratchTreeItem>()); // needs to be zoologist
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.ServiceBellItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.StampItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.WaterBowlItem>()); // needs to be zoologist
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;
                    break;
                case NPCID.Dryad:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.GardenHoseItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.PottedAloeVeraItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.PottedCactusItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.PottedSeedlingItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.WaterBowlItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.BirdNestItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.BeeNestItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;
                    break;
                case NPCID.PartyGirl:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.ParasolItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;
                    break;
                case NPCID.Pirate:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.ShipCannonItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.AnchorWallMountItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.BigChestItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1);
                    nextSlot++;
                    break;
                case NPCID.Wizard:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.SmallCrystalBallItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;
                    break;
                case NPCID.Mechanic:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.ToolboxItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;
                    break;
                case NPCID.DD2Bartender:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.BeerMugItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;
                    break;
                case NPCID.Clothier:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.DressingScreenItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.SewingMachineItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1);
                    nextSlot++;
                    break;
                case NPCID.Painter:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.EaselItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 20);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.SmallFramedPictureItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(mod.ItemType("VerticalStripesWallpaperItem"));   //Wallpapers
                    nextSlot++;  
		    shop.item[nextSlot].SetDefaults(mod.ItemType("VintageFlowerWallpaperItem"));   
                    nextSlot++; 
		    shop.item[nextSlot].SetDefaults(mod.ItemType("VintageVineWallpaperItem"));   
                    nextSlot++; 
		    shop.item[nextSlot].SetDefaults(mod.ItemType("WavyLinesWallpaperItem"));   
                    nextSlot++; 
		    shop.item[nextSlot].SetDefaults(mod.ItemType("RoyalWallpaperItem"));   
                    nextSlot++; 
		    shop.item[nextSlot].SetDefaults(mod.ItemType("PolkaDotsWallpaperItem"));   
                    nextSlot++; 
		    shop.item[nextSlot].SetDefaults(mod.ItemType("HorizontalStripesWallpaperItem"));  
                    nextSlot++;
                    break;
                case NPCID.WitchDoctor:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.LongTikiMaskItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;

                    shop.item[nextSlot].SetDefaults(ItemType<Items.TikiMaskItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 10);
                    nextSlot++;
                    break;
                case NPCID.Demolitionist:
                    shop.item[nextSlot].SetDefaults(ItemType<Items.HazardWarningBlockItem>());
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 1);
                    nextSlot++;
                    break;
            }
        }

        public override void SetupTravelShop(int[] shop, ref int nextSlot)
        {
            int r = Main.rand.Next(1, 26);

            switch (r)
            {
                case 1:
                    shop[nextSlot] = ItemType<Items.DeerHuntingTrophyItem>();
                    nextSlot++;
                    break;
                case 2:
                    shop[nextSlot] = ItemType<Items.GongItem>();
                    nextSlot++;
                    break;
                case 3:
                    shop[nextSlot] = ItemType<Items.GlobeItem>();
                    nextSlot++;
                    break;
                case 4:
                    shop[nextSlot] = ItemType<Items.TelescopeItem>();
                    nextSlot++;
                    break;
                case 5:
                    shop[nextSlot] = ItemType<Items.AntelopeHuntingTrophyItem>();
                    nextSlot++;
                    break;
                case 6:
                    shop[nextSlot] = ItemType<Items.DeerSkullTrophyItem>();
                    nextSlot++;
                    break;
                case 7:
                    shop[nextSlot] = ItemType<Items.LargeGlobeItem>();
                    nextSlot++;
                    break;
                case 8:
                    shop[nextSlot] = ItemType<Items.RhinoHuntingTrophyItem>();
                    nextSlot++;
                    break;
            }
        }
    }
}
