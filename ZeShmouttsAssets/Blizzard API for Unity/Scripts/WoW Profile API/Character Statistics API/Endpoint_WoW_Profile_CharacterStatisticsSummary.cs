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
			/// Coroutine that retrieves a summary of a WoW character's statistics.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterStatisticsSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterStatisticsSummary_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/statistics");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's statistics.
	/// </summary>
	[Serializable]
	public class WowCharacterStatisticsSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		[Serializable]
		public struct StatisticMain
		{
			public int @base;
			public int effective;
		}

		[Serializable]
		public struct StatisticSecondary
		{
			public int rating;
			public float rating_bonus;
			public float value;
		}

		public int health;
		public int power;
		public RefNameIdStruct power_type;
		public StatisticSecondary speed;
		public StatisticMain strength;
		public StatisticMain agility;
		public StatisticMain intellect;
		public StatisticMain stamina;
		public StatisticSecondary melee_crit;
		public StatisticSecondary melee_haste;
		public StatisticSecondary mastery;
		public int bonus_armor;
		public StatisticSecondary lifesteal;
		public int versatility;
		public float versatility_damage_done_bonus;
		public float versatility_healing_done_bonus;
		public float versatility_damage_taken_bonus;
		public StatisticSecondary avoidance;
		public int attack_power;
		public float main_hand_damage_min;
		public float main_hand_damage_max;
		public float main_hand_speed;
		public float main_hand_dps;
		public float off_hand_damage_min;
		public float off_hand_damage_max;
		public float off_hand_speed;
		public float off_hand_dps;
		public int spell_power;
		public int spell_penetration;
		public StatisticSecondary spell_crit;
		public int mana_regen;
		public int mana_regen_combat;
		public StatisticMain armor;
		public StatisticSecondary dodge;
		public StatisticSecondary parry;
		public StatisticSecondary block;
		public StatisticSecondary ranged_crit;
		public StatisticSecondary ranged_haste;
		public StatisticSecondary spell_haste;

		public CharacterStruct character;

		[Serializable]
		public struct StatisticCorruption
		{
			public int corruption;
			public int corruption_resistance;
			public int effective_corruption;
		}
		public StatisticCorruption corruption;
	}
}