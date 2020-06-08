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
			internal const string apiPath_WoWTokenIndex = basePath_Wow_gameData + "/token/index";

			/// <summary>
			/// Coroutine that retrieves the WoW Token index. In Classic, this is only available for China.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetWoWTokenIndex(Action<Json_WowClassic_WoWTokenIndex> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = apiPath_WoWTokenIndex;
				yield return SendRequest(BattleNetRegion.China, namespaceClassicDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves the WoW Token index, as a raw JSON string. In Classic, this is only available for China.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetWoWTokenIndexRaw(Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = apiPath_WoWTokenIndex;
				yield return SendRequest(BattleNetRegion.China, namespaceClassicDynamic, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft (Classic), representing a WoW Token index.
	/// </summary>
	[Serializable]
	public class Json_WowClassic_WoWTokenIndex : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public long last_updated_timestamp;
		public long price;
		// {{JSON_END}}
	}
}