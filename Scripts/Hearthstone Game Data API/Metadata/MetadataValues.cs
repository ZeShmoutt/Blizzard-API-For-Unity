// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

using System.Collections.Generic;
using System;
using System.Collections;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		/// <summary>
		/// API endpoints related to Hearthstone game data (cards, card backs, etc.).
		/// Reference : https://develop.battle.net/documentation/hearthstone/game-data-apis
		/// </summary>
		public static partial class HearthstoneGameData
		{
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardSet
			{
				All = 0,
				Basic = 2,
				Classic = 3,
				HallOfFame = 4,
				CurseOfNaxxramas = 12,
				GoblinsVsGnomes = 13,
				BlackrockMountain = 14,
				TheGrandTournament = 15,
				LeagueOfExplorers = 20,
				WhispersOfTheOldGods = 21,
				OneNightInKarazhan = 23,
				MeanStreetsOfGadgetzan = 25,
				JourneyToUnGoro = 27,
				KnightsOfTheFrozenThrone = 1001,
				KoboldsAndCatacombs = 1004,
				TheWitchwood = 1125,
				TheBoomsdayProject = 1127,
				RastakhanSRumble = 1129,
				RiseOfShadows = 1130,
				SaviorsOfUldum = 1158,
				DescentOfDragons = 1347,
				GalakrondSAwakening = 1403,
				AshesOfOutland = 1414,
				ScholomanceAcademy = 1443,
				DemonHunterInitiate = 1463,
				MadnessAtTheDarkmoonFaire = 1466,
				ForgedInTheBarrens = 1525,
				Core = 1637
			}
			
			internal static readonly Dictionary<CardSet, string> CardSetParameters = new Dictionary<CardSet, string>
			{
				{ CardSet.All, "" },
				{ CardSet.Basic, "basic" },
				{ CardSet.Classic, "classic" },
				{ CardSet.HallOfFame, "hall-of-fame" },
				{ CardSet.CurseOfNaxxramas, "naxxramas" },
				{ CardSet.GoblinsVsGnomes, "goblins-vs-gnomes" },
				{ CardSet.BlackrockMountain, "blackrock-mountain" },
				{ CardSet.TheGrandTournament, "the-grand-tournament" },
				{ CardSet.LeagueOfExplorers, "league-of-explorers" },
				{ CardSet.WhispersOfTheOldGods, "whispers-of-the-old-gods" },
				{ CardSet.OneNightInKarazhan, "one-night-in-karazhan" },
				{ CardSet.MeanStreetsOfGadgetzan, "mean-streets-of-gadgetzan" },
				{ CardSet.JourneyToUnGoro, "journey-to-ungoro" },
				{ CardSet.KnightsOfTheFrozenThrone, "knights-of-the-frozen-throne" },
				{ CardSet.KoboldsAndCatacombs, "kobolds-and-catacombs" },
				{ CardSet.TheWitchwood, "the-witchwood" },
				{ CardSet.TheBoomsdayProject, "the-boomsday-project" },
				{ CardSet.RastakhanSRumble, "rastakhans-rumble" },
				{ CardSet.RiseOfShadows, "rise-of-shadows" },
				{ CardSet.SaviorsOfUldum, "saviors-of-uldum" },
				{ CardSet.DescentOfDragons, "descent-of-dragons" },
				{ CardSet.GalakrondSAwakening, "galakronds-awakening" },
				{ CardSet.AshesOfOutland, "ashes-of-outland" },
				{ CardSet.ScholomanceAcademy, "scholomance-academy" },
				{ CardSet.DemonHunterInitiate, "demonhunter-initiate" },
				{ CardSet.MadnessAtTheDarkmoonFaire, "madness-at-the-darkmoon-faire" },
				{ CardSet.ForgedInTheBarrens, "forged-in-the-barrens" },
				{ CardSet.Core, "core" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardClass
			{
				All = 0,
				Druid = 2,
				Hunter = 3,
				Mage = 4,
				Paladin = 5,
				Priest = 6,
				Rogue = 7,
				Shaman = 8,
				Warlock = 9,
				Warrior = 10,
				Neutral = 12,
				DemonHunter = 14
			}
			
			internal static readonly Dictionary<CardClass, string> CardClassParameters = new Dictionary<CardClass, string>
			{
				{ CardClass.All, "" },
				{ CardClass.Druid, "druid" },
				{ CardClass.Hunter, "hunter" },
				{ CardClass.Mage, "mage" },
				{ CardClass.Paladin, "paladin" },
				{ CardClass.Priest, "priest" },
				{ CardClass.Rogue, "rogue" },
				{ CardClass.Shaman, "shaman" },
				{ CardClass.Warlock, "warlock" },
				{ CardClass.Warrior, "warrior" },
				{ CardClass.Neutral, "neutral" },
				{ CardClass.DemonHunter, "demonhunter" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardCollectability
			{
				All,
				Collectible,
				Uncollectible
			}
			
			internal static readonly Dictionary<CardCollectability, string> CardCollectabilityParameters = new Dictionary<CardCollectability, string>
			{
				{ CardCollectability.All, "0,1" },
				{ CardCollectability.Collectible, "1" },
				{ CardCollectability.Uncollectible, "0" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardRarity
			{
				All = 0,
				Common = 1,
				Free = 2,
				Rare = 3,
				Epic = 4,
				Legendary = 5
			}
			
			internal static readonly Dictionary<CardRarity, string> CardRarityParameters = new Dictionary<CardRarity, string>
			{
				{ CardRarity.All, "" },
				{ CardRarity.Common, "common" },
				{ CardRarity.Free, "free" },
				{ CardRarity.Rare, "rare" },
				{ CardRarity.Epic, "epic" },
				{ CardRarity.Legendary, "legendary" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardType
			{
				All = 0,
				Hero = 3,
				Minion = 4,
				Spell = 5,
				Weapon = 7
			}
			
			internal static readonly Dictionary<CardType, string> CardTypeParameters = new Dictionary<CardType, string>
			{
				{ CardType.All, "" },
				{ CardType.Hero, "hero" },
				{ CardType.Minion, "minion" },
				{ CardType.Spell, "spell" },
				{ CardType.Weapon, "weapon" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum MinionType
			{
				Murloc = 14,
				Demon = 15,
				Mech = 17,
				Elemental = 18,
				Beast = 20,
				Totem = 21,
				Pirate = 23,
				Dragon = 24,
				All = 26
			}
			
			internal static readonly Dictionary<MinionType, string> MinionTypeParameters = new Dictionary<MinionType, string>
			{
				{ MinionType.Murloc, "murloc" },
				{ MinionType.Demon, "demon" },
				{ MinionType.Mech, "mech" },
				{ MinionType.Elemental, "elemental" },
				{ MinionType.Beast, "beast" },
				{ MinionType.Totem, "totem" },
				{ MinionType.Pirate, "pirate" },
				{ MinionType.Dragon, "dragon" },
				{ MinionType.All, "all" }
			};
			
			/// <summary>
			/// Used for Hearthstone searches.
			/// </summary>
			public enum SpellSchool
			{
				All = 0,
				Arcane = 1,
				Fire = 2,
				Frost = 3,
				Nature = 4,
				Holy = 5,
				Shadow = 6,
				Fel = 7
			}
			
			internal static readonly Dictionary<SpellSchool, string> SpellSchoolParameters = new Dictionary<SpellSchool, string>
			{
				{ SpellSchool.All, "" },
				{ SpellSchool.Arcane, "arcane" },
				{ SpellSchool.Fire, "fire" },
				{ SpellSchool.Frost, "frost" },
				{ SpellSchool.Nature, "nature" },
				{ SpellSchool.Holy, "holy" },
				{ SpellSchool.Shadow, "shadow" },
				{ SpellSchool.Fel, "fel" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardKeyword
			{
				All = 0,
				Taunt = 1,
				SpellDamage = 2,
				DivineShield = 3,
				Charge = 4,
				Secret = 5,
				Stealth = 6,
				Battlecry = 8,
				Freeze = 10,
				Windfury = 11,
				Deathrattle = 12,
				Combo = 13,
				Overload = 14,
				Silence = 15,
				Counter = 16,
				Immune = 17,
				SpareParts = 19,
				Inspire = 20,
				Discover = 21,
				Quest = 31,
				Poisonous = 32,
				Adapt = 34,
				Lifesteal = 38,
				Recruit = 39,
				Echo = 52,
				Rush = 53,
				Overkill = 61,
				StartOfGame = 64,
				Magnetic = 66,
				Lackey = 71,
				Twinspell = 76,
				MegaWindfury = 77,
				Reborn = 78,
				Invoke = 79,
				Outcast = 86,
				Spellburst = 88,
				Sidequest = 89,
				Corrupt = 91,
				StartOfCombat = 92,
				Frenzy = 99,
				NatureSpellDamage = 104
			}
			
			internal static readonly Dictionary<CardKeyword, string> CardKeywordParameters = new Dictionary<CardKeyword, string>
			{
				{ CardKeyword.All, "" },
				{ CardKeyword.Taunt, "taunt" },
				{ CardKeyword.SpellDamage, "spellpower" },
				{ CardKeyword.DivineShield, "divine-shield" },
				{ CardKeyword.Charge, "charge" },
				{ CardKeyword.Secret, "secret" },
				{ CardKeyword.Stealth, "stealth" },
				{ CardKeyword.Battlecry, "battlecry" },
				{ CardKeyword.Freeze, "freeze" },
				{ CardKeyword.Windfury, "windfury" },
				{ CardKeyword.Deathrattle, "deathrattle" },
				{ CardKeyword.Combo, "combo" },
				{ CardKeyword.Overload, "overload" },
				{ CardKeyword.Silence, "silence" },
				{ CardKeyword.Counter, "counter" },
				{ CardKeyword.Immune, "immune" },
				{ CardKeyword.SpareParts, "spare-part" },
				{ CardKeyword.Inspire, "inspire" },
				{ CardKeyword.Discover, "discover" },
				{ CardKeyword.Quest, "quest" },
				{ CardKeyword.Poisonous, "poisonous" },
				{ CardKeyword.Adapt, "adapt" },
				{ CardKeyword.Lifesteal, "lifesteal" },
				{ CardKeyword.Recruit, "recruit" },
				{ CardKeyword.Echo, "echo" },
				{ CardKeyword.Rush, "rush" },
				{ CardKeyword.Overkill, "overkill" },
				{ CardKeyword.StartOfGame, "startofgamekeyword" },
				{ CardKeyword.Magnetic, "modular" },
				{ CardKeyword.Lackey, "evilzug" },
				{ CardKeyword.Twinspell, "twinspell" },
				{ CardKeyword.MegaWindfury, "mega-windfury" },
				{ CardKeyword.Reborn, "reborn" },
				{ CardKeyword.Invoke, "empower" },
				{ CardKeyword.Outcast, "outcast" },
				{ CardKeyword.Spellburst, "spellburst" },
				{ CardKeyword.Sidequest, "sidequest" },
				{ CardKeyword.Corrupt, "corrupt" },
				{ CardKeyword.StartOfCombat, "start-of-combat" },
				{ CardKeyword.Frenzy, "frenzy" },
				{ CardKeyword.NatureSpellDamage, "spellpowernature" }
			};
			
			/// <summary>
			/// Used for Hearthstone searches.
			/// </summary>
			public enum GameMode
			{
				StandardWildFormats = 1,
				Battlegrounds = 2,
				CurrentArenaCards = 3,
				CurrentDuelsCards = 4
			}
			
			internal static readonly Dictionary<GameMode, string> GameModeParameters = new Dictionary<GameMode, string>
			{
				{ GameMode.StandardWildFormats, "constructed" },
				{ GameMode.Battlegrounds, "battlegrounds" },
				{ GameMode.CurrentArenaCards, "arena" },
				{ GameMode.CurrentDuelsCards, "duels" }
			};
			
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardSortType
			{
				SortByManaCost,
				SortByAttack,
				SortByHealth,
				SortByName
			}
			
			internal static readonly Dictionary<CardSortType, string> CardSortTypeParameters = new Dictionary<CardSortType, string>
			{
				{ CardSortType.SortByManaCost, "manaCost" },
				{ CardSortType.SortByAttack, "attack" },
				{ CardSortType.SortByHealth, "health" },
				{ CardSortType.SortByName, "name" }
			};
			
			/// <summary>
			/// Used for Hearthstone card back searches.
			/// </summary>
			public enum CardBackSortType
			{
				SortByDate,
				SortByName
			}
			
			internal static readonly Dictionary<CardBackSortType, string> CardBackSortTypeParameters = new Dictionary<CardBackSortType, string>
			{
				{ CardBackSortType.SortByDate, "date" },
				{ CardBackSortType.SortByName, "name" }
			};
			
			/// <summary>
			/// Used for Hearthstone searches.
			/// </summary>
			public enum CardBackCategory
			{
				All = 0,
				Basic = 1,
				Fireside = 2,
				Achievements = 3,
				Heroes = 4,
				Seasonal = 5,
				Legend = 6,
				Esports = 7,
				Games = 8,
				Promotion = 9,
				PrePurchase = 10,
				Blizzard = 11,
				Golden = 12,
				Events = 13
			}
			
			internal static readonly Dictionary<CardBackCategory, string> CardBackCategoryParameters = new Dictionary<CardBackCategory, string>
			{
				{ CardBackCategory.All, "" },
				{ CardBackCategory.Basic, "base" },
				{ CardBackCategory.Fireside, "fireside" },
				{ CardBackCategory.Achievements, "achieve" },
				{ CardBackCategory.Heroes, "heroes" },
				{ CardBackCategory.Seasonal, "season" },
				{ CardBackCategory.Legend, "legend" },
				{ CardBackCategory.Esports, "esports" },
				{ CardBackCategory.Games, "game_license" },
				{ CardBackCategory.Promotion, "promotion" },
				{ CardBackCategory.PrePurchase, "pre_purchase" },
				{ CardBackCategory.Blizzard, "blizzard" },
				{ CardBackCategory.Golden, "golden" },
				{ CardBackCategory.Events, "events" }
			};
			
			/// <summary>
			/// Used for Hearthstone searches.
			/// </summary>
			public enum SortOrder
			{
				Ascending,
				Descending
			}
			
			internal static readonly Dictionary<SortOrder, string> SortOrderParameters = new Dictionary<SortOrder, string>
			{
				{ SortOrder.Ascending, "asc" },
				{ SortOrder.Descending, "desc" }
			};
		}
	}
}