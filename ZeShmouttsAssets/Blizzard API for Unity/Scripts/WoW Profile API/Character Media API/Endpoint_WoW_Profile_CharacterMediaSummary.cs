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
			/// Coroutine that retrieves medias about a WoW character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterMediaSummary(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMediaSummary_JSON> action_Result, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/character-media");
				yield return SendRequest(region, namespaceProfile, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's medias.
	/// </summary>
	[Serializable]
	public class WowCharacterMediaSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		[Serializable]
		public struct CharacterStruct
		{
			public HRefStruct key;
			public string name;
			public int id;
			public RealmStruct realm;
		}
		public CharacterStruct character;
		public string avatar_url;
		public string bust_url;
		public string render_url;
	}
}