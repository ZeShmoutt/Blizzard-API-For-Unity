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
			internal const string API_PATH_SEASON = BASEPATH_D3_GAMEDATA + "/season/{0}";

			/// <summary>
			/// Coroutine that retrieves a leaderboard list for the specified season.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetSeason(int seasonId, Action<Json_D3_Season> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_SEASON, seasonId);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a leaderboard list for the specified season, as a raw JSON string.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetSeasonRaw(int seasonId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_SEASON, seasonId);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Diablo III, representing a leaderboard list for a season.
	/// </summary>
	[Serializable]
	public class Json_D3_Season : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		[Serializable]
		public struct Leaderboard
		{
			public int team_size;
			public HRefStruct ladder;
			public bool hardcore;
			public string hero_class_string;
		}
		public Leaderboard[] leaderboard;

		public int season_id;
		public string last_update_time;
		public string generated_by;
		// {{JSON_END}}
	}
}