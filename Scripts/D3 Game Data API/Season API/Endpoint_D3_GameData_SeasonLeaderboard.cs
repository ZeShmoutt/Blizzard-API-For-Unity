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
			internal const string apiPath_SeasonLeaderboard = basePath_D3_gameData + "/season/{0}/leaderboard/{1}";

			/// <summary>
			/// Coroutine that retrieves the specified leaderboard for the specified season.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="leaderboard">The leaderboard to retrieve.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetSeasonLeaderboard(int seasonId, string leaderboard, Action<Json_D3_SeasonLeaderboard> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_SeasonLeaderboard, seasonId, leaderboard);
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
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetSeasonLeaderboardRaw(int seasonId, string leaderboard, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_SeasonLeaderboard, seasonId, leaderboard);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Diablo III, representing a leaderboard for a season.
	/// </summary>
	[Serializable]
	public class Json_D3_SeasonLeaderboard : Json_D3_Leaderboard
	{
		// {{JSON_START}}
		public bool conquest;
		public int season;
		public long conquest_id;
		public string conquest_icon_id;
		public LocalizedString conquest_name;
		public LocalizedString conquest_desc;
		// {{JSON_END}}
	}
}