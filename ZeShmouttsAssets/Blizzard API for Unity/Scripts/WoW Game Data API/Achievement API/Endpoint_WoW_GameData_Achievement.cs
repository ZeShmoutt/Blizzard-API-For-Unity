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
			/// Coroutine that retrieves a WoW achievement.
			/// </summary>
			/// <param name="achievementId">The ID of the achievement.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetAchievement(int achievementId, Action<WoWAchievement_JSON> action_Result, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/achievement/{0}", achievementId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft achievements.
	/// </summary>
	[Serializable]
	public class WoWAchievement_JSON : Object_Json
	{
		// Note : missing some stuff. Check with meta-achievements to see whats missing (e.g. "The Loremaster" id:7520).

		public LinkStruct _links;

		public int id;
		public RefNameIdStruct category;
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
		public RefNameIdStruct next_achievement;
		public RefIdStruct media;

		public int display_order;
	}
}