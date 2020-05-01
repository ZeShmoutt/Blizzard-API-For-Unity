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
			/// Coroutine that retrieves a WoW character's PvP bracket statistics.
			/// Returns a 404 Not Found for characters that have not yet completed a PvP match for the specified bracket.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="pvpBracket">The PvP bracket type ('2v2', '3v3', or 'rbg').</param>
			/// <param name="action_Result">Action to execute with the character data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterPvPBracketStatistics(BattleNetRegion region, string realmSlug, string characterName, string pvpBracket, Action<WowCharacterPvPBracketStatistics_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = string.Concat(characterBasePath, realmSlug, "/", characterName, "/pvp-bracket/", pvpBracket);
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft character's PvP bracket statistics.
	/// </summary>
	[Serializable]
	public class WowCharacterPvPBracketStatistics_JSON : Object_Json
	{
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
	}
}