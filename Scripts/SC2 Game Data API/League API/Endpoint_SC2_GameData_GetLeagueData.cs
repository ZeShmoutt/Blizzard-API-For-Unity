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
		/// API endpoints related to StarCraft II game data.
		/// Reference : https://develop.battle.net/documentation/starcraft-2/game-data-apis
		/// </summary>
		public static partial class SC2GameData
		{
			public enum Queue
			{
				WoL_1v1 = 1,
				WoL_2v2 = 2,
				WoL_3v3 = 3,
				WoL_4v4 = 4,
				HotS_1v1 = 101,
				HotS_2v2 = 102,
				HotS_3v3 = 103,
				HotS_4v4 = 104,
				LotV_1v1 = 201,
				LotV_2v2 = 202,
				LotV_3v3 = 203,
				LotV_4v4 = 204,
				LotV_Archon = 206
			}

			public enum TeamType
			{
				Arranged = 0,
				Random = 1
			}

			public enum League
			{
				Bronze = 0,
				Silver = 1,
				Gold = 2,
				Platinum = 3,
				Diamond = 4,
				Master = 5,
				Grandmaster = 6
			}

			internal const string apiPath_LeagueData = "/data/sc2/league/{0}/{1}/{2}/{3}";

			/// <summary>
			/// Coroutine that retrieves data for the specified season, queue, team, and league.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="seasonId">The season ID of the data to retrieve.</param>
			/// <param name="queue">The queue ID of the data to retrieve.</param>
			/// <param name="teamType">The team type of the data to retrieve.</param>
			/// <param name="league">The league ID of the data to retrieve.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetLeagueData(BattleNetRegion region, int seasonId, Queue queue, TeamType teamType, League league, Action<Json_SC2_LeagueData> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string url = string.Concat(UrlDomain(region), string.Format(apiPath_LeagueData, seasonId, (int)queue, (int)teamType, (int)league));
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves data for the specified season, queue, team, and league, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="seasonId">The season ID of the data to retrieve.</param>
			/// <param name="queue">The queue ID of the data to retrieve.</param>
			/// <param name="teamType">The team type of the data to retrieve.</param>
			/// <param name="league">The league ID of the data to retrieve.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetLeagueDataRaw(BattleNetRegion region, int seasonId, Queue queue, TeamType teamType, League league, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string url = string.Concat(UrlDomain(region), string.Format(apiPath_LeagueData, seasonId, (int)queue, (int)teamType, (int)league));
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for StarCraft II, representing data about a league.
	/// </summary>
	[Serializable]
	public class Json_SC2_LeagueData : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		[Serializable]
		public struct DataKey
		{
			public int league_id;
			public int season_id;
			public int queue_id;
			public int team_type;
		}
		public DataKey key;

		[Serializable]
		public struct DataTier
		{
			public int id;
			public DataDivision[] division;
		}

		[Serializable]
		public struct DataDivision
		{
			public int id;
			public int ladder_id;
			public int member_count;
		}
		public DataTier[] tier;

		// {{JSON_END}}
	}
}