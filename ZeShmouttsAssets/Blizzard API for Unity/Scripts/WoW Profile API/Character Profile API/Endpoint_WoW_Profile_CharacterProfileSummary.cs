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
			/// Coroutine that retrieves informations about a WoW character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterProfileSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterProfileSummary_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft characters.
	/// </summary>
	[Serializable]
	public class WowCharacterProfileSummary_JSON : Object_Json
	{
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
	}
}