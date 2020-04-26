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
			/// Coroutine that retrieves a WoW weekly Mythic Keystone leaderboard by period.
			/// </summary>
			/// <param name="connectedRealmId">The ID of the connected realm.</param>
			/// <param name="dungeonId">The ID of the dungeon.</param>
			/// <param name="period">The unique identifier for the leaderboard period.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMythicKeystoneLeaderboard(int connectedRealmId, int dungeonId, int period, Action<WowMythicKeystoneLeaderboard_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/connected-realm/{0}/mythic-leaderboard/{1}/period/{2}", connectedRealmId, dungeonId, period);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft weekly Mythic Keystone leaderboard.
	/// </summary>
	[Serializable]
	public class WowMythicKeystoneLeaderboard_JSON : Object_Json
	{
		public LinkStruct _links;

		public NameIdStruct map;
		public int period;
		public long period_start_timestamp;
		public long period_end_timestamp;
		public HRefStruct connected_realm;

		[Serializable]
		public struct KeystoneGroupMember
		{
			public ProfileStruct profile;
			public TypeStruct faction;
			public RefIdStruct specialization;
		}

		[Serializable]
		public struct KeystoneGroup
		{
			public int ranking;
			public long duration;
			public long completed_timestamp;
			public int keystone_level;
			public KeystoneGroupMember[] members;
		}
		public KeystoneGroup[] leading_groups;

		[Serializable]
		public struct KeystoneAffix
		{
			public RefNameIdStruct keystone_affix;
			public int starting_level;
		}
		public KeystoneAffix[] keystone_affixes;

		public int map_challenge_mode_id;
		public LocalizedString name;
	}
}