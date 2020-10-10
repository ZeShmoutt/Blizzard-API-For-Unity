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
		/// API endpoints related to World of Warcraft profile data (characters, account, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/profile-apis
		/// </summary>
		public static partial class WowProfile
		{
			internal const string API_PATH_CHARACTERSTATISTICSSUMMARY = "/statistics";

			/// <summary>
			/// Coroutine that retrieves a statistics summary for a character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterStatisticsSummary(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterStatisticsSummary> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + API_PATH_CHARACTERSTATISTICSSUMMARY;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a statistics summary for a character, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterStatisticsSummaryRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + API_PATH_CHARACTERSTATISTICSSUMMARY;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a statistics summary for a character.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterStatisticsSummary : Object_JSON
	{
		// {{JSON_START}}
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
		// {{JSON_END}}
	}
}