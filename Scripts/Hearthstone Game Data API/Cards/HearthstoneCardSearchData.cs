using System.Collections.Generic;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Structure used for Hearthstone card searches.
	/// </summary>
	public partial class HearthstoneCardSearch
	{
		/// <summary>
		/// The slug of the set the card belongs to. If you do not supply a value, cards from all sets will be returned. Ignored if set to 'null'.
		/// </summary>
		public string set = null;

		/// <summary>
		/// The card's class.
		/// </summary>
		public CardClass @class = CardClass.All;

		/// <summary>
		/// The mana cost(s) required to play the card. Ignored if set to 'null'.
		/// </summary>
		public int[] manaCost = null;

		/// <summary>
		/// The attack power of the minion or weapon. Ignored if set to 'null'.
		/// </summary>
		public int[] attack = null;

		/// <summary>
		/// The health of a minion. Ignored if set to 'null'.
		/// </summary>
		public int[] health = null;

		/// <summary>
		/// Whether a card is collectible.
		/// </summary>
		public CardCollectability collectible = CardCollectability.All;

		/// <summary>
		/// The rarity of a card.
		/// </summary>
		public CardRarity rarity = CardRarity.All;

		/// <summary>
		/// The type of card (for example, minion, spell, and so on). Ignored if set to 'null'.
		/// </summary>
		public CardType type = CardType.All;

		/// <summary>
		/// The type of minion card (for example, beast, murloc, dragon, and so on). Ignored if set to 'null'.
		/// </summary>
		public MinionType minionType = MinionType.All;

		/// <summary>
		/// A required keyword on the card (for example, battlecry, deathrattle, and so on). Ignored if set to 'null'.
		/// </summary>
		public CardKeyword keyword = CardKeyword.All;

		/// <summary>
		/// A recognized game mode (for example, battlegrounds or constructed). The default value is constructed.
		/// </summary>
		public CardGameMode gameMode = CardGameMode.Constructed;

		/// <summary>
		/// A page number. Ignored if set to '-1'.
		/// </summary>
		public int page = -1;

		/// <summary>
		/// The number of results to choose per page. Ignored if set to '-1'.
		/// </summary>
		public int pageSize = -1;

		/// <summary>
		/// The field used to sort the results. Results are sorted by Mana Cost by default. Cards will also be sorted by class automatically in most cases.
		/// </summary>
		public SortType sort = SortType.SortByManaCost;

		/// <summary>
		/// The order in which to sort the results. The default value is Ascending.
		/// </summary>
		public SortOrder order = SortOrder.Ascending;

		/// <summary>
		/// Convert the search variables to a list of URL parameters.
		/// </summary>
		/// <returns>Returns a list of URL parameters.</returns>
		internal string ToURLParameters()
		{
			List<string> parts = new List<string>();

			if (!string.IsNullOrEmpty(set))
			{
				parts.Add("set=" + set.ToLowerInvariant());
			}

			if (@class != CardClass.All)
			{
				parts.Add("class=" + CardClassParameters[@class]);
			}

			if (manaCost != null && manaCost.Length > 0)
			{
				parts.Add("manaCost=" + string.Join(",", manaCost));
			}

			if (attack != null && attack.Length > 0)
			{
				parts.Add("attack=" + string.Join(",", attack));
			}

			if (health != null && health.Length > 0)
			{
				parts.Add("health=" + string.Join(",", health));
			}

			if (collectible != CardCollectability.All)
			{
				parts.Add("collectible=" + CardCollectabilityParameters[collectible]);
			}

			if (rarity != CardRarity.All)
			{
				parts.Add("rarity=" + CardRarityParameters[rarity]);
			}

			if (type != CardType.All)
			{
				parts.Add("type=" + CardTypeParameters[type]);
			}

			if (minionType != MinionType.All)
			{
				parts.Add("minionType=" + MinionTypeParameters[minionType]);
			}

			if (keyword != CardKeyword.All)
			{
				parts.Add("keyword=" + CardKeywordParameters[keyword]);
			}

			if (gameMode != CardGameMode.Constructed)
			{
				parts.Add("gameMode=" + CardGameModeParameters[gameMode]);
			}

			if (page >= 1)
			{
				parts.Add("page=" + page.ToString());
			}

			if (pageSize >= 1)
			{
				parts.Add("pageSize=" + pageSize.ToString());
			}

			if (sort != SortType.SortByManaCost)
			{
				parts.Add("sort=" + SortTypeParameters[sort]);
			}

			if (order != SortOrder.Ascending)
			{
				parts.Add("order=" + SortOrderParameters[order]);
			}

			return string.Concat("?", string.Join("&", parts));
		}

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum CardCollectability
		{
			All, Collectible, Uncollectible
		}

		internal static readonly Dictionary<CardCollectability, string> CardCollectabilityParameters = new Dictionary<CardCollectability, string>
		{
			{ CardCollectability.All, "0,1" },
			{ CardCollectability.Collectible, "1" },
			{ CardCollectability.Uncollectible, "0" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum CardClass
		{
			All, Neutral, Druid, Hunter, Mage, Paladin, Priest, Rogue, Shaman, Warlock, Warrior, DemonHunter
		}

		internal static readonly Dictionary<CardClass, string> CardClassParameters = new Dictionary<CardClass, string>
		{
			{ CardClass.All, string.Empty },
			{ CardClass.Neutral, "neutral" },
			{ CardClass.Druid, "druid" },
			{ CardClass.Hunter, "hunter" },
			{ CardClass.Mage, "mage" },
			{ CardClass.Paladin, "paladin" },
			{ CardClass.Priest, "priest" },
			{ CardClass.Rogue, "rogue" },
			{ CardClass.Shaman, "shaman" },
			{ CardClass.Warlock, "warlock" },
			{ CardClass.Warrior, "warrior" },
			{ CardClass.DemonHunter, "demonhunter" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum CardRarity
		{
			All, Common, Free, Rare, Epic, Legendary
		}

		internal static readonly Dictionary<CardRarity, string> CardRarityParameters = new Dictionary<CardRarity, string>
		{
			{ CardRarity.All, string.Empty },
			{ CardRarity.Common, "common" },
			{ CardRarity.Free, "free" },
			{ CardRarity.Rare, "rare" },
			{ CardRarity.Epic, "epic" },
			{ CardRarity.Legendary, "legendary" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum CardType
		{
			All, Hero, Minion, Spell, Weapon
		}

		internal static readonly Dictionary<CardType, string> CardTypeParameters = new Dictionary<CardType, string>
		{
			{ CardType.All, string.Empty },
			{ CardType.Hero, "hero" },
			{ CardType.Minion, "minion" },
			{ CardType.Spell, "spell" },
			{ CardType.Weapon, "weapon" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum MinionType
		{
			All, Murloc, Demon, Mech, Elemental, Beast, Totem, Pirate, Dragon
		}

		internal static readonly Dictionary<MinionType, string> MinionTypeParameters = new Dictionary<MinionType, string>
		{
			{ MinionType.All, "all" },
			{ MinionType.Murloc, "murloc" },
			{ MinionType.Demon, "demon" },
			{ MinionType.Mech, "mech" },
			{ MinionType.Elemental, "elemental" },
			{ MinionType.Beast, "beast" },
			{ MinionType.Totem, "totem" },
			{ MinionType.Pirate, "pirate" },
			{ MinionType.Dragon, "dragon" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
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
			{ CardKeyword.All, string.Empty },
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
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum CardGameMode
		{
			Constructed, Battlegrounds, Arena
		}

		internal static readonly Dictionary<CardGameMode, string> CardGameModeParameters = new Dictionary<CardGameMode, string>
		{
			{ CardGameMode.Constructed, "constructed" },
			{ CardGameMode.Battlegrounds, "battlegrounds" },
			{ CardGameMode.Arena, "arena" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum SortType
		{
			SortByManaCost, SortByAttack, SortByHealth, SortByName
		}

		internal static readonly Dictionary<SortType, string> SortTypeParameters = new Dictionary<SortType, string>
		{
			{ SortType.SortByManaCost, "manaCost" },
			{ SortType.SortByAttack, "attack" },
			{ SortType.SortByHealth, "health" },
			{ SortType.SortByName, "name" }
		};

		/// <summary>
		/// Used for Hearthstone card searchs.
		/// </summary>
		public enum SortOrder
		{
			Ascending, Descending
		}

		internal static readonly Dictionary<SortOrder, string> SortOrderParameters = new Dictionary<SortOrder, string>
		{
			{ SortOrder.Ascending, "asc" },
			{ SortOrder.Descending, "desc" }
		};
	}
}
