using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace TGFRecipeMod
{
	public class TGFRecipeMod : Mod
	{
		public override void AddRecipes()
		{
			if (ModLoader.TryGetMod("CalamityMod", out var Calamity)) //Calamity Integration
			{
				Recipe.Create(Calamity.Find<ModItem>("TrinketofChi").Type) //500 Red Brick @ Furnace -> Trinket of Chi
				.AddIngredient(131, 500)
				.AddTile(17)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("FungalSymbiote").Type) // 5 Mushroom Grass Seeds, 1 Decapodita Sprout, 1 Bone Sword @ Bottle -> Fungal Symbiote
				.AddIngredient(194, 5)
				.AddIngredient(Calamity.Find<ModItem>("DecapoditaSprout").Type)
				.AddIngredient(1166)
				.AddTile(13)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("TundraLeash").Type) // 20 Leather and 250 Ice Blocks @ Loom and Ice Machine -> Tundra Leash
				.AddIngredient(259, 20)
				.AddIngredient(664, 250)
				.AddTile(86)
				.AddTile(306)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("GladiatorsLocket").Type) // 750 Marble Blocks, 200 Javelins, and a Silver Broadsword @ Sawmill -> Gladiator's Locket
				.AddIngredient(3081, 750)
				.AddIngredient(3094, 200)
				.AddIngredient(3514)
				.AddTile(106)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("GladiatorsLocket").Type) // 750 Marble Blocks, 200 Javelins, and a Tungsten Broadsword @ Sawmill -> Gladiator's Locket
				.AddIngredient(3081, 750)
				.AddIngredient(3094, 200)
				.AddIngredient(3490)
				.AddTile(106)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("UnstablePrism").Type) // 750 Granite Blocks and 50 Draedon Power Cells @ Charging Station -> Unstable Granite Core
				.AddIngredient(3086, 750)
				.AddIngredient(Calamity.Find<ModItem>("PowerCell").Type, 50)
				.AddTile(Calamity.Find<ModTile>("ChargingStation").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("BossRush").Type) // 5 Auric Bars and 1 Jungle Dragon Egg @ Cosmic Anvil -> Terminus
				.AddIngredient(Calamity.Find<ModItem>("AuricBar").Type, 5)
				.AddIngredient(Calamity.Find<ModItem>("ChickenEgg").Type)
				.AddTile(Calamity.Find<ModTile>("CosmicAnvil").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("Murasama").Type) // 5 Auric Bars, 1 Muramasa, and 1 Anvient Shiv @ Cosmic Anvil -> Murasama
				.AddIngredient(Calamity.Find<ModItem>("AuricBar").Type, 5)
				.AddIngredient(155)
				.AddTile(Calamity.Find<ModTile>("CosmicAnvil").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("DragonScales").Type) // 5 Auric Bars, 5 Yharon Soul Fragments, and The Wand @ Cosmic Anvil -> Dragon Scales
				.AddIngredient(Calamity.Find<ModItem>("AuricBar").Type, 5)
				.AddIngredient(Calamity.Find<ModItem>("HellcasterFragment").Type, 5)
				.AddIngredient(Calamity.Find<ModItem>("TheWand").Type)
				.AddTile(Calamity.Find<ModTile>("CosmicAnvil").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("LuxorsGift").Type) // 500 Sandstone and 1 Amidias' Spark @ Furnace -> Luxor's Gift
				.AddIngredient(3271, 500)
				.AddIngredient(Calamity.Find<ModItem>("AmidiasSpark").Type)
				.AddTile(17)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("HeavenfallenStardisk").Type) // 25 Stardust, 5 Astral Bars, 10 Meteorite Bars @ Monolith Amalgam -> Heavenfallen Stardisk
				.AddIngredient(Calamity.Find<ModItem>("Stardust").Type, 25)
				.AddIngredient(Calamity.Find<ModItem>("AstralBar").Type, 5)
				.AddIngredient(117, 10)
				.AddTile(Calamity.Find<ModTile>("MonolithCrafting").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("AerialiteBar").Type, 10) //Aerialite Bar x10
				.AddIngredient(Calamity.Find<ModItem>("AerialiteOre").Type,40)
				.AddTile(17)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("AstralBar").Type, 10) //Astral Bar x10
				.AddIngredient(Calamity.Find<ModItem>("AstralOre").Type, 20)
				.AddIngredient(Calamity.Find<ModItem>("Stardust").Type, 30)
				.AddTile(412)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("AuricBar").Type, 10) //Auric Bar x10
				.AddIngredient(Calamity.Find<ModItem>("AuricOre").Type, 120)
				.AddIngredient(Calamity.Find<ModItem>("HellcasterFragment").Type, 2)
				.AddTile(Calamity.Find<ModTile>("CosmicAnvil").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("CruptixBar").Type, 10) //Scoria Bar x10
				.AddIngredient(Calamity.Find<ModItem>("ChaoticOre").Type, 50)
				.AddTile(133)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("UnholyCore").Type, 10) //Unholy Core	 x10
				.AddIngredient(Calamity.Find<ModItem>("CharredOre").Type, 40)
				.AddIngredient(174, 40)
				.AddTile(77)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("VerstaltiteBar").Type, 10) //Cryonic Bar x10
				.AddIngredient(Calamity.Find<ModItem>("CryonicOre").Type, 50)
				.AddTile(133)
				.Register();

				Recipe.Create(1225, 10) //Hallowed Bar x10
				.AddIngredient(Calamity.Find<ModItem>("HallowedOre").Type, 40)
				.AddTile(133)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("DraedonBar").Type, 10) //Perennial Bar x10
				.AddIngredient(Calamity.Find<ModItem>("PerennialOre").Type, 50)
				.AddTile(133)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("UeliaceBar").Type, 10) //Uelibloom Bar x10
				.AddIngredient(Calamity.Find<ModItem>("UelibloomOre").Type, 50)
				.AddTile(133)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("ShadowspecBar").Type, 10) //Shadowspec Bar x10
				.AddIngredient(Calamity.Find<ModItem>("AuricBar").Type, 10)
				.AddIngredient(Calamity.Find<ModItem>("ExoPrism").Type, 10)
				.AddIngredient(Calamity.Find<ModItem>("CalamitousEssence").Type, 10)
				.AddTile(Calamity.Find<ModTile>("DraedonsForge").Type)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("BarofLife").Type, 10) //Life Alloy x10
				.AddIngredient(Calamity.Find<ModItem>("VerstaltiteBar").Type, 10)
				.AddIngredient(Calamity.Find<ModItem>("DraedonBar").Type, 10)
				.AddIngredient(Calamity.Find<ModItem>("CruptixBar").Type, 10)
				.AddTile(134)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("CoreofCalamity").Type, 10) //Core of Calamity x10
				.AddIngredient(Calamity.Find<ModItem>("CoreofChaos").Type, 30)
				.AddIngredient(Calamity.Find<ModItem>("CoreofCinder").Type, 30)
				.AddIngredient(Calamity.Find<ModItem>("CoreofEleum").Type, 30)
				.AddIngredient(Calamity.Find<ModItem>("CalamityDust").Type, 10)
				.AddTile(134)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("CoreofChaos").Type, 10) //Core of Chaos x10
				.AddIngredient(Calamity.Find<ModItem>("EssenceofChaos").Type, 10)
				.AddIngredient(1508, 10)
				.AddTile(134)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("CoreofCinder").Type, 10) //Core of Sunlight x10
				.AddIngredient(Calamity.Find<ModItem>("EssenceofCinder").Type, 10)
				.AddIngredient(1508, 10)
				.AddTile(134)
				.Register();

				Recipe.Create(Calamity.Find<ModItem>("CoreofEleum").Type, 10) //Core of Eleum x10
				.AddIngredient(Calamity.Find<ModItem>("EssenceofEleum").Type, 10)
				.AddIngredient(1508, 10)
				.AddTile(134)
				.Register();
			}
			
			if(ModLoader.TryGetMod("VitalityMod", out var Vitality)) //Vitality Integration
            {
				Recipe.Create(Vitality.Find<ModItem>("AncientGoldBar").Type, 10) //Ancient Gold Bar x10
				.AddIngredient(Vitality.Find<ModItem>("AncientGoldShard").Type, 30)
				.AddIngredient(Vitality.Find<ModItem>("RustyIngot").Type, 10)
				.AddTile(133)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("RustyIngot").Type, 10) //Rusty Ingot x10
				.AddIngredient(Vitality.Find<ModItem>("RustyChunk").Type, 30)
				.AddTile(17)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("ArcticBar").Type, 10) //Arctic Bar x10
				.AddIngredient(Vitality.Find<ModItem>("ArcticOre").Type, 40)
				.AddTile(133)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("GeraniumBar").Type, 10) //Geranium Bar x10
				.AddIngredient(Vitality.Find<ModItem>("GeraniumOre").Type, 40)
				.AddTile(17)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("GeraniumBar").Type, 10)
				.AddIngredient(Vitality.Find<ModItem>("PurifiedBar").Type, 10)
				.AddIngredient(154,20)
				.AddTile(35)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("GlowingGraniteBar").Type, 10) //Glowing Granite Bar x10
				.AddIngredient(Vitality.Find<ModItem>("GlowingGranitePowder").Type, 30)
				.AddIngredient(3086, 10)
				.AddTile(77)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("PurifiedBar").Type, 10) //Purified Bar x10
				.AddIngredient(Vitality.Find<ModItem>("PurifiedSpore").Type, 20)
				.AddIngredient(57, 10)
				.AddTile(35)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("PurifiedBar").Type, 10)
				.AddIngredient(Vitality.Find<ModItem>("PurifiedSpore").Type, 20)
				.AddIngredient(1257, 10)
				.AddTile(35)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("BronzeAlloy").Type, 10) //Bronze Alloy x10
				.AddIngredient(Vitality.Find<ModItem>("BronzeShard").Type, 30)
				.AddTile(17)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("BronzeAlloy").Type, 10)
				.AddIngredient(12,20)
				.AddIngredient(699,10)
				.AddTile(17)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("SteelAlloy").Type, 10) //Steel Alloy x10
				.AddIngredient(Vitality.Find<ModItem>("Charcoal").Type, 20)
				.AddRecipeGroup("IronBar",10)
				.AddTile(17)
				.Register();

				Recipe.Create(Vitality.Find<ModItem>("Charcoal").Type, 10) //Charcoal x10
				.AddIngredient(9, 10)
				.AddTile(17)
				.Register();
			}

			Recipe.Create(20, 10) //Copper Bar craft x10
			.AddIngredient(12, 30)
			.AddTile(17)
			.Register();

			Recipe.Create(703,10) //Tin Bar x10
			.AddIngredient(699, 30)
			.AddTile(17)
			.Register();

			Recipe.Create(22,10) //Iron Bar x10
			.AddIngredient(11, 30)
			.AddTile(17)
			.Register();

			Recipe.Create(704,10) //Lead Bar x10
			.AddIngredient(700,30)
			.AddTile(17)
			.Register();

			Recipe.Create(21,10) //Silver Bar x10
			.AddIngredient(14, 40)
			.AddTile(17)
			.Register();

			Recipe.Create(705,10) //Tungsten Bar x10
			.AddIngredient(701, 40)
			.AddTile(17)
			.Register();

			Recipe.Create(19,10) //Gold Bar x10
			.AddIngredient(13, 40)
			.AddTile(17)
			.Register();

			Recipe.Create(706,10) //Platinum Bar x10
			.AddIngredient(702, 40)
			.AddTile(17)
			.Register();

			Recipe.Create(117,10) //Meteorite Bar x10
			.AddIngredient(116, 30)
			.AddTile(17)
			.Register();

			Recipe.Create(57,10) //Demonite Bar x10
			.AddIngredient(56, 30)
			.AddTile(17)
			.Register();

			Recipe.Create(1257,10) //Crimtane Bar x10
			.AddIngredient(880, 30)
			.AddTile(17)
			.Register();

			Recipe.Create(175,10) //Hellstone Bar x10
			.AddIngredient(174, 30)
			.AddTile(77)
			.Register();

			Recipe.Create(381,10) //Cobalt Bar x10
			.AddIngredient(364, 30)
			.AddTile(77)
			.Register();

			Recipe.Create(382,10) //Mythril Bar x10
			.AddIngredient(365, 40)
			.AddTile(77)
			.Register();

			Recipe.Create(391,10) //Adamantite Bar x10
			.AddIngredient(366, 40)
			.AddTile(133)
			.Register();

			Recipe.Create(1184,10) //Palladium Bar x10
			.AddIngredient(1104, 30)
			.AddTile(77)
			.Register();

			Recipe.Create(1191,10) //Orichalcum Bar x10
			.AddIngredient(1105, 40)
			.AddTile(77)
			.Register();

			Recipe.Create(1198,10) //Titanium Bar x10
			.AddIngredient(1106, 40)
			.AddTile(133)
			.Register();

			Recipe.Create(1006,10) //Chlorophyte Bar x10
			.AddIngredient(947, 50)
			.AddTile(133)
			.Register();

			Recipe.Create(3261,20) //Spectre Bar x20
			.AddIngredient(1006, 20)
			.AddIngredient(1508, 10)
			.AddTile(133)
			.Register();

			Recipe.Create(1552,10) //Shroomite Bar x10
			.AddIngredient(1006, 10)
			.AddIngredient(183, 150)
			.AddTile(247)
			.Register();

			Recipe.Create(3467,10) //Luminite Bar x10
			.AddIngredient(3460, 40)
			.AddTile(412)
			.Register();
		}
	}
}