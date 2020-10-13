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
			internal const string API_PATH_CREATUREFAMILYMEDIA = BASEPATH_WOW_GAMEDATA + "/media/creature-family/{0}";

			/// <summary>
			/// Coroutine that retrieves media for a creature family by ID.
			/// </summary>
			/// <param name="creatureFamilyId">The ID of the creature family.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetCreatureFamilyMedia(int creatureFamilyId, Action<Json_WowClassic_CreatureFamilyMedia> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_CREATUREFAMILYMEDIA, creatureFamilyId);
				yield return SendRequest(region, NAMESPACE_CLASSIC_STATIC, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves media for a creature family by ID, as a raw JSON string.
			/// </summary>
			/// <param name="creatureFamilyId">The ID of the creature family.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetCreatureFamilyMediaRaw(int creatureFamilyId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_CREATUREFAMILYMEDIA, creatureFamilyId);
				yield return SendRequest(region, NAMESPACE_CLASSIC_STATIC, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft (Classic), representing media for a creature family.
	/// </summary>
	[Serializable]
	public class Json_WowClassic_CreatureFamilyMedia : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public KeyValueStruct[] assets;
		public int id;
		// {{JSON_END}}
	}
}