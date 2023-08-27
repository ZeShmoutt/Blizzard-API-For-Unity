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
			internal const string API_PATH_CHARACTERMYTHICKEYSTONEPROFILEINDEX = "/mythic-keystone-profile";

			/// <summary>
			/// Coroutine that retrieves the Mythic Keystone profile index for a character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterMythicKeystoneProfileIndex(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterMythicKeystoneProfileIndex> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + API_PATH_CHARACTERMYTHICKEYSTONEPROFILEINDEX;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves the Mythic Keystone profile index for a character, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterMythicKeystoneProfileIndexRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + API_PATH_CHARACTERMYTHICKEYSTONEPROFILEINDEX;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing the Mythic Keystone profile index for a character.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterMythicKeystoneProfileIndex : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		[Serializable]
		public struct MythicDungeonRunCharacter
		{
			public CharacterStruct character;
			public KeyNameIdStruct specialization;
			public KeyNameIdStruct race;
			public int equipped_item_level;
		}

		[Serializable]
		public struct MythicSeasonBestRun
		{
			public long completed_timestamp;
			public long duration;
			public int keystone_level;
			public KeyNameIdStruct[] keystone_affixes;
			public MythicDungeonRunCharacter[] members;
			public KeyNameIdStruct dungeon;
			public bool is_completed_within_time;
		}

		[Serializable]
		public struct MythicSeasonPeriod
		{
			public KeyIdStruct period;
			public MythicSeasonBestRun[] best_runs;
		}
		public MythicSeasonPeriod current_period;

		public KeyIdStruct[] seasons;
		public CharacterStruct character;
		// {{JSON_END}}
	}
}