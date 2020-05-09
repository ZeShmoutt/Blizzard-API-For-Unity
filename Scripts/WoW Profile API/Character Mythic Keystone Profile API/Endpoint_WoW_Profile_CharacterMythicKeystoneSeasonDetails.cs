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
						/// <summary>
			/// Coroutine that retrieves the Mythic Keystone season details for a character.\n                        /// Returns a 404 Not Found for characters that have not yet completed a Mythic Keystone dungeon for the specified season.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="seasonId">The ID of the Mythic Keystone season.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterMythicKeystoneSeasonDetails(BattleNetRegion region, string realmSlug, string characterName, int seasonId, Action<Json_Wow_CharacterMythicKeystoneSeasonDetails> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + string.Format("/mythic-keystone-profile/season/{0}", seasonId);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves the Mythic Keystone season details for a character.\n                        /// Returns a 404 Not Found for characters that have not yet completed a Mythic Keystone dungeon for the specified season, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="seasonId">The ID of the Mythic Keystone season.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterMythicKeystoneSeasonDetailsRaw(BattleNetRegion region, string realmSlug, string characterName, int seasonId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + string.Format("/mythic-keystone-profile/season/{0}", seasonId);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing the Mythic Keystone season details for a character.\n                        /// Returns a 404 Not Found for characters that have not yet completed a Mythic Keystone dungeon for the specified season.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterMythicKeystoneSeasonDetails : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public RefIdStruct season;

		[Serializable]
		public struct MythicDungeonRunCharacter
		{
			public CharacterStruct character;
			public RefNameIdStruct specialization;
			public RefNameIdStruct race;
			public int equipped_item_level;
		}

		[Serializable]
		public struct MythicSeasonBestRun
		{
			public long completed_timestamp;
			public long duration;
			public int keystone_level;
			public RefNameIdStruct[] keystone_affixes;
			public MythicDungeonRunCharacter[] members;
			public RefNameIdStruct dungeon;
			public bool is_completed_within_time;
		}
		public MythicSeasonBestRun[] best_runs;

		public CharacterStruct character;
		// {{JSON_END}}
	}
}