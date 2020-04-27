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
			/// Coroutine that retrieves a WoW PvP season.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPSeason(int pvpSeasonId, Action<WowPvPSeason_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format("/data/wow/pvp-season/{0}", pvpSeasonId);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft PvP seasons.
	/// </summary>
	[Serializable]
	public class WowPvPSeason_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public HRefStruct leaderboards;
		public HRefStruct rewards;
		public long season_start_timestamp;
		public long season_end_timestamp;
	}
}