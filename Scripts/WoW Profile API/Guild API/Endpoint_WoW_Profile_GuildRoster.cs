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
			internal const string apiPath_GuildRoster = "/roster";

			/// <summary>
			/// Coroutine that retrieves a single guild's roster by its name and realm.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildRoster(BattleNetRegion region, string realmSlug, string nameSlug, Action<Json_Wow_GuildRoster> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowGuildEndpointPath(realmSlug, nameSlug) + apiPath_GuildRoster;
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a single guild's roster by its name and realm, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildRosterRaw(BattleNetRegion region, string realmSlug, string nameSlug, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowGuildEndpointPath(realmSlug, nameSlug) + apiPath_GuildRoster;
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a guild's roster.
	/// </summary>
	[Serializable]
	public class Json_Wow_GuildRoster : Object_JSON
	{
		// {{JSON_START}}
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
		// {{JSON_END}}
	}
}