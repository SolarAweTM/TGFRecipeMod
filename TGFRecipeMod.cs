using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace TGFRecipeMod
{
	public class TGFRecipeMod : Mod
	{
		public override void AddRecipes()
		{
			Mod Calamity = ModLoader.GetMod("CalamityMod");
			if (Calamity != null)
			{
				ModRecipe recipe = new ModRecipe(this); //500 Red Brick @ Furnace -> Trinket of Chi
				recipe.AddIngredient(131, 500);
				recipe.AddTile(17);
				recipe.SetResult(Calamity.ItemType("TrinketofChi"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 5 Mushroom Grass Seeds, 1 Decapodita Sprout, 1 Bone Sword @ Bottle -> Fungal Symbiote
				recipe.AddIngredient(194, 5);
				recipe.AddIngredient(Calamity.ItemType("DecapoditaSprout"));
				recipe.AddIngredient(1166);
				recipe.AddTile(13);
				recipe.SetResult(Calamity.ItemType("FungalSymbiote"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 20 Leather and 250 Ice Blocks @ Loom and Ice Machine -> Tundra Leash
				recipe.AddIngredient(259, 20);
				recipe.AddIngredient(664, 250);
				recipe.AddTile(86);
				recipe.AddTile(306);
				recipe.SetResult(Calamity.ItemType("TundraLeash"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 750 Marble Blocks, 200 Javelins, and a Silver Broadsword @ Sawmill -> Gladiator's Locket
				recipe.AddIngredient(3081, 750);
				recipe.AddIngredient(3094, 200);
				recipe.AddIngredient(3514);
				recipe.AddTile(106);
				recipe.SetResult(Calamity.ItemType("GladiatorsLocket"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 750 Marble Blocks, 200 Javelins, and a Tungsten Broadsword @ Sawmill -> Gladiator's Locket
				recipe.AddIngredient(3081, 750);
				recipe.AddIngredient(3094, 200);
				recipe.AddIngredient(3490);
				recipe.AddTile(106);
				recipe.SetResult(Calamity.ItemType("GladiatorsLocket"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 750 Granite Blocks and 50 Draedon Power Cells @ Charging Station -> Unstable Granite Core
				recipe.AddIngredient(3086, 750);
				recipe.AddIngredient(Calamity.ItemType("PowerCell"), 50);
				recipe.AddTile(Calamity.TileType("ChargingStation"));
				recipe.SetResult(Calamity.ItemType("UnstablePrism"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 5 Auric Bars and 1 Jungle Dragon Egg @ Cosmic Anvil -> Terminus
				recipe.AddIngredient(Calamity.ItemType("AuricBar"), 5);
				recipe.AddIngredient(Calamity.ItemType("ChickenEgg"));
				recipe.AddTile(Calamity.TileType("CosmicAnvil"));
				recipe.SetResult(Calamity.ItemType("BossRush"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 5 Auric Bars, 1 Muramasa, and 1 Anvient Shiv @ Cosmic Anvil -> Murasama
				recipe.AddIngredient(Calamity.ItemType("AuricBar"), 5);
				recipe.AddIngredient(155);
				recipe.AddIngredient(Calamity.ItemType("AncientShiv"));
				recipe.AddTile(Calamity.TileType("CosmicAnvil"));
				recipe.SetResult(Calamity.ItemType("Murasama"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 5 Auric Bars, 5 Yharon Soul Fragments, and The Wand @ Cosmic Anvil -> Dragon Scales
				recipe.AddIngredient(Calamity.ItemType("AuricBar"), 5);
				recipe.AddIngredient(Calamity.ItemType("HellcasterFragment"), 5);
				recipe.AddIngredient(Calamity.ItemType("TheWand"));
				recipe.AddTile(Calamity.TileType("CosmicAnvil"));
				recipe.SetResult(Calamity.ItemType("DragonScales"));
				recipe.AddRecipe();

				recipe = new ModRecipe(this); // 500 Sandstone and 1 Amidias' Spark @ Furnace -> Luxor's Gift
				recipe.AddIngredient(3271, 500);
				recipe.AddIngredient(Calamity.ItemType("AmidiasSpark"));
				recipe.AddTile(17);
				recipe.SetResult(Calamity.ItemType("LuxorsGift"));
				recipe.AddRecipe();

				Mod Catalyst = ModLoader.GetMod("CatalystMod");
				recipe = new ModRecipe(this); // 25 Stardust, 5 Astral Bars, 10 Meteorite Bars, 3 Metanova Bars (if Catalyst is enabled) @ Astral Transmogrifier with Catalyst, Monolith Amalgam if without -> Heavenfallen Stardisk
				recipe.AddIngredient(Calamity.ItemType("Stardust"), 25);
				recipe.AddIngredient(Calamity.ItemType("AstralBar"), 5);
				recipe.AddIngredient(117, 10);
				if (Catalyst != null)
				{
					recipe.AddIngredient(Catalyst.ItemType("MetanovaBar"), 3);
					recipe.AddTile(Catalyst.TileType("AstralTransmogrifier"));
				}
				else
				{
					recipe.AddTile(Calamity.TileType("MonolithCrafting"));
				}
				recipe.SetResult(Calamity.ItemType("HeavenfallenStardisk"));
				recipe.AddRecipe(); //wow i forgot to add this after debugging for 10min

				recipe = new ModRecipe(this); //Aerialite Bar x10
				recipe.AddIngredient(Calamity.ItemType("AerialiteOre"),40);
				recipe.AddTile(17);
				recipe.SetResult(Calamity.ItemType("AerialiteBar"),10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Astral Bar x10
				recipe.AddIngredient(Calamity.ItemType("AstralOre"), 20);
				recipe.AddIngredient(Calamity.ItemType("Stardust"), 30);
				recipe.AddTile(412);
				recipe.SetResult(Calamity.ItemType("AstralBar"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Auric Bar x10
				recipe.AddIngredient(Calamity.ItemType("AuricOre"), 120);
				recipe.AddIngredient(Calamity.ItemType("HellcasterFragment"), 2);
				recipe.AddTile(Calamity.TileType("CosmicAnvil"));
				recipe.SetResult(Calamity.ItemType("AuricBar"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Scoria Bar x10
				recipe.AddIngredient(Calamity.ItemType("ChaoticOre"), 50);
				recipe.AddTile(133);
				recipe.SetResult(Calamity.ItemType("CruptixBar"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Unholy Core	 x10
				recipe.AddIngredient(Calamity.ItemType("CharredOre"), 40);
				recipe.AddIngredient(174, 40);
				recipe.AddTile(77);
				recipe.SetResult(Calamity.ItemType("UnholyCore"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Cryonic Bar x10
				recipe.AddIngredient(Calamity.ItemType("CryonicOre"), 50);
				recipe.AddTile(133);
				recipe.SetResult(Calamity.ItemType("VerstaltiteBar"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Hallowed Bar x10
				recipe.AddIngredient(Calamity.ItemType("HallowedOre"), 40);
				recipe.AddTile(133);
				recipe.SetResult(1225, 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Perennial Bar x10
				recipe.AddIngredient(Calamity.ItemType("PerennialOre"), 50);
				recipe.AddTile(133);
				recipe.SetResult(Calamity.ItemType("DraedonBar"), 10); //why is it called a DRAEDON bar did they turn him into a granola bar or something
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Uelibloom Bar x10
				recipe.AddIngredient(Calamity.ItemType("UelibloomOre"), 50);
				recipe.AddTile(133); //why is this crafted at a FORGE
				recipe.SetResult(Calamity.ItemType("UeliaceBar"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Shadowspec Bar x10
				recipe.AddIngredient(Calamity.ItemType("AuricBar"), 10);
				recipe.AddIngredient(Calamity.ItemType("ExoPrism"), 10);
				recipe.AddIngredient(Calamity.ItemType("CalamitousEssence"), 10);
				recipe.AddTile(Calamity.TileType("DraedonsForge"));
				recipe.SetResult(Calamity.ItemType("ShadowspecBar"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Life Alloy x10
				recipe.AddIngredient(Calamity.ItemType("VerstaltiteBar"), 10);
				recipe.AddIngredient(Calamity.ItemType("DraedonBar"), 10);
				recipe.AddIngredient(Calamity.ItemType("CruptixBar"), 10);
				recipe.AddTile(134);
				recipe.SetResult(Calamity.ItemType("BarofLife"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Core of Calamity x10
				recipe.AddIngredient(Calamity.ItemType("CoreofChaos"), 30);
				recipe.AddIngredient(Calamity.ItemType("CoreofCinder"), 30);
				recipe.AddIngredient(Calamity.ItemType("CoreofEleum"), 30);
				recipe.AddIngredient(Calamity.ItemType("CalamityDust"), 10);
				recipe.AddTile(134);
				recipe.SetResult(Calamity.ItemType("CoreofCalamity"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Core of Chaos x10
				recipe.AddIngredient(Calamity.ItemType("EssenceofChaos"), 10);
				recipe.AddIngredient(1508, 10);
				recipe.AddTile(134);
				recipe.SetResult(Calamity.ItemType("CoreofChaos"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Core of Sunlight x10
				recipe.AddIngredient(Calamity.ItemType("EssenceofCinder"), 10);
				recipe.AddIngredient(1508, 10);
				recipe.AddTile(134);
				recipe.SetResult(Calamity.ItemType("CoreofCinder"), 10);
				recipe.AddRecipe();

				recipe = new ModRecipe(this); //Core of Eleum x10
				recipe.AddIngredient(Calamity.ItemType("EssenceofEleum"), 10);
				recipe.AddIngredient(1508, 10);
				recipe.AddTile(134);
				recipe.SetResult(Calamity.ItemType("CoreofEleum"), 10);
				recipe.AddRecipe();
			}
			/*RECIPE REMOVALS AND EDITS
			 * - Item Frame
			 * - Weapon Rack
			 * - Spooky Wings now require Spooky Wood
			 * - Tattered Fairy Wings now require Ectoplasm (this and spooky wings are meant to balance out imkSushi's Mod)
			 * - Bulk recipes for a lot of stuff
			 */

			RecipeFinder finder = new RecipeFinder(); //Removes Item Frames
			finder.AddRecipeGroup("Wood", 6);
			finder.AddTile(TileID.Sawmill);
			finder.SetResult(3270);
			Recipe recipe2 = finder.FindExactRecipe();
			RecipeEditor editor = new RecipeEditor(recipe2);
			editor.DeleteRecipe();

			finder = new RecipeFinder(); //Removes Weapon Racks
			finder.AddRecipeGroup("Wood", 10);
			finder.AddTile(TileID.Sawmill);
			finder.SetResult(2699);
            recipe2 = finder.FindExactRecipe();
			editor = new RecipeEditor(recipe2);
			editor.DeleteRecipe();

			finder = new RecipeFinder(); //Adjusts Spooky Wings
			finder.AddIngredient(1831);
			finder.AddIngredient(575, 20);
			finder.AddTile(TileID.MythrilAnvil);
			finder.SetResult(1830);
			recipe2 = finder.FindExactRecipe();
			editor = new RecipeEditor(recipe2);
			editor.AddIngredient(1729, 50);

			finder = new RecipeFinder(); //Adjusts Tattered Fairy Wings
			finder.AddIngredient(1811);
			finder.AddIngredient(575, 20);
			finder.AddTile(TileID.MythrilAnvil);
			finder.SetResult(1797);
			recipe2 = finder.FindExactRecipe();
			editor = new RecipeEditor(recipe2);
			editor.AddIngredient(1508, 5);

			ModRecipe recipe3 = new ModRecipe(this);

			recipe3 = new ModRecipe(this); //Copper Bar craft x10
			recipe3.AddIngredient(12, 30);
			recipe3.AddTile(17);
			recipe3.SetResult(20, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Tin Bar x10
			recipe3.AddIngredient(699, 30);
			recipe3.AddTile(17);
			recipe3.SetResult(703, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Iron Bar x10
			recipe3.AddIngredient(11, 30);
			recipe3.AddTile(17);
			recipe3.SetResult(22, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Lead Bar x10
			recipe3.AddIngredient(700,30);
			recipe3.AddTile(17);
			recipe3.SetResult(704,10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Silver Bar x10
			recipe3.AddIngredient(14, 40);
			recipe3.AddTile(17);
			recipe3.SetResult(21, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Tungsten Bar x10
			recipe3.AddIngredient(701, 40);
			recipe3.AddTile(17);
			recipe3.SetResult(705, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Gold Bar x10
			recipe3.AddIngredient(13, 40);
			recipe3.AddTile(17);
			recipe3.SetResult(19, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Platinum Bar x10
			recipe3.AddIngredient(702, 40);
			recipe3.AddTile(17);
			recipe3.SetResult(706, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Meteorite Bar x10
			recipe3.AddIngredient(116, 30);
			recipe3.AddTile(17);
			recipe3.SetResult(117, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Demonite Bar x10
			recipe3.AddIngredient(56, 30);
			recipe3.AddTile(17);
			recipe3.SetResult(57, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Crimtane Bar x10
			recipe3.AddIngredient(880, 30);
			recipe3.AddTile(17);
			recipe3.SetResult(1257, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Hellstone Bar x10
			recipe3.AddIngredient(174, 30);
			recipe3.AddTile(77);
			recipe3.SetResult(175, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Cobalt Bar x10
			recipe3.AddIngredient(364, 30);
			recipe3.AddTile(77);
			recipe3.SetResult(381, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Mythril Bar x10
			recipe3.AddIngredient(365, 40);
			recipe3.AddTile(77);
			recipe3.SetResult(382, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Adamantite Bar x10
			if (Calamity != null)
			{
				recipe3.AddIngredient(366, 40);
			}
			else
			{
				recipe3.AddIngredient(366, 50);
			}
			recipe3.AddTile(133);
			recipe3.SetResult(391, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Palladium Bar x10
			recipe3.AddIngredient(1104, 30);
			recipe3.AddTile(77);
			recipe3.SetResult(1184, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Orichalcum Bar x10
			recipe3.AddIngredient(1105, 40);
			recipe3.AddTile(77);
			recipe3.SetResult(1191, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Titanium Bar x10
			if (Calamity != null)
			{
				recipe3.AddIngredient(1106, 40);
			}
			else
			{
				recipe3.AddIngredient(1106, 50);
			}
			recipe3.AddTile(133);
			recipe3.SetResult(1198, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Chlorophyte Bar x10
			if (Calamity != null)
			{
				recipe3.AddIngredient(947, 40);
			}
			else
			{
				recipe3.AddIngredient(947, 60);
			}
			recipe3.AddTile(133);
			recipe3.SetResult(1006, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Spectre Bar x20
			recipe3.AddIngredient(1006, 20);
			recipe3.AddIngredient(1508, 10);
			recipe3.AddTile(133);
			recipe3.SetResult(3261, 20);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Shroomite Bar x10
			recipe3.AddIngredient(1006, 10);
			recipe3.AddIngredient(183, 150);
			recipe3.AddTile(247);
			recipe3.SetResult(1552, 10);
			recipe3.AddRecipe();

			recipe3 = new ModRecipe(this); //Luminite Bar x10
			recipe3.AddIngredient(3460, 40);
			recipe3.AddTile(412);
			recipe3.SetResult(3467, 10);
			recipe3.AddRecipe();
		}
	}
}