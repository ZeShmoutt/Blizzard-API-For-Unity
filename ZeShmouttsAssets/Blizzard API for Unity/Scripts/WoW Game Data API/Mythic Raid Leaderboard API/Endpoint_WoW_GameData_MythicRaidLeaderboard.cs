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
			internal const string apiPath_MythicRaidLeaderboard = basePath_Wow_gameData + "/leaderboard/hall-of-fame/{0}/{1}";

			/// <summary>
			/// Coroutine that retrieves the leaderboard for a given raid and faction.
			/// </summary>
			/// <param name="raid">The raid for a leaderboard.</param>
			/// <param name="faction">"Player faction ("alliance" or "horde")."</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMythicRaidLeaderboard(string raid, string faction, Action<Json_Wow_MythicRaidLeaderboard> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_MythicRaidLeaderboard, raid, faction);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves the leaderboard for a given raid and faction, as a raw JSON string.
			/// </summary>
			/// <param name="raid">The raid for a leaderboard.</param>
			/// <param name="faction">"Player faction ("alliance" or "horde")."</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMythicRaidLeaderboardRaw(string raid, string faction, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_MythicRaidLeaderboard, raid, faction);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a raid leaderboard.
	/// </summary>
	[Serializable]
	public class Json_Wow_MythicRaidLeaderboard : Object_JSON
	{
		// {{JSON_START}}
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
		// {{JSON_END}}
	}
}