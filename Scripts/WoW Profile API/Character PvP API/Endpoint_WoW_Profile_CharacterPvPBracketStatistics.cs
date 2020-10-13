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
			internal const string API_PATH_CHARACTERPVPBRACKETSTATISTICS = "/pvp-bracket/{0}";

			/// <summary>
			/// Coroutine that retrieves the PvP bracket statistics for a character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="pvpBracket">"The PvP bracket type ("2v2", "3v3", or "rbg")."</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterPvPBracketStatistics(BattleNetRegion region, string realmSlug, string characterName, string pvpBracket, Action<Json_Wow_CharacterPvPBracketStatistics> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + string.Format(API_PATH_CHARACTERPVPBRACKETSTATISTICS, pvpBracket);
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves the PvP bracket statistics for a character, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="pvpBracket">"The PvP bracket type ("2v2", "3v3", or "rbg")."</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterPvPBracketStatisticsRaw(BattleNetRegion region, string realmSlug, string characterName, string pvpBracket, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + string.Format(API_PATH_CHARACTERPVPBRACKETSTATISTICS, pvpBracket);
				yield return SendRequest(region, NAMESPACE_PROFILE, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing the PvP bracket statistics for a character.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterPvPBracketStatistics : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public CharacterStruct character;
		public TypeNameStruct faction;
		public IdTypeStruct bracket;
		public int rating;
		public RefIdStruct season;
		public RefIdStruct tier;

		[Serializable]
		public struct MatchStatistics
		{
			public int played;
			public int won;
			public int lost;
		}
		public MatchStatistics season_match_statistics;
		public MatchStatistics weekly_match_statistics;
		// {{JSON_END}}
	}
}