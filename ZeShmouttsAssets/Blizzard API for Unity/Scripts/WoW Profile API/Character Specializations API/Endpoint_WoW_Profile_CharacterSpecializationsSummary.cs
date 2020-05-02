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
			/// Coroutine that retrieves a summary of a WoW character's specializations.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterSpecializationsSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterSpecializationsSummary_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/specializations");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's specializations.
	/// </summary>
	[Serializable]
	public class WowCharacterSpecializationsSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		[Serializable]
		public struct SpellTooltip
		{
			public RefNameIdStruct spell;
			public LocalizedString description;
			public LocalizedString cast_time;
			public LocalizedString power_cost;
			public LocalizedString range;
			public LocalizedString cooldown;
		}

		[Serializable]
		public struct SpecializationPvPTalent
		{
			public RefNameIdStruct talent;
			public SpellTooltip spell_tooltip;
		}

		[Serializable]
		public struct SpecializationPvPTalentSlot
		{
			public SpecializationPvPTalent selected;
			public int slot_number;
		}

		[Serializable]
		public struct SpecializationTalent
		{
			public RefNameIdStruct talent;
			public SpellTooltip spell_tooltip;
			public int tier_index;
			public int column_index;
		}

		[Serializable]
		public struct Specialization
		{
			public RefNameIdStruct specialization;
			public SpecializationTalent[] talents;
			public SpecializationPvPTalentSlot[] pvp_talent_slots;
		}
		public Specialization[] specializations;
		public RefNameIdStruct active_specialization;

		public CharacterStruct character;
	}
}