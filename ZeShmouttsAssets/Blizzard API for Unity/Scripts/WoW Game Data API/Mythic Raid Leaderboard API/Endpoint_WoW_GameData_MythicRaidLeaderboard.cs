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
			/// Coroutine that retrieves a WoW Mythic Raid leaderboard for a given raid and faction.
			/// </summary>
			/// <param name="raid">The raid for a leaderboard.</param>
			/// <param name="faction">Player faction ("alliance" or "horde").</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMythicRaidLeaderboard(string raid, string faction, Action<WowMythicRaidLeaderboard_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/leaderboard/hall-of-fame/{0}/{1}", raid, faction);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft Mythic Raid leaderboards.
	/// </summary>
	[Serializable]
	public class WowMythicRaidLeaderboard_JSON : Object_Json
	{
		public LinkStruct _links;

		public string slug;
		public string criteria_type;
		public RefNameStruct zone;

		[Serializable]
		public struct LeaderboardEntryGuild
		{
			public string name;
			public int id;
			public RealmStruct realm;
		}

		[Serializable]
		public struct LeaderboardEntry
		{
			public LeaderboardEntryGuild guild;
			public TypeStruct faction;
			public long timestamp;
			public string region;
			public int rank;
		}
		public LeaderboardEntry[] entries;
	}
}