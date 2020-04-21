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
			/// Coroutine that retrieves a WoW realm.
			/// </summary>
			/// <param name="realmSlug">The realm's data-friendly name. Use GetRealmsIndex to get a list of realms and their slugs.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetRealm(string realmSlug, Action<WowRealm_JSON> action_Result, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/realm/{0}", realmSlug);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft realm.
	/// </summary>
	[Serializable]
	public class WowRealm_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public RefNameIdStruct region;
		public HRefStruct connected_realm;
		public LocalizedString name;
		public LocalizedString category;
		public string locale;
		public string timezone;

		[Serializable]
		public struct RealmType
		{
			public string type;
			public LocalizedString name;
		}
		public RealmType type;
		public bool is_tournament;
		public string slug;
	}
}