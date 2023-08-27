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
			internal const string API_PATH_GUILDACTIVITY = "/activity";

			/// <summary>
			/// Coroutine that retrieves a single guild's activity by name and realm.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildActivity(BattleNetRegion region, string realmSlug, string nameSlug, Action<Json_Wow_GuildActivity> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowGuildEndpointPath(realmSlug, nameSlug) + API_PATH_GUILDACTIVITY;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a single guild's activity by name and realm, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetGuildActivityRaw(BattleNetRegion region, string realmSlug, string nameSlug, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowGuildEndpointPath(realmSlug, nameSlug) + API_PATH_GUILDACTIVITY;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a guild's activity.
	/// </summary>
	[Serializable]
	public class Json_Wow_GuildActivity : Object_JSON
	{
		// {{JSON_START}}
		// May or may not be missing some activity types.

		public LinkStruct _links;

		public GuildStruct guild;

		[Serializable]
		public struct GuildActivityEncounter
		{
			public KeyNameIdStruct encounter;
			public TypeStruct mode;
		}

		[Serializable]
		public struct GuildActivityCharacterAchievement
		{
			public CharacterStruct character;
			public KeyNameIdStruct achievement;
		}

		[Serializable]
		public struct GuildActivity
		{
			public GuildActivityCharacterAchievement character_achievement;
			public GuildActivityEncounter encounter_completed;
			public TypeStruct activity;
			public long timestamp;
		}
		public GuildActivity[] activities;
		// {{JSON_END}}
	}
}