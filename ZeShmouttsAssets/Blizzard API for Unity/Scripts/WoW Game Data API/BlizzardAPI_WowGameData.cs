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
		public static IEnumerator CGetAchievementCategoriesIndex(API.BattleNetRegion region, Action<WowAchievementCategoriesIndex_Json> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = "/data/wow/achievement-category/index";
			string url = API.UrlFormatter(region, path, API.namespaceStatic);

			yield return API.SendRequest<WowAchievementCategoriesIndex_Json>(url, x => result(x));
		}

		/// <summary>
		/// Coroutine that retrieves a WoW achievement category for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="achievementCategoryId">ID of the achievement category to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementCategory(API.BattleNetRegion region, int achievementCategoryId, Action<WowAchievementCategory_JSON> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = string.Format("/data/wow/achievement-category/{0}", achievementCategoryId.ToString());
			string url = API.UrlFormatter(region, path, API.namespaceStatic);

			yield return API.SendRequest<WowAchievementCategory_JSON>(url, x => result(x));
		}

		/// <summary>
		/// Coroutine that retrieves the index of WoW achievements for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementsIndex(API.BattleNetRegion region, Action<WowAchievementIndex_JSON> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = "/data/wow/achievement/index";
			string url = API.UrlFormatter(region, path, API.namespaceStatic);

			yield return API.SendRequest<WowAchievementIndex_JSON>(url, x => result(x));
		}

		/// <summary>
		/// Coroutine that retrieves a WoW achievement for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="achievementId">ID of the achievement to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievement(API.BattleNetRegion region, int achievementId, Action<WoWAchievement_JSON> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = string.Format("/data/wow/achievement/{0}", achievementId.ToString());
			string url = API.UrlFormatter(region, path, API.namespaceStatic);

			yield return API.SendRequest<WoWAchievement_JSON>(url, x => result(x));
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW achievement for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="achievementId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementMedia(API.BattleNetRegion region, int achievementId, Action<WowAchievementMedia_JSON> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = string.Format("/data/wow/media/achievement/{0}", achievementId.ToString());
			string url = API.UrlFormatter(region, path, API.namespaceStatic);

			yield return API.SendRequest<WowAchievementMedia_JSON>(url, x => result(x));
		}

		#endregion

		#region Auction House API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Azerite Essence API

		// NOT YET IMPLEMENTED.

		#endregion

		#region Connected Realm API

		// NOT YET IMPLEMENTED.

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
		public static IEnumerator CGetRealmsIndex(API.BattleNetRegion region, Action<WowRealmsIndex_JSON> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = "/data/wow/realm/index";
			string url = API.UrlFormatter(region, path, API.namespaceDynamic);

			yield return API.SendRequest<WowRealmsIndex_JSON>(url, x => result(x));
		}

		/// <summary>
		/// Coroutine that retrieves a WoW realm for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the data from.</param>
		/// <param name="realmSlug">The realm's data-friendly name. Use CGetRealmsIndex to get a list of realms and their slugs.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetRealm(API.BattleNetRegion region, string realmSlug, Action<WowRealm_JSON> result = null)
		{
			yield return API.CheckAccessToken(region);

			string path = string.Format("/data/wow/realm/{0}", realmSlug);
			string url = API.UrlFormatter(region, path, API.namespaceDynamic);

			yield return API.SendRequest<WowRealm_JSON>(url, x => result(x));
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



