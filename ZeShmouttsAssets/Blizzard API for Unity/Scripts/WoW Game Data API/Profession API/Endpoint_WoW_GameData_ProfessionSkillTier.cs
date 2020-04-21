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
			/// Coroutine that retrieves a WoW profession skill tier.
			/// </summary>
			/// <param name="professionId">The ID of the profession.</param>
			/// <param name="skillTierId">The ID of the skill tier.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetProfessionSkillTier(int professionId, int skillTierId, Action<WowProfessionSkillTier_JSON> action_Result, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/profession/{0}/skill-tier/{1}", professionId, skillTierId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft profession skill tier.
	/// </summary>
	[Serializable]
	public class WowProfessionSkillTier_JSON : Object_Json
	{
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
	}
}