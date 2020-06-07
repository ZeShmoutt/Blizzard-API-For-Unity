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
			internal const string apiPath_CardSearch = "/hearthstone/cards";

			/// <summary>
			/// Coroutine that retrieves a list of cards specified by the search parameters.
			/// </summary>
			/// <param name="searchParameters">Filters used to retrieve specific cards. Can be set to null to retrieve all cards.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator CardSearch(HearthstoneCardSearch searchParameters, Action<Json_Hearthstone_CardsList> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string url = string.Concat(UrlDomain(region), apiPath_CardSearch, searchParameters != null ? searchParameters.ToURLParameters() : string.Empty);
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a list of cards specified by the search parameters, as a raw JSON string.
			/// </summary>
			/// <param name="searchParameters">Filters used to retrieve specific cards. Can be set to null to retrieve all cards.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator CardSearchRaw(HearthstoneCardSearch searchParameters, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string url = string.Concat(UrlDomain(region), apiPath_CardSearch, searchParameters != null ? searchParameters.ToURLParameters() : string.Empty);
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
	public class Json_Hearthstone_CardsList : Object_JSON
	{
		// {{JSON_START}}
		public Json_Hearthstone_Card[] cards;
		public int cardCount;
		public int pageCount;
		public int page;
		// {{JSON_END}}
	}
}