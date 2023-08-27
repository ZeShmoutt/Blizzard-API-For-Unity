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
			internal const string API_PATH_CHARACTERAPPEARANCESUMMARY = "/appearance";

			/// <summary>
			/// Coroutine that retrieves a summary of a character's appearance settings.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAppearanceSummary(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterAppearanceSummary> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + API_PATH_CHARACTERAPPEARANCESUMMARY;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a summary of a character's appearance settings, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterAppearanceSummaryRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + API_PATH_CHARACTERAPPEARANCESUMMARY;
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a summary of a character's appearance settings.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterAppearanceSummary : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public CharacterStruct character;
		public KeyNameIdStruct playable_race;
		public KeyNameIdStruct playable_class;
		public KeyNameIdStruct active_spec;
		public TypeNameStruct gender;
		public TypeNameStruct faction;

		[Serializable]
		public struct GuildCrestItemColor
		{
			public int id;
			public ColorStruct rgba;
		}

		[Serializable]
		public struct GuildCrestItem
		{
			public int id;
			public KeyIdStruct media;
			public GuildCrestItemColor color;
		}

		[Serializable]
		public struct GuildCrest
		{
			public GuildCrestItem emblem;
			public GuildCrestItem border;
			public GuildCrestItem background;
		}
		public GuildCrest guild_crest;

		[Serializable]
		public struct CharacterCustomizationChoice
		{
			public int id;
			public int display_order;
		}

		[Serializable]
		public struct CharacterCustomization
		{
			public NameIdStruct option;
			public CharacterCustomizationChoice choice;
		}
		public CharacterCustomization[] customizations;

		[Serializable]
		public struct ItemAppearance
		{
			public int id;
			public TypeNameStruct slot;
			public int enchant;
			public int item_appearance_modifier_id;
			public int internal_slot_id;
			public int[] subclass;
		}
		public ItemAppearance[] items;
		// {{JSON_END}}
	}
}