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
			/// Coroutine that retrieves a summary of a WoW character's PvP career.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterPvPSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterPvPSummary_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/pvp-summary");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's PvP career.
	/// </summary>
	[Serializable]
	public class WowCharacterPvPSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		public HRefStruct[] brackets;
		public int honor_level;

		[Serializable]
		public struct MatchStatistics
		{
			public int played;
			public int won;
			public int lost;
		}

		[Serializable]
		public struct PvPMapStatistics
		{
			public NameIdStruct world_map;
			public MatchStatistics match_statistics;
		}
		public PvPMapStatistics[] pvp_map_statistics;

		public long honorable_kills;
		public CharacterStruct character;
	}
}