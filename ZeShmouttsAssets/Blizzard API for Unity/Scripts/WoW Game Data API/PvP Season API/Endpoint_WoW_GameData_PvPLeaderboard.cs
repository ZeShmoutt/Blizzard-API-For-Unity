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
			/// Coroutine that retrieves a WoW PvP leaderboard of a specific PvP bracket for a PvP season.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="pvpSeasonId">The ID of the PvP season.</param>
			/// <param name="pvpBracket">The PvP bracket type ('2v2', '3v3', or 'rbg').</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetPvPLeaderboard(BattleNetRegion region, int pvpSeasonId, string pvpBracket, Action<WowPvPLeaderboard_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Format("/data/wow/pvp-season/{0}/pvp-leaderboard/{1}", pvpSeasonId, pvpBracket);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft PvP leaderboards.
	/// </summary>
	[Serializable]
	public class WowPvPLeaderboard_JSON : Object_Json
	{
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
	}
}