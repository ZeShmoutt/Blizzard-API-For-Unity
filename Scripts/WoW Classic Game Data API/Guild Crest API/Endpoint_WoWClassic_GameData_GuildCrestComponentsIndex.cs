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
			internal const string apiPath_GuildCrestComponentsIndex = BASEPATH_WOW_GAMEDATA + "/guild-crest/index";

			/// <summary>
			/// Coroutine that retrieves an index of guild crest media.
			/// </summary>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildCrestComponentsIndex(Action<Json_WowClassic_GuildCrestComponentsIndex> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = apiPath_GuildCrestComponentsIndex;
				yield return SendRequest(region, NAMESPACE_CLASSIC_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves an index of guild crest media, as a raw JSON string.
			/// </summary>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildCrestComponentsIndexRaw(Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = apiPath_GuildCrestComponentsIndex;
				yield return SendRequest(region, NAMESPACE_CLASSIC_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft (Classic), representing an index of guild crest media.
	/// </summary>
	[Serializable]
	public class Json_WowClassic_GuildCrestComponentsIndex : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		[Serializable]
		public struct GuildCrestEmblem
		{
			public int id;
			public RefIdStruct media;
		}

		public GuildCrestEmblem[] emblems;
		// {{JSON_END}}
	}
}