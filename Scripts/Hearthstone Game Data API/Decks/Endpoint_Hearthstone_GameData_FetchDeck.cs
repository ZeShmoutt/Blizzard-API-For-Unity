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
			internal const string apiPath_FetchDeck = "/hearthstone/deck/{0}";

			/// <summary>
			/// Coroutine that retrieves a complete deck of cards.
			/// </summary>
			/// <param name="deckCode">A code that identifies a deck. You can copy one from the game or various Hearthstone websites.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator FetchDeck(string deckCode, Action<Json_Hearthstone_Deck> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string url = string.Concat(UrlDomain(region), string.Format(apiPath_FetchDeck, deckCode));
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a complete deck of cards, as a raw JSON string.
			/// </summary>
			/// <param name="deckCode">A code that identifies a deck. You can copy one from the game or various Hearthstone websites.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator FetchDeckRaw(string deckCode, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string url = string.Concat(UrlDomain(region), string.Format(apiPath_FetchDeck, deckCode));
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Hearthstone, representing a deck of cards.
	/// </summary>
	[Serializable]
	public class Json_Hearthstone_Deck : Object_JSON
	{
		// {{JSON_START}}
		public string deckCode;
		public int version;
		public string format;
		public Json_Hearthstone_Card hero;
		public Json_Hearthstone_Card heroPower;
		public Json_Hearthstone_Metadata_Class @class;
		public Json_Hearthstone_Card[] cards;
		public int cardCount;
		// {{JSON_END}}
	}
}