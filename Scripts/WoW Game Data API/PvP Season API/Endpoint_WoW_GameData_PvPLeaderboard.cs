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
			internal const string API_PATH_PVPLEADERBOARD = BASEPATH_WOW_GAMEDATA + "/pvp-season/{0}/pvp-leaderboard/{1}";

			/// <summary>
			/// Coroutine that retrieves the PvP leaderboard of a specific PvP bracket for a PvP season.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="pvpBracket">"The PvP bracket type ("2v2", "3v3", or "rbg")."</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPLeaderboard(int pvpSeasonId, string pvpBracket, Action<Json_Wow_PvPLeaderboard> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_PVPLEADERBOARD, pvpSeasonId, pvpBracket);
				yield return SendRequest(region, NAMESPACE_DYNAMIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves the PvP leaderboard of a specific PvP bracket for a PvP season, as a raw JSON string.
			/// </summary>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="pvpBracket">"The PvP bracket type ("2v2", "3v3", or "rbg")."</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPLeaderboardRaw(int pvpSeasonId, string pvpBracket, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_PVPLEADERBOARD, pvpSeasonId, pvpBracket);
				yield return SendRequest(region, NAMESPACE_DYNAMIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a PvP leaderboard.
	/// </summary>
	[Serializable]
	public class Json_Wow_PvPLeaderboard : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public RefIdStruct season;
		public string name;
		public IdTypeStruct bracket;

		[Serializable]
		public struct SeasonMatchStatistics
		{
			public int played;
			public int won;
			public int lost;
		}

		[Serializable]
		public struct PvPLeaderboardEntry
		{
			public CharacterStruct character;
			public TypeStruct faction;
			public int rank;
			public int rating;
			public SeasonMatchStatistics season_match_statistics;
			public RefIdStruct tier;
		}
		public PvPLeaderboardEntry[] entries;
		// {{JSON_END}}
	}
}