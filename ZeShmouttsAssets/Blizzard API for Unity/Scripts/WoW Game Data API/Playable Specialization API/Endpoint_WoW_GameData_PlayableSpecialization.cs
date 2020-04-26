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
			/// Coroutine that retrieves a WoW playable specialization.
			/// </summary>
			/// <param name="specId">The ID of the playable specialization.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetPlayableSpecialization(int specId, Action<WowPlayableSpecialization_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format("/data/wow/playable-specialization/{0}", specId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft playable specializations.
	/// </summary>
	[Serializable]
	public class WowPlayableSpecialization_JSON : Object_Json
	{
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
	}
}