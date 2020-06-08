using System.Collections.Generic;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Structure used for Hearthstone card searches.
	/// </summary>
	public class HearthstoneCardSearch
	{
		/// <summary>
		/// The set the card belongs to. The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardSet set = BlizzardAPI.HearthstoneGameData.CardSet.All;

		/// <summary>
		/// The card's class. The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardClass @class = BlizzardAPI.HearthstoneGameData.CardClass.All;

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
		/// Whether a card is collectible. The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardCollectability collectible = BlizzardAPI.HearthstoneGameData.CardCollectability.All;

		/// <summary>
		/// The rarity of a card. The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardRarity rarity = BlizzardAPI.HearthstoneGameData.CardRarity.All;

		/// <summary>
		/// The type of card (for example, minion, spell, and so on). The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardType type = BlizzardAPI.HearthstoneGameData.CardType.All;

		/// <summary>
		/// The type of minion card (for example, beast, murloc, dragon, and so on). The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.MinionType minionType = BlizzardAPI.HearthstoneGameData.MinionType.All;

		/// <summary>
		/// A required keyword on the card (for example, battlecry, deathrattle, and so on). The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardKeyword keyword = BlizzardAPI.HearthstoneGameData.CardKeyword.All;

		/// <summary>
		/// A recognized game mode (for example, battlegrounds or constructed). The default value is 'StandardWildFormats'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.GameMode gameMode = BlizzardAPI.HearthstoneGameData.GameMode.StandardWildFormats;

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
		public BlizzardAPI.HearthstoneGameData.CardSortType sort = BlizzardAPI.HearthstoneGameData.CardSortType.SortByManaCost;

		/// <summary>
		/// The order in which to sort the results. The default value is 'Ascending'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.SortOrder order = BlizzardAPI.HearthstoneGameData.SortOrder.Ascending;

		/// <summary>
		/// Convert the search variables to a list of URL parameters.
		/// </summary>
		/// <returns>Returns a list of URL parameters.</returns>
		internal string ToURLParameters()
		{
			List<string> parts = new List<string>();

			if (set != BlizzardAPI.HearthstoneGameData.CardSet.All)
			{
				parts.Add("set=" + BlizzardAPI.HearthstoneGameData.CardSetParameters[set]);
			}

			if (@class != BlizzardAPI.HearthstoneGameData.CardClass.All)
			{
				parts.Add("class=" + BlizzardAPI.HearthstoneGameData.CardClassParameters[@class]);
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

			if (collectible != BlizzardAPI.HearthstoneGameData.CardCollectability.All)
			{
				parts.Add("collectible=" + BlizzardAPI.HearthstoneGameData.CardCollectabilityParameters[collectible]);
			}

			if (rarity != BlizzardAPI.HearthstoneGameData.CardRarity.All)
			{
				parts.Add("rarity=" + BlizzardAPI.HearthstoneGameData.CardRarityParameters[rarity]);
			}

			if (type != BlizzardAPI.HearthstoneGameData.CardType.All)
			{
				parts.Add("type=" + BlizzardAPI.HearthstoneGameData.CardTypeParameters[type]);
			}

			if (minionType != BlizzardAPI.HearthstoneGameData.MinionType.All)
			{
				parts.Add("minionType=" + BlizzardAPI.HearthstoneGameData.MinionTypeParameters[minionType]);
			}

			if (keyword != BlizzardAPI.HearthstoneGameData.CardKeyword.All)
			{
				parts.Add("keyword=" + BlizzardAPI.HearthstoneGameData.CardKeywordParameters[keyword]);
			}

			if (gameMode != BlizzardAPI.HearthstoneGameData.GameMode.StandardWildFormats)
			{
				parts.Add("gameMode=" + BlizzardAPI.HearthstoneGameData.GameModeParameters[gameMode]);
			}

			if (page >= 1)
			{
				parts.Add("page=" + page.ToString());
			}

			if (pageSize >= 1)
			{
				parts.Add("pageSize=" + pageSize.ToString());
			}

			if (sort != BlizzardAPI.HearthstoneGameData.CardSortType.SortByManaCost)
			{
				parts.Add("sort=" + BlizzardAPI.HearthstoneGameData.CardSortTypeParameters[sort]);
			}

			if (order != BlizzardAPI.HearthstoneGameData.SortOrder.Ascending)
			{
				parts.Add("order=" + BlizzardAPI.HearthstoneGameData.SortOrderParameters[order]);
			}

			return string.Concat("?", string.Join("&", parts));
		}
	}
}
