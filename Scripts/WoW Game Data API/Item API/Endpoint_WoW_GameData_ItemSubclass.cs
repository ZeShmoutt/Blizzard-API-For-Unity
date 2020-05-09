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
			internal const string apiPath_ItemSubclass = basePath_Wow_gameData + "/item-class/{0}/item-subclass/{1}";

			/// <summary>
			/// Coroutine that retrieves an item subclass by ID.
			/// </summary>
			/// <param name="itemClassId">The ID of the item class.</param>
			/// <param name="itemSubclassId">The ID of the item subclass.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetItemSubclass(int itemClassId, int itemSubclassId, Action<Json_Wow_ItemSubclass> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_ItemSubclass, itemClassId, itemSubclassId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves an item subclass by ID, as a raw JSON string.
			/// </summary>
			/// <param name="itemClassId">The ID of the item class.</param>
			/// <param name="itemSubclassId">The ID of the item subclass.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetItemSubclassRaw(int itemClassId, int itemSubclassId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_ItemSubclass, itemClassId, itemSubclassId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing an item subclass.
	/// </summary>
	[Serializable]
	public class Json_Wow_ItemSubclass : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int class_id;
		public int subclass_id;
		public LocalizedString display_name;
		public bool hide_subclass_in_tooltips;
		// {{JSON_END}}
	}
}