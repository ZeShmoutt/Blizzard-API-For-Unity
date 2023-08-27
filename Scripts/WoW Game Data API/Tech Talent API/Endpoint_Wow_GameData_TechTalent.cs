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
			internal const string API_PATH_TECHTALENT = BASEPATH_WOW_GAMEDATA + "/tech-talent/{0}";

			/// <summary>
			/// Coroutine that retrieves a tech talent by ID.
			/// </summary>
			/// <param name="techTalentId">The ID of the tech talent;</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetTechTalent(int techTalentId, Action<Json_Wow_TechTalent> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_TECHTALENT, techTalentId);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a tech talent by ID, as a raw JSON string.
			/// </summary>
			/// <param name="techTalentId">The ID of the tech talent;</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetTechTalentRaw(int techTalentId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_TECHTALENT, techTalentId);
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a tech talent.
	/// </summary>
	[Serializable]
	public class Json_Wow_TechTalent : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public KeyNameIdStruct talent_tree;
		public LocalizedString name;
		public LocalizedString description;
		public SpellTooltipStruct spell_tooltip;
		public int tier;
		public int display_order;
		public KeyNameIdStruct prerequisite_talent;
		public KeyIdStruct media;
		// {{JSON_END}}
	}
}