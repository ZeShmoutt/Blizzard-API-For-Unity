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
			internal const string apiPath_Era = basePath_D3_gameData + "/era/{0}";

			/// <summary>
			/// Coroutine that retrieves a leaderboard list for the specified era.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetEra(int seasonId, Action<Json_D3_Era> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_Era, seasonId);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a leaderboard list for the specified era, as a raw JSON string.
			/// </summary>
			/// <param name="seasonId">The season for the leaderboard list.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetEraRaw(int seasonId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_Era, seasonId);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Diablo III, representing a leaderboard list for an era.
	/// </summary>
	[Serializable]
	public class Json_D3_Era : Object_JSON
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

		public int era_id;
		public long era_start_date;
		public string last_update_time;
		public string generated_by;
		// {{JSON_END}}
	}
}