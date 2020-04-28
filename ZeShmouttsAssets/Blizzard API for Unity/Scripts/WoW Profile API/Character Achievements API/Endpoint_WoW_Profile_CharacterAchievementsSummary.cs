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
			/// Coroutine that retrieves a summary of a WoW character's achievements.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAchievementsSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterAchievementsSummary_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/achievements");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's achievements.
	/// </summary>
	[Serializable]
	public class WowCharacterAchievementsSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		public int total_quantity;
		public int total_points;

		[Serializable]
		public struct AchievementCriteria
		{
			public int id;
			public int amount;
			public bool is_completed;
			public AchievementCriteria[] child_criteria;
		}

		[Serializable]
		public struct Achievement
		{
			public int id;
			public RefStringIdStruct achievement;
			public AchievementCriteria criteria;
			public long completed_timestamp;
		}
		public Achievement[] achievements;

		[Serializable]
		public struct AchievementCategoryProgress
		{
			public RefStringIdStruct category;
			public int quantity;
			public int points;
		}
		public AchievementCategoryProgress[] category_progress;

		[Serializable]
		public struct AchievementRecentEvent
		{
			public int id;
			public RefStringIdStruct achievement;
			public long timestamp;
		}
		public AchievementRecentEvent[] recent_events;
		public CharacterStruct character;
		public HRefStruct statistics;
	}
}