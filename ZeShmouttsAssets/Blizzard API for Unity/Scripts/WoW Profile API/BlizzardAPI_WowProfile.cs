using System;
using System.Collections;
using System.Collections.Generic;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// API endpoints related to World of Warcraft profile data (characters, account, etc.).
	/// Reference : https://develop.battle.net/documentation/world-of-warcraft/profile-apis
	/// </summary>
	public static class BlizzardAPI_WowProfile
	{
		private const string characterBasePath = "/profile/wow/character/";

		#region Account Profile API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Achievements API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Appearance API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Collections API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Encounters API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Equipment API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Hunter Pets API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Media API

		/// <summary>
		/// Coroutine that retrieves medias about a WoW character as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetCharacterProfileSummary(BlizzardAPI.BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMediaSummary_JSON> result)
		{
			string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/character-media");
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceProfile, path, result);
		}

		#endregion

		#region Character Mythic Keystone Profile API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Professions API

		/// <summary>
		/// Coroutine that retrieves a summary of a WoW character's professions as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetCharacterProfessionsSummary(BlizzardAPI.BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMediaSummary_JSON> result)
		{
			string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/professions");
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceProfile, path, result);
		}

		#endregion

		#region Character Profile API

		/// <summary>
		/// Coroutine that retrieves informations about a WoW character as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetCharacterProfileSummary(BlizzardAPI.BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterProfileSummary_JSON> result)
		{
			string path = string.Concat(characterBasePath, realmSlug, "/", characterName);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceProfile, path, result);
		}

		/// <summary>
		/// EXPERIMENTAL FEATURE, USE WITH CAUTION. Same as CGetCharacterProfileSummary except it uses web request headers to send the token and namespace, instead of cramming everything in the url.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetCharacterProfileSummaryTest(BlizzardAPI.BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterProfileSummary_JSON> result)
		{
			Dictionary<string, string> headers = new Dictionary<string, string>()
			{
				{ "Battlenet-Namespace", BlizzardAPI.namespaceProfile + region },
				{ "Authorization", "Bearer " + BlizzardAPI.accessToken.token }
			};

			string path = string.Concat(characterBasePath, realmSlug, "/", characterName);

			yield return BlizzardAPI.SendRequestHeaders(region, BlizzardAPI.namespaceProfile, path, headers, result);
		}

		#endregion

		#region Character PvP API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Quests API

		/// <summary>
		/// Coroutine that retrieves a WoW character's list of active quests as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetCharacterQuests(BlizzardAPI.BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMediaSummary_JSON> result)
		{
			string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/quests");
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceProfile, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW character's list of completed quests as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetCharacterCompletedQuests(BlizzardAPI.BattleNetRegion region, string realmSlug, string characterName, Action<WowCharacterMediaSummary_JSON> result)
		{
			string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/quests/completed");
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceProfile, path, result);
		}

		#endregion

		#region Character Reputations API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Specializations API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Statistics API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Character Titles API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Guild API

		// NOT YET IMPLEMENTED.

		#endregion
	}
}
