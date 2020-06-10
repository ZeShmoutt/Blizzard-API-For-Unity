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
		/// API endpoints related to World of Warcraft Classic game data (items, spells, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft-classic/game-data-apis
		/// </summary>
		public static partial class WowClassicGameData
		{
			internal const string apiPath_ConnectedRealm = basePath_Wow_gameData + "/connected-realm/{0}";

			/// <summary>
			/// Coroutine that retrieves a connected realm by ID.
			/// </summary>
			/// <param name="connectedRealmId">The ID of the connected realm.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetConnectedRealm(int connectedRealmId, Action<Json_WowClassic_ConnectedRealm> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_ConnectedRealm, connectedRealmId);
				yield return SendRequest(region, namespaceClassicDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a connected realm by ID, as a raw JSON string.
			/// </summary>
			/// <param name="connectedRealmId">The ID of the connected realm.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetConnectedRealmRaw(int connectedRealmId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_ConnectedRealm, connectedRealmId);
				yield return SendRequest(region, namespaceClassicDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft (Classic), representing a connected realm.
	/// </summary>
	[Serializable]
	public class Json_WowClassic_ConnectedRealm : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public bool has_queue;
		public TypeNameStruct status;
		public TypeNameStruct population;
		public Json_WowClassic_Realm[] realms;
		// {{JSON_END}}
	}
}