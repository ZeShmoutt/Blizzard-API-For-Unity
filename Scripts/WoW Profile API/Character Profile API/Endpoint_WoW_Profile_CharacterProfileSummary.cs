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
			/// Coroutine that retrieves a profile summary for a character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterProfileSummary(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterProfileSummary> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a profile summary for a character, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterProfileSummaryRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a profile summary for a character.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterProfileSummary : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public string name;

		public TypeNameStruct gender;
		public TypeNameStruct faction;

		public RefNameIdStruct race;
		public RefNameIdStruct character_class;
		public RefNameIdStruct active_spec;

		public RealmStruct realm;

		public GuildStruct guild;

		public int level;
		public int experience;
		public int achievement_points;

		public HRefStruct achievements;
		public HRefStruct titles;
		public HRefStruct pvp_summary;
		public HRefStruct raid_progression;
		public HRefStruct media;

		public int last_login_timestamp;
		public int average_item_level;
		public int equipped_item_level;

		public HRefStruct specializations;
		public HRefStruct statistics;
		public HRefStruct mythic_keystone_profile;
		public HRefStruct equipment;
		public HRefStruct appearance;
		public HRefStruct collections;

		public HRefStruct reputations;
		public HRefStruct quests;
		// {{JSON_END}}
	}
}