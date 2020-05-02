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
			/// Coroutine that retrieves a WoW guild's activity.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildRoster(BattleNetRegion region, string realmSlug, string nameSlug, Action<WowGuildRoster_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Format("/data/wow/guild/{0}/{1}/roster", realmSlug, nameSlug);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft guild's activity.
	/// </summary>
	[Serializable]
	public class WowGuildRoster_JSON : Object_Json
	{
		public LinkStruct _links;

		public GuildStruct guild;

		[Serializable]
		public struct GuildCharacter
		{
			public HRefStruct key;
			public string name;
			public long id;
			public RealmStruct realm;
			public int level;
			public RefIdStruct playable_class;
			public RefIdStruct playable_race;
		}

		[Serializable]
		public struct GuildMember
		{
			public GuildCharacter character;
			public int rank;
		}
		public GuildMember[] members;
	}
}