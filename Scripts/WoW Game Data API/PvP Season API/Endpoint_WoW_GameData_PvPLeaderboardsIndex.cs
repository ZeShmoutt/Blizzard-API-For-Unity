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
			internal const string API_PATH_PVPLEADERBOARDSINDEX = BASEPATH_WOW_GAMEDATA + "/pvp-season/{0}/pvp-leaderboard/index";

			/// <summary>
			/// Coroutine that retrieves an index of PvP leaderboards for a PvP season.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPLeaderboardsIndex(int pvpSeasonId, Action<Json_Wow_PvPLeaderboardsIndex> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_PVPLEADERBOARDSINDEX, pvpSeasonId);
				yield return SendRequest(region, NAMESPACE_DYNAMIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves an index of PvP leaderboards for a PvP season, as a raw JSON string.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPLeaderboardsIndexRaw(int pvpSeasonId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_PVPLEADERBOARDSINDEX, pvpSeasonId);
				yield return SendRequest(region, NAMESPACE_DYNAMIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing an index of PvP leaderboards.
	/// </summary>
	[Serializable]
	public class Json_Wow_PvPLeaderboardsIndex : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public RefIdStruct season;
		public RefStringIdStruct[] leaderboards;
		// {{JSON_END}}
	}
}