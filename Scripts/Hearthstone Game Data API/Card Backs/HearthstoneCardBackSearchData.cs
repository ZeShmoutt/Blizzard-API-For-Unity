using System.Collections.Generic;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Structure used for Hearthstone card searches.
	/// </summary>
	public class HearthstoneCardBackSearch
	{
		/// <summary>
		/// The card back's category. The default value is 'All'.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardBackCategory category = BlizzardAPI.HearthstoneGameData.CardBackCategory.All;

		/// <summary>
		/// A page number. Ignored if set to '-1'.
		/// </summary>
		public int page = -1;

		/// <summary>
		/// The number of results to choose per page. Ignored if set to '-1'.
		/// </summary>
		public int pageSize = -1;

		/// <summary>
		/// The field used to sort the results. Results are sorted by Date by default.
		/// </summary>
		public BlizzardAPI.HearthstoneGameData.CardBackSortType sort = BlizzardAPI.HearthstoneGameData.CardBackSortType.SortByDate;

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

			if (category != BlizzardAPI.HearthstoneGameData.CardBackCategory.All)
			{
				parts.Add("class=" + BlizzardAPI.HearthstoneGameData.CardBackCategoryParameters[category]);
			}

			if (page >= 1)
			{
				parts.Add("page=" + page.ToString());
			}

			if (pageSize >= 1)
			{
				parts.Add("pageSize=" + pageSize.ToString());
			}

			if (sort != BlizzardAPI.HearthstoneGameData.CardBackSortType.SortByDate)
			{
				parts.Add("sort=" + BlizzardAPI.HearthstoneGameData.CardBackSortTypeParameters[sort]);
			}

			if (order != BlizzardAPI.HearthstoneGameData.SortOrder.Ascending)
			{
				parts.Add("order=" + BlizzardAPI.HearthstoneGameData.SortOrderParameters[order]);
			}

			return string.Concat("?", string.Join("&", parts));
		}
	}
}
