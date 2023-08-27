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
		/// API endpoints related to World of Warcraft game data (items, spells, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/game-data-apis
		/// </summary>
		public static partial class WowGameData
		{
			internal const string API_PATH_TALENTTREE = BASEPATH_WOW_GAMEDATA + "/talent-tree/{0}/playable-specialization/{1}";

			/// <summary>
			/// Coroutine that retrieves a talent tree by specialization ID.
			/// </summary>
			/// <param name="talentTreeId">The ID of the talent tree.</param>
			/// <param name="specId">The ID of the playable specialization.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetTalentTree(int talentTreeId, int specId, Action<Json_Wow_TalentTree> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_TALENTTREE, talentTreeId, specId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a talent tree by specialization ID, as a raw JSON string.
			/// </summary>
			/// <param name="talentTreeId">The ID of the talent tree.</param>
			/// <param name="specId">The ID of the playable specialization.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="action_OnError">Action to execute when the request returns an error.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetTalentTreeRaw(int talentTreeId, int specId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = string.Format(API_PATH_TALENTTREE, talentTreeId, specId);
				yield return SendRequest(region, NAMESPACE_STATIC, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a talent tree.
	/// </summary>
	[Serializable]
	public class Json_Wow_TalentTree : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public int id;
		public KeyNameIdStruct playable_class;
		public KeyNameIdStruct playable_specialization;
		public LocalizedString name;
		public KeyStruct media;

		[Serializable]
		public struct RestrictionLine
		{
			public int required_points;
			public float restricted_row;
			public bool is_for_class;
		}
		public RestrictionLine[] restriction_lines;
		public TalentNodeStruct[] class_talent_nodes;
		public TalentNodeStruct[] spec_talent_nodes;
		// {{JSON_END}}
	}
}