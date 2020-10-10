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
			internal const string API_PATH_PLAYABLESPECIALIZATION = BASEPATH_WOW_GAMEDATA + "/playable-specialization/{0}";

			/// <summary>
			/// Coroutine that retrieves a playable specialization by ID.
			/// </summary>
			/// <param name="specId">The ID of the playable specialization.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPlayableSpecialization(int specId, Action<Json_Wow_PlayableSpecialization> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_PLAYABLESPECIALIZATION, specId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a playable specialization by ID, as a raw JSON string.
			/// </summary>
			/// <param name="specId">The ID of the playable specialization.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPlayableSpecializationRaw(int specId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_PLAYABLESPECIALIZATION, specId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a playable specialization.
	/// </summary>
	[Serializable]
	public class Json_Wow_PlayableSpecialization : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public RefNameIdStruct playable_class;
		public LocalizedString name;
		public GenderedLocalizedString gender_description;
		public RefIdStruct media;
		public TypeNameStruct role;

		[Serializable]
		public struct SpellTooltip
		{
			public LocalizedString description;
			public LocalizedString cast_time;
			public LocalizedString power_cost;
			public LocalizedString range;
			public LocalizedString cooldown;
		}

		[Serializable]
		public struct Talent
		{
			public RefNameIdStruct talent;
			public SpellTooltip spell_tooltip;
			public int column_index;
		}

		[Serializable]
		public struct TalentTier
		{
			public int level;
			public Talent[] talents;
			public int tier_index;
		}
		public TalentTier[] talent_tiers;

		[Serializable]
		public struct PvpTalent
		{
			public RefNameIdStruct talent;
			public SpellTooltip spell_tooltip;
		}
		public PvpTalent[] pvp_talents;
		// {{JSON_END}}
	}
}