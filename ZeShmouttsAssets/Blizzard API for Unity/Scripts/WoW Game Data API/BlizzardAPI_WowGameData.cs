using System;
using System.Collections;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// API endpoints related to World of Warcraft game data (items, spells, etc.).
	/// Reference : https://develop.battle.net/documentation/world-of-warcraft/game-data-apis
	/// </summary>
	public static class BlizzardAPI_WowGameData
	{
		#region Achievements API

		/// <summary>
		/// Coroutine that retrieves the index of WoW achievement categories for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementCategoriesIndex(BlizzardAPI.BattleNetRegion region, Action<WowAchievementCategoriesIndex_Json> result)
		{
			string path = "/data/wow/achievement-category/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW achievement category for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="achievementCategoryId">ID of the achievement category to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementCategory(BlizzardAPI.BattleNetRegion region, int achievementCategoryId, Action<WowAchievementCategory_JSON> result)
		{
			string path = string.Format("/data/wow/achievement-category/{0}", achievementCategoryId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the index of WoW achievements for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementsIndex(BlizzardAPI.BattleNetRegion region, Action<WowAchievementIndex_JSON> result)
		{
			string path = "/data/wow/achievement/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW achievement for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="achievementId">ID of the achievement to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievement(BlizzardAPI.BattleNetRegion region, int achievementId, Action<WoWAchievement_JSON> result)
		{
			string path = string.Format("/data/wow/achievement/{0}", achievementId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW achievement for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="achievementId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementMedia(BlizzardAPI.BattleNetRegion region, int achievementId, Action<WowAchievementMedia_JSON> result)
		{
			string path = string.Format("/data/wow/media/achievement/{0}", achievementId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Auction House API

		/// <summary>
		/// Coroutine that retrieves a list of all WoW auctions in a connected realm for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="connectedRealmId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAuctions(BlizzardAPI.BattleNetRegion region, int connectedRealmId, Action<WowAuctions_JSON> result = null)
		{
			string path = string.Format("/data/wow/connected-realm/{0}/auctions", connectedRealmId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Azerite Essence API

		/// <summary>
		/// Coroutine that retrieves the index of WoW azerite essences for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssencesIndex(BlizzardAPI.BattleNetRegion region, Action<WowAzeriteEssencesIndex_JSON> result = null)
		{
			string path = "/data/wow/azerite-essence/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssence(BlizzardAPI.BattleNetRegion region, int azeriteEssenceId, Action<WowAzeriteEssence_JSON> result = null)
		{
			string path = string.Format("/data/wow/azerite-essence/{0}", azeriteEssenceId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssenceMedia(BlizzardAPI.BattleNetRegion region, int azeriteEssenceId, Action<WowAzeriteEssenceMedia_JSON> result = null)
		{
			string path = string.Format("/data/wow/media/azerite-essence/{0}", azeriteEssenceId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Connected Realm API

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetConnectedRealmsIndex(BlizzardAPI.BattleNetRegion region, Action<WowConnectedRealmsIndex_JSON> result = null)
		{
			string path = "/data/wow/connected-realm/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="connectedRealmId">ID of the connected realm to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetConnectedRealm(BlizzardAPI.BattleNetRegion region, int connectedRealmId, Action<WowConnectedRealm_JSON> result = null)
		{
			string path = string.Format("/data/wow/connected-realm/{0}", connectedRealmId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Creature API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Guild Crest API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Journal API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Journal API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Mount API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Mythic Keystone Affix API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Mythic Keystone Dungeon API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Mythic Keystone Leaderboard API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Mythic Raid Leaderboard API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Pet API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Playable Class API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Playable Race API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Playable Specialization API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Power Type API

		// NOT YET IMPLEMENTED.

		#endregion

		#region PvP Season API

		// NOT YET IMPLEMENTED.

		#endregion

		#region PvP Tier API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Quest API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Realms API

		/// <summary>
		/// Coroutine that retrieves the index of WoW realms for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetRealmsIndex(BlizzardAPI.BattleNetRegion region, Action<WowRealmsIndex_JSON> result = null)
		{
			string path = "/data/wow/realm/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW realm for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="realmSlug">The realm's data-friendly name. Use CGetRealmsIndex to get a list of realms and their slugs.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetRealm(BlizzardAPI.BattleNetRegion region, string realmSlug, Action<WowRealm_JSON> result = null)
		{
			string path = string.Format("/data/wow/realm/{0}", realmSlug);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Region API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Reputations API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Spell API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Talent API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Title API

		// NOT YET IMPLEMENTED.

		#endregion

		#region WoW Token API

		// NOT YET IMPLEMENTED.

		#endregion
	}
}



