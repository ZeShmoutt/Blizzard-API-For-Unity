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
			/// Coroutine that retrieves a WoW quest category by ID.
			/// </summary>
			/// <param name="questCategoryId">The ID of the quest category.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetQuestCategory(int questCategoryId, Action<WowQuestCategory_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format("/data/wow/quest/category/{0}", questCategoryId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft quest categories.
	/// </summary>
	[Serializable]
	public class WowQuestCategory_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString category;
		public RefNameIdStruct[] quests;
	}
}