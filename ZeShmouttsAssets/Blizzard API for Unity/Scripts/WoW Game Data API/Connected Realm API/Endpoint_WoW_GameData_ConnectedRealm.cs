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
			/// Coroutine that retrieves a WoW connected realm.
			/// </summary>
			/// <param name="connectedRealmId">The ID of the connected realm.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetConnectedRealm(int connectedRealmId, Action<WowConnectedRealm_JSON> action_Result, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/connected-realm/{0}", connectedRealmId);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft connected realms.
	/// </summary>
	[Serializable]
	public class WowConnectedRealm_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public bool has_queue;
		public TypeNameStruct status;
		public TypeNameStruct population;
		public WowRealm_JSON[] realms;

		public HRefStruct mythic_leaderboards;
		public HRefStruct auctions;
	}
}