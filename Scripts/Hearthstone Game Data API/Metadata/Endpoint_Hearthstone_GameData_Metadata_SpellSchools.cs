// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

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
			internal const string apiPath_Metadata_SpellSchools = "spellSchools";

			/// <summary>
			/// Coroutine that retrieves metadata related to spell schools.
			/// </summary>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataSpellSchools(Action<Json_Hearthstone_Metadata_SpellSchool[]> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				yield return GetMetadata(apiPath_Metadata_SpellSchools, action_Result, ifModifiedSince, action_LastModified, action_OnError, region);
			}

			/// <summary>
			/// Coroutine that retrieves metadata related to spell schools, as a raw JSON string.
			/// </summary>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataSpellSchoolsRaw(Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				yield return GetMetadataRaw(apiPath_Metadata_SpellSchools, action_Result, ifModifiedSince, action_LastModified, action_OnError, region);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Hearthstone, representing spell school metadata.
	/// </summary>
	[Serializable]
	public class Json_Hearthstone_Metadata_SpellSchool : Object_JSON
	{
		// {{JSON_START}}
		public string slug;
		public int id;
		public LocalizedString name;
		// {{JSON_END}}
	}
}