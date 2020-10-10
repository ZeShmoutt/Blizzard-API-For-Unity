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
		/// API endpoints related to Diablo III game data.
		/// Reference : https://develop.battle.net/documentation/diablo-3/game-data-apis
		/// </summary>
		public static partial class D3GameData
		{
			internal const string API_PATH_ERALEADERBOARD = BASEPATH_D3_GAMEDATA + "/era/{0}/leaderboard/{1}";

			/// <summary>
			/// Coroutine that retrieves the specified leaderboard for the specified season.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="leaderboard">The leaderboard to retrieve.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetEraLeaderboard(int seasonId, string leaderboard, Action<Json_D3_EraLeaderboard> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_ERALEADERBOARD, seasonId, leaderboard);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves the specified leaderboard for the specified season, as a raw JSON string.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="leaderboard">The leaderboard to retrieve.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetEraLeaderboardRaw(int seasonId, string leaderboard, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_ERALEADERBOARD, seasonId, leaderboard);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Diablo III, representing a leaderboard for an era.
	/// </summary>
	[Serializable]
	public class Json_D3_EraLeaderboard : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		[Serializable]
		public struct Data
		{
			public string id;
			public int number;
			public long timestamp;
			public string @string;
		}

		[Serializable]
		public struct Player
		{
			public string key;
			public int accountId;
			public Data[] data;
		}

		[Serializable]
		public struct Row
		{
			public Player player;
			public int order;
			public Data[] data;
		}
		public Row[] row;

		public string key;
		public LocalizedString title;

		[Serializable]
		public struct Column
		{
			public string id;
			public bool hidden;
			public int order;
			public LocalizedString label;
			public string type;
		}
		public Column[] column;

		public bool achievement_points;
		public bool hardcore;
		public bool greater_rift;
		public string greater_rift_solo_class;
		public int greater_rift_team_size;
		public string last_update_time;
		public string generated_by;
		public int era;
		// {{JSON_END}}
	}
}