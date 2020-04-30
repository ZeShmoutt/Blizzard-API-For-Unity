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
			/// Coroutine that retrieves a summary of a WoW character's completed raids.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterRaids(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterRaids_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/encounters/raids");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's completed raids.
	/// </summary>
	[Serializable]
	public class WowCharacterRaids_JSON : Object_Json
	{
		public LinkStruct _links;

		public CharacterStruct character;

		[Serializable]
		public struct RaidModeEncounter
		{
			public RefNameIdStruct encounter;
			public int completed_count;
			public long last_kill_timestamp;
		}

		[Serializable]
		public struct RaidModeProgress
		{
			public int completed_count;
			public int total_count;
			public RaidModeEncounter[] encounters;
		}

		[Serializable]
		public struct RaidMode
		{
			public TypeNameStruct difficulty;
			public TypeNameStruct status;
			public RaidModeProgress progress;
		}

		[Serializable]
		public struct Raid
		{
			public RefNameIdStruct instance;
			public RaidMode[] modes;
		}

		[Serializable]
		public struct Expansion
		{
			public RefNameIdStruct expansion;
			public Raid[] instances;
		}
		public Expansion[] expansions;
	}
}