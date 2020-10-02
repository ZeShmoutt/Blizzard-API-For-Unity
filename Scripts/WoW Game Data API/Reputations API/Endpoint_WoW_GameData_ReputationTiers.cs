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
			internal const string apiPath_ReputationTiers = BASEPATH_WOW_GAMEDATA + "/reputation-tiers/{0}";

			/// <summary>
			/// Coroutine that retrieves a single set of reputation tiers by ID.
			/// </summary>
			/// <param name="reputationTiersId">The ID of the set of reputation tiers.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetReputationTiers(int reputationTiersId, Action<Json_Wow_ReputationTiers> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(apiPath_ReputationTiers, reputationTiersId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a single set of reputation tiers by ID, as a raw JSON string.
			/// </summary>
			/// <param name="reputationTiersId">The ID of the set of reputation tiers.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetReputationTiersRaw(int reputationTiersId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(apiPath_ReputationTiers, reputationTiersId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a set of reputation tiers.
	/// </summary>
	[Serializable]
	public class Json_Wow_ReputationTiers : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;

		[Serializable]
		public struct ReputationTier
		{
			public LocalizedString name;
			public int min_value;
			public int max_value;
			public int id;
		}
		public ReputationTier[] tiers;
		public RefNameIdStruct faction;
		// {{JSON_END}}
	}
}