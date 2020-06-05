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
			internal const string apiPath_Metadata_Keywords = "keywords";

			/// <summary>
			/// Coroutine that retrieves metadata related to keywords.
			/// </summary>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataKeywords(Action<Json_Hearthstone_Metadata_Keyword[]> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				yield return GetMetadata(apiPath_Metadata_Keywords, action_Result, ifModifiedSince, action_LastModified, region);
			}

			/// <summary>
			/// Coroutine that retrieves metadata related to keywords, as a raw JSON string.
			/// </summary>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataKeywordsRaw(Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				yield return GetMetadataRaw(apiPath_Metadata_Keywords, action_Result, ifModifiedSince, action_LastModified, region);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Hearthstone, representing keyword metadata.
	/// </summary>
	[Serializable]
	public class Json_Hearthstone_Metadata_Keyword : Object_JSON
	{
		// {{JSON_START}}
		public int id;
		public string slug;
		public LocalizedString name;
		public LocalizedString refText;
		public LocalizedString text;
		// {{JSON_END}}
	}
}
