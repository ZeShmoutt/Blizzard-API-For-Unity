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
		/// API endpoints related to Hearthstone game data (cards, card backs, etc.).
		/// Reference : https://develop.battle.net/documentation/hearthstone/game-data-apis
		/// </summary>
		public static partial class HearthstoneGameData
		{
			internal const string apiPath_Metadata = "/hearthstone/metadata";

			#region All Metadata

			/// <summary>
			/// Coroutine that retrieves a list of metadata.
			/// </summary>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataAll(Action<Json_Hearthstone_MetadataList> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = apiPath_Metadata;
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Coroutine that retrieves a list of metadata, as a raw JSON string.
			/// </summary>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetMetadataAllRaw(Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string path = apiPath_Metadata;
				yield return SendRequest(region, null, path, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			#endregion

			#region Internal

			/// <summary>
			/// Coroutine that retrieves metadata of a specified type.
			/// </summary>
			/// <typeparam name="T">The type of the metadata to retrieve.</typeparam>
			/// <param name="path">API path of the metadata.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			internal static IEnumerator GetMetadata<T>(string path, Action<T[]> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				yield return GetMetadataRaw(path, x => action_Result(ConvertMetadataJson<T>(x)), ifModifiedSince, action_LastModified, action_OnError, region);
			}

			/// <summary>
			/// Coroutine that retrieves metadata of a specified type, as a raw JSON string.
			/// </summary>
			/// <param name="path">API path of the metadata.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			internal static IEnumerator GetMetadataRaw(string path, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, Action<string> action_OnError = null, BattleNetRegion region = DEFAULT_REGION)
			{
				string url = MetadataUrl(region, path);
				yield return CustomRequest(url, null, action_Result, ifModifiedSince, action_LastModified, action_OnError);
			}

			/// <summary>
			/// Shortcut to create a formatted URL for Hearthstone metadata requests.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="path">API path of the metadata.</param>
			/// <returns></returns>
			internal static string MetadataUrl(BattleNetRegion region, string path)
			{
				return string.Concat(UrlDomain(region), apiPath_Metadata, "/", path);
			}

			/// <summary>
			/// Special JSON conversion for Hearthstone metadata, that are supplied directly as an array instead of a container with an array.
			/// </summary>
			/// <typeparam name="T">Type to return.</typeparam>
			/// <param name="json">JSON to convert.</param>
			/// <returns>Returns an array of the specified type.</returns>
			internal static T[] ConvertMetadataJson<T>(string json)
			{
				return UnityEngine.JsonUtility.FromJson<T[]>(json);
			}

			#endregion
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Hearthstone, representing a list of all metadata.
	/// </summary>
	[Serializable]
	public class Json_Hearthstone_MetadataList : Object_JSON
	{
		public Json_Hearthstone_Metadata_Set[] sets;
		public Json_Hearthstone_Metadata_SetGroup[] setGroups;
		public int[] arenaIds;
		public Json_Hearthstone_Metadata_Type[] types;
		public Json_Hearthstone_Metadata_Rarity[] rarities;
		public Json_Hearthstone_Metadata_Class[] classes;
		public Json_Hearthstone_Metadata_MinionType[] minionTypes;
		public Json_Hearthstone_Metadata_SpellSchool[] spellSchools;
		public Json_Hearthstone_Metadata_GameMode[] gameModes;
		public Json_Hearthstone_Metadata_Keyword[] keywords;
		public string[] filterableFields;
		public string[] numericFields;
		public Json_Hearthstone_Metadata_CardBackCategory[] cardBackCategories;
	}
}
