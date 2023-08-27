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
		/// API endpoints related to World of Warcraft game data (items, spells, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/game-data-apis
		/// </summary>
		public static partial class WowGameData
		{
			internal const string API_PATH_ACHIEVEMENT = BASEPATH_WOW_GAMEDATA + "/achievement/{0}";

			/// <summary>
			/// Coroutine that retrieves an achievement by ID.
			/// </summary>
			/// <param name="achievementId">The ID of the achievement.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetAchievement(int achievementId, Action<Json_Wow_Achievement> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_ACHIEVEMENT, achievementId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves an achievement by ID, as a raw JSON string.
			/// </summary>
			/// <param name="achievementId">The ID of the achievement.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetAchievementRaw(int achievementId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_ACHIEVEMENT, achievementId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing an achievement.
	/// </summary>
	[Serializable]
	public class Json_Wow_Achievement : Object_JSON
	{
		// {{JSON_START}}
		// Note : missing some stuff. Check with meta-achievements to see whats missing (e.g. "The Loremaster" id:7520).

		public LinkStruct _links;

		public int id;
		public KeyNameIdStruct category;
		public LocalizedString name;
		public LocalizedString description;
		public int points;
		public bool is_account_wide;

		[Serializable]
		public struct CriteriaStruct
		{
			public HRefStruct key;
			public int id;
			public LocalizedString description;
			public int amount;
		}
		public CriteriaStruct criteria;
		public KeyNameIdStruct next_achievement;
		public KeyIdStruct media;

		public int display_order;
		[Serializable]
		public struct AchievementRequirements
		{
			public TypeNameStruct faction;
		}
		public AchievementRequirements requirements;
		
		// {{JSON_END}}
	}
}