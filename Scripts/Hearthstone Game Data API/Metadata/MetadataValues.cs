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
				All,
				DemonHunterInitiate,
				AshesOfOutland,
				GalakrondsAwakening,
				DescentOfDragons,
				SaviorsOfUldum,
				RiseOfShadows,
				RastakhansRumble,
				TheBoomsdayProject,
				TheWitchwood,
				KoboldsAndCatacombs,
				KnightsOfTheFrozenThrone,
				JourneyToUngoro,
				MeanStreetsOfGadgetzan,
				OneNightInKarazhan,
				WhispersOfTheOldGods,
				LeagueOfExplorers,
				TheGrandTournament,
				BlackrockMountain,
				GoblinsVsGnomes,
				CurseOfNaxxramas,
				HallOfFame,
				Classic,
				Basic
			}
			
			internal static readonly Dictionary<CardSet, string> CardSetParameters = new Dictionary<CardSet, string>
			{
				{ CardSet.All, "" },
				{ CardSet.DemonHunterInitiate, "demonhunter-initiate" },
				{ CardSet.AshesOfOutland, "ashes-of-outland" },
				{ CardSet.GalakrondsAwakening, "galakronds-awakening" },
				{ CardSet.DescentOfDragons, "descent-of-dragons" },
				{ CardSet.SaviorsOfUldum, "saviors-of-uldum" },
				{ CardSet.RiseOfShadows, "rise-of-shadows" },
				{ CardSet.RastakhansRumble, "rastakhans-rumble" },
				{ CardSet.TheBoomsdayProject, "the-boomsday-project" },
				{ CardSet.TheWitchwood, "the-witchwood" },
				{ CardSet.KoboldsAndCatacombs, "kobolds-and-catacombs" },
				{ CardSet.KnightsOfTheFrozenThrone, "knights-of-the-frozen-throne" },
				{ CardSet.JourneyToUngoro, "journey-to-ungoro" },
				{ CardSet.MeanStreetsOfGadgetzan, "mean-streets-of-gadgetzan" },
				{ CardSet.OneNightInKarazhan, "one-night-in-karazhan" },
				{ CardSet.WhispersOfTheOldGods, "whispers-of-the-old-gods" },
				{ CardSet.LeagueOfExplorers, "league-of-explorers" },
				{ CardSet.TheGrandTournament, "the-grand-tournament" },
				{ CardSet.BlackrockMountain, "blackrock-mountain" },
				{ CardSet.GoblinsVsGnomes, "goblins-vs-gnomes" },
				{ CardSet.CurseOfNaxxramas, "naxxramas" },
				{ CardSet.HallOfFame, "hall-of-fame" },
				{ CardSet.Classic, "classic" },
				{ CardSet.Basic, "basic" }
			};
			/// <summary>
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardClass
			{
				All,
				DemonHunter,
				Druid,
				Hunter,
				Mage,
				Paladin,
				Priest,
				Rogue,
				Shaman,
				Warlock,
				Warrior,
				Neutral
			}
			
			internal static readonly Dictionary<CardClass, string> CardClassParameters = new Dictionary<CardClass, string>
			{
				{ CardClass.All, "" },
				{ CardClass.DemonHunter, "demonhunter" },
				{ CardClass.Druid, "druid" },
				{ CardClass.Hunter, "hunter" },
				{ CardClass.Mage, "mage" },
				{ CardClass.Paladin, "paladin" },
				{ CardClass.Priest, "priest" },
				{ CardClass.Rogue, "rogue" },
				{ CardClass.Shaman, "shaman" },
				{ CardClass.Warlock, "warlock" },
				{ CardClass.Warrior, "warrior" },
				{ CardClass.Neutral, "neutral" }
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
				All,
				Common,
				Free,
				Rare,
				Epic,
				Legendary
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
				All,
				Hero,
				Minion,
				Spell,
				Weapon
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
				Murloc,
				Demon,
				Mech,
				Elemental,
				Beast,
				Totem,
				Pirate,
				Dragon,
				All
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
			/// Used for Hearthstone card searches.
			/// </summary>
			public enum CardKeyword
			{
				All,
				Taunt,
				SpellDamage,
				DivineShield,
				Charge,
				Secret,
				Stealth,
				Battlecry,
				Freeze,
				Windfury,
				Deathrattle,
				Combo,
				Overload,
				Silence,
				Counter,
				Immune,
				Inspire,
				Discover,
				Quest,
				Poisonous,
				Adapt,
				Lifesteal,
				Recruit,
				Echo,
				Rush,
				Overkill,
				Magnetic,
				Lackey,
				Twinspell,
				MegaWindfury,
				Reborn,
				Invoke,
				Outcast
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
				{ CardKeyword.Magnetic, "modular" },
				{ CardKeyword.Lackey, "evilzug" },
				{ CardKeyword.Twinspell, "twinspell" },
				{ CardKeyword.MegaWindfury, "mega-windfury" },
				{ CardKeyword.Reborn, "reborn" },
				{ CardKeyword.Invoke, "empower" },
				{ CardKeyword.Outcast, "outcast" }
			};
			/// <summary>
			/// Used for Hearthstone searches.
			/// </summary>
			public enum GameMode
			{
				StandardWildFormats,
				Battlegrounds,
				CurrentArenaCards
			}
			
			internal static readonly Dictionary<GameMode, string> GameModeParameters = new Dictionary<GameMode, string>
			{
				{ GameMode.StandardWildFormats, "constructed" },
				{ GameMode.Battlegrounds, "battlegrounds" },
				{ GameMode.CurrentArenaCards, "arena" }
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
				All,
				Basic,
				Fireside,
				Achievements,
				Heroes,
				Seasonal,
				Legend,
				Esports,
				Games,
				Promotion,
				PrePurchase,
				Blizzard,
				Golden,
				Events
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