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
			internal const string apiPath_PlayableClass = basePath_Wow_gameData + "/playable-class/{0}";

			/// <summary>
			/// Coroutine that retrieves a playable class by ID.
			/// </summary>
			/// <param name="classId">The ID of the playable class.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPlayableClass(int classId, Action<Json_WowClassic_PlayableClass> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_PlayableClass, classId);
				yield return SendRequest(region, namespaceClassicStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a playable class by ID, as a raw JSON string.
			/// </summary>
			/// <param name="classId">The ID of the playable class.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPlayableClassRaw(int classId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_PlayableClass, classId);
				yield return SendRequest(region, namespaceClassicStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft (Classic), representing a playable class.
	/// </summary>
	[Serializable]
	public class Json_WowClassic_PlayableClass : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public LocalizedString name;

		public GenderedLocalizedString gender_name;

		public RefNameIdStruct power_type;

		public RefIdStruct media;
		// {{JSON_END}}
	}
}