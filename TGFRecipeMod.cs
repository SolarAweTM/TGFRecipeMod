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

			/*RECIPE REMOVALS
			 * - Item Frame
			 * - Weapon Rack
			 */

			RecipeFinder finder = new RecipeFinder();
			finder.AddRecipeGroup("Wood", 6);
			finder.AddTile(TileID.Sawmill);
			finder.SetResult(3270);
			Recipe recipe2 = finder.FindExactRecipe();
			RecipeEditor editor = new RecipeEditor(recipe2);
			editor.DeleteRecipe();

			finder = new RecipeFinder();
			finder.AddRecipeGroup("Wood", 10);
			finder.AddTile(TileID.Sawmill);
			finder.SetResult(2699);
            recipe2 = finder.FindExactRecipe();
			editor = new RecipeEditor(recipe2);
			editor.DeleteRecipe();
		}
	}
}