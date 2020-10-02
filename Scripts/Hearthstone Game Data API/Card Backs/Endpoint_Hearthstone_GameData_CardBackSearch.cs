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
			internal const string apiPath_CardBackSearch = "/hearthstone/cardbacks";

			/// <summary>
			/// Coroutine that retrieves a list of card backs specified by the search parameters.
			/// </summary>
			/// <param name="searchParameters">Filters used to retrieve specific card backs. Can be set to null to retrieve all card backs.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator CardBackSearch(HearthstoneCardBackSearch searchParameters, Action<Json_Hearthstone_CardBacksList> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string url = string.Concat(UrlDomain(region), apiPath_CardBackSearch, searchParameters != null ? searchParameters.ToURLParameters() : string.Empty);
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a list of card backs specified by the search parameters, as a raw JSON string.
			/// </summary>
			/// <param name="searchParameters">Filters used to retrieve specific card backs. Can be set to null to retrieve all card backs.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator CardBackSearchRaw(HearthstoneCardBackSearch searchParameters, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string url = string.Concat(UrlDomain(region), apiPath_CardBackSearch, searchParameters != null ? searchParameters.ToURLParameters() : string.Empty);
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Hearthstone, representing a list of cards.
	/// </summary>
	[Serializable]
	public class Json_Hearthstone_CardBacksList : Object_JSON
	{
		// {{JSON_START}}
		public Json_Hearthstone_CardBack[] cardBacks;
		public int cardCount;
		public int pageCount;
		public int page;
		// {{JSON_END}}
	}
}