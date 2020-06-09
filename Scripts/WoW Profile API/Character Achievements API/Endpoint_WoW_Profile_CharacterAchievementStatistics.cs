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
		/// API endpoints related to World of Warcraft profile data (characters, account, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/profile-apis
		/// </summary>
		public static partial class WowProfile
		{
			internal const string apiPath_CharacterAchievementStatistics = "/achievements/statistics";

			/// <summary>
			/// Coroutine that retrieves a character's statistics as they pertain to achievements.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAchievementStatistics(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterAchievementStatistics> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + apiPath_CharacterAchievementStatistics;
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a character's statistics as they pertain to achievements, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAchievementStatisticsRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + apiPath_CharacterAchievementStatistics;
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a character's statistics as they pertain to achievements.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterAchievementStatistics : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public CharacterStruct character;

		[Serializable]
		public struct Statistics
		{
			public int id;
			public LocalizedString name;
			public long last_updated_timestamp;
			public int quantity;
		}

		[Serializable]
		public struct StatisticsCategory
		{
			public int id;
			public LocalizedString name;
			public StatisticsCategory[] sub_categories;
			public Statistics[] statistics;
		}
		public StatisticsCategory[] categories;
		// {{JSON_END}}
	}
}