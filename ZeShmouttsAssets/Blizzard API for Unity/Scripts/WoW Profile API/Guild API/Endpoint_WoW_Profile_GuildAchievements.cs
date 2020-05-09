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
						/// <summary>
			/// Coroutine that retrieves a single guild's achievements by name and realm.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildAchievements(BattleNetRegion region, string realmSlug, string nameSlug, Action<Json_Wow_GuildAchievements> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowGuildEndpointPath(realmSlug, nameSlug) + "/achievements";
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a single guild's achievements by name and realm, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildAchievementsRaw(BattleNetRegion region, string realmSlug, string nameSlug, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowGuildEndpointPath(realmSlug, nameSlug) + "/achievements";
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a guild's achievements.
	/// </summary>
	[Serializable]
	public class Json_Wow_GuildAchievements : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public GuildStruct guild;
		public int total_quantity;
		public int total_points;

		[Serializable]
		public struct GuildAchievementCriteria
		{
			public int id;
			public int amount;
			public bool is_completed;
			public GuildAchievementCriteria[] child_criteria;
		}

		[Serializable]
		public struct GuildAchievement
		{
			public int id;
			public RefStringIdStruct achievement;
			public GuildAchievementCriteria criteria;
			public long completed_timestamp;
		}
		public GuildAchievement[] achievements;

		[Serializable]
		public struct GuildAchievementCategoryProgress
		{
			public RefStringIdStruct category;
			public int quantity;
			public int points;
		}
		public string[] category_progress;

		[Serializable]
		public struct GuildRecentEvents
		{
			public RefStringIdStruct achievement;
			public long timestamp;
		}
		public GuildRecentEvents[] recent_events;
		// {{JSON_END}}
	}
}