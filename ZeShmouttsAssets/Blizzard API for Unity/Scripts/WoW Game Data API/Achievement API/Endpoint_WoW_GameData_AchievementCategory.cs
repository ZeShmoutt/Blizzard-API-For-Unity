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
			/// <summary>
			/// Coroutine that retrieves a WoW achievement category.
			/// </summary>
			/// <param name="achievementCategoryId">The ID of the achievement category.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetAchievementCategory(int achievementCategoryId, Action<WowAchievementCategory_JSON> action_Result, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/achievement-category/{0}", achievementCategoryId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft achievement categories.
	/// </summary>
	[Serializable]
	public class WowAchievementCategory_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefNameIdStruct[] achievements;
		public RefNameIdStruct[] subcategories;
		public bool is_guild_category;

		[Serializable]
		public struct PointsTotal
		{
			public int quantity;
			public int points;
		}
		[Serializable]
		public struct AggregatesByFaction
		{
			public PointsTotal alliance;
			public PointsTotal horde;
		}
		public AggregatesByFaction aggregates_by_faction;

		public int display_order;
	}
}