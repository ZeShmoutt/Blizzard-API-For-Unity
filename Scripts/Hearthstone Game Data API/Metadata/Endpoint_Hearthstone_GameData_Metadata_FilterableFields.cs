using System;
using System.Collections;

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
			internal const string apiPath_Metadata_FilterableFields = "filterableFields";

			/// <summary>
			/// Coroutine that retrieves metadata related to values that can be used to filter cards.
			/// </summary>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataFilterableFields(Action<string[]> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				yield return GetMetadata(apiPath_Metadata_Types, action_Result, ifModifiedSince, action_LastModified, region);
			}

			/// <summary>
			/// Coroutine that retrieves metadata related to values that can be used to filter cards, as a raw JSON string.
			/// </summary>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataFilterableFieldsRaw(Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				yield return GetMetadataRaw(apiPath_Metadata_Types, action_Result, ifModifiedSince, action_LastModified, region);
			}
		}
	}
}