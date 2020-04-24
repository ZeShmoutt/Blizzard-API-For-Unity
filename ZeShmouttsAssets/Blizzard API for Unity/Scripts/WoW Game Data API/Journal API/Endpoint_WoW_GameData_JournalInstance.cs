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
			/// <summary>
			/// Coroutine that retrieves a WoW dungeon journal instance.
			/// </summary>
			/// <param name="journalInstanceId">The ID of the journal instance.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetJournalInstance(int journalInstanceId, Action<WowJournalInstance_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/journal-instance/{0}", journalInstanceId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft dungeon journal instances.
	/// </summary>
	[Serializable]
	public class WowJournalInstance_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public NameIdStruct map;
		public NameIdStruct area;
		public LocalizedString description;
		public RefNameIdStruct[] encounters;
		public RefNameIdStruct expansion;
		public NameIdStruct location;

		[Serializable]
		public struct InstanceMode
		{
			public TypeNameStruct mode;
			public int players;
			public bool is_tracked;
		}
		public InstanceMode[] modes;

		public RefIdStruct media;
		public int minimum_level;
		public TypeStruct category;
	}
}