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
			/// Coroutine that retrieves a WoW guild.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetGuild(BattleNetRegion region, string realmSlug, string nameSlug, Action<WowGuild_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Format("/data/wow/guild/{0}/{1}", realmSlug, nameSlug);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft guild.
	/// </summary>
	[Serializable]
	public class WowGuild_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public string name;
		public TypeStruct faction;
		public int achievement_points;
		public int member_count;
		public RealmStruct realm;

		[Serializable]
		public struct GuildCrestColor
		{
			public int id;
			public ColorStruct rgba;
		}

		[Serializable]
		public struct GuildCrestEmblemBackground
		{
			public GuildCrestColor color;
		}

		[Serializable]
		public struct GuildCrestEmblemPart
		{
			public int id;
			public RefIdStruct media;
			public GuildCrestColor color;
		}

		[Serializable]
		public struct GuildCrestEmblem
		{
			public GuildCrestEmblemPart emblem;
			public GuildCrestEmblemPart border;
			public GuildCrestEmblemBackground background;
		}
		public GuildCrestEmblem crest;

		public HRefStruct roster;
		public HRefStruct achievements;
		public long created_timestamp;
		public HRefStruct activity;
	}
}