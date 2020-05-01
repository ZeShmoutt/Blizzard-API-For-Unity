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
			/// Coroutine that retrieves a WoW character's Mythic Keystone profile index.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterMythicKeystoneProfileIndex(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMythicKeystoneProfileIndex_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/mythic-keystone-profile");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft character's Mythic Keystone profile index.
	/// </summary>
	[Serializable]
	public class WowCharacterMythicKeystoneProfileIndex_JSON : Object_Json
	{
		public LinkStruct _links;

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

		[Serializable]
		public struct MythicSeasonPeriod
		{
			public RefIdStruct period;
			public MythicSeasonBestRun[] best_runs;
		}
		public MythicSeasonPeriod current_period;

		public RefIdStruct[] seasons;
		public CharacterStruct character;
	}
}