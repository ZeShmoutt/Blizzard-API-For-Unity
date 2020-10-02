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
			internal const string apiPath_ProfessionSkillTier = BASEPATH_WOW_GAMEDATA + "/profession/{0}/skill-tier/{1}";

			/// <summary>
			/// Coroutine that retrieves a skill tier for a profession by ID.
			/// </summary>
			/// <param name="professionId">The ID of the profession.</param>
			/// <param name="skillTierId">The ID of the skill tier.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetProfessionSkillTier(int professionId, int skillTierId, Action<Json_Wow_ProfessionSkillTier> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(apiPath_ProfessionSkillTier, professionId, skillTierId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a skill tier for a profession by ID, as a raw JSON string.
			/// </summary>
			/// <param name="professionId">The ID of the profession.</param>
			/// <param name="skillTierId">The ID of the skill tier.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetProfessionSkillTierRaw(int professionId, int skillTierId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(apiPath_ProfessionSkillTier, professionId, skillTierId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a skill tier for a profession.
	/// </summary>
	[Serializable]
	public class Json_Wow_ProfessionSkillTier : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public int minimum_skill_level;
		public int maximum_skill_level;

		[Serializable]
		public struct ProfessionSkillTierCategory
		{
			public LocalizedString name;
			public RefNameIdStruct[] recipes;
		}
		public ProfessionSkillTierCategory[] categories;
		// {{JSON_END}}
	}
}