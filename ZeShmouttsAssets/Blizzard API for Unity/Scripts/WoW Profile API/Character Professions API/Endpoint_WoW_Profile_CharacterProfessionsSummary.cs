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
		/// API endpoints related to World of Warcraft profile data (characters, account, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/profile-apis
		/// </summary>
		public static partial class WowProfile
		{
			/// <summary>
			/// Coroutine that retrieves a summary of a WoW character's professions.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterProfessionsSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMediaSummary_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/professions");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's professions.
	/// </summary>
	[Serializable]
	public class WowCharacterProfessionsSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		[Serializable]
		public struct Profession
		{
			public RefNameIdStruct profession;
			public ProfessionTier[] tiers;
		}

		[Serializable]
		public struct ProfessionTier
		{
			public int skill_points;
			public int max_skill_points;
			public ProfessionTierNameId tier;

			public RefNameIdStruct[] known_recipes;
		}

		[Serializable]
		public struct ProfessionTierNameId
		{
			public string name;
			public int id;
		}

		public Profession[] primaries;
		public Profession[] secondaries;
	}
}