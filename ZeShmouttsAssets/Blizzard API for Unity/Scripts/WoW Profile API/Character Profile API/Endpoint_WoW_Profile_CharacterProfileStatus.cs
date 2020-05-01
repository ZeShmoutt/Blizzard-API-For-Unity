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
			/// Coroutine that retrieves the status and a unique ID for a WoW character.
			/// See the documentation for use cases :
			/// https://develop.battle.net/documentation/world-of-warcraft/profile-apis
			/// </summary>
			/// <remark>
			/// A client should delete information about a character from their application if any of the following conditions occur:
			/// - an HTTP 404 Not Found error is returned
			/// - the is_valid value is false
			/// - the returned character ID doesn't match the previously recorded value for the character
			/// </remark>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterProfileStatus(BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterProfileStatus_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/status");
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft character's status.
	/// </summary>
	[Serializable]
	public class WowCharacterProfileStatus_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public bool is_valid;
	}
}