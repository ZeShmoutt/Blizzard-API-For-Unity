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
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementCategoriesIndex(Action<WowAchievementCategoriesIndex_Json> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/achievement-category/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW achievement category for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="achievementCategoryId">ID of the achievement category to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementCategory(int achievementCategoryId, Action<WowAchievementCategory_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/achievement-category/{0}", achievementCategoryId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the index of WoW achievements for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementsIndex(Action<WowAchievementIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/achievement/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW achievement for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="achievementId">ID of the achievement to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievement(int achievementId, Action<WoWAchievement_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/achievement/{0}", achievementId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW achievement for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="achievementId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementMedia(int achievementId, Action<WowAchievementMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/achievement/{0}", achievementId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Auction House API

		/// <summary>
		/// Coroutine that retrieves a list of all WoW auctions in a connected realm for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="connectedRealmId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAuctions(int connectedRealmId, Action<WowAuctions_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/connected-realm/{0}/auctions", connectedRealmId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Azerite Essence API

		/// <summary>
		/// Coroutine that retrieves the index of WoW azerite essences for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssencesIndex(Action<WowAzeriteEssencesIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/azerite-essence/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssence(int azeriteEssenceId, Action<WowAzeriteEssence_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/azerite-essence/{0}", azeriteEssenceId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssenceMedia(int azeriteEssenceId, Action<WowAzeriteEssenceMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/azerite-essence/{0}", azeriteEssenceId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Connected Realm API

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetConnectedRealmsIndex(Action<WowConnectedRealmsIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/connected-realm/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="connectedRealmId">ID of the connected realm to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetConnectedRealm(int connectedRealmId, Action<WowConnectedRealm_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/connected-realm/{0}", connectedRealmId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Creature API

		/// <summary>
		/// Coroutine that retrieves an index of WoW creature families for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureFamiliesIndex(Action<WowCreatureFamiliesIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/creature-family/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW creature family for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureFamilyId">The ID of the creature family.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureFamily(int creatureFamilyId, Action<WowCreatureFamily_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/creature-family/{0}", creatureFamilyId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves an index of WoW creature types for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureTypesIndex(Action<WowCreatureTypesIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/creature-type/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW creature type for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureTypeId">ID of the creature type to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureType(int creatureTypeId, Action<WowCreatureType_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/creature-type/{0}", creatureTypeId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW creature for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureId">ID of the creature to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreature(int creatureId, Action<WowCreature_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/creature/{0}", creatureId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW creature for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureDisplayId">ID of the creature to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureDisplayMedia(int creatureDisplayId, Action<WowCreatureDisplayMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/creature-display/{0}", creatureDisplayId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW creature family for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureFamilyId">The ID of the creature family.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureFamilyMedia(int creatureFamilyId, Action<WowCreatureFamilyMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/creature-family/{0}", creatureFamilyId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Guild Crest API

		/// <summary>
		/// Coroutine that retrieves an index of WoW guild crest components for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetGuildCrestComponentsIndex(Action<WowGuildCrestComponentsIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/guild-crest/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW guild crest border for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="borderId">ID of the creature type to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetGuildCrestBorderMedia(int borderId, Action<WowGuildCrestBorderMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/guild-crest/border/{0}", borderId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW guild crest emblem for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="emblemId">ID of the creature to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetGuildCrestEmblemMedia(int emblemId, Action<WowGuildCrestEmblemMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/guild-crest/emblem/{0}", emblemId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Item API

		/// <summary>
		/// Coroutine that retrieves an index of WoW item classes for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemClassesIndex(Action<WowItemClassesIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/item-class/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW item class for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemClassId">The ID of the item class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemClass(int itemClassId, Action<WowItemClass_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/item-class/{0}", itemClassId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves an index of WoW item sets for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemSetsIndex(Action<WowItemSetsIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/item-set/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW item set for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemSetId">The ID of the item set.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemSet(int itemSetId, Action<WowItemSet_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/item-set/{0}", itemSetId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW item for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemId">The ID of the item.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItem(int itemId, Action<WowItem_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/item/{0}", itemId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW item for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemId">The ID of the item.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemMedia(int itemId, Action<WowItemMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/item/{0}", itemId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

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

		/// <summary>
		/// Coroutine that retrieves an index of WoW item classes for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPlayableClassesIndex(Action<WowPlayableClassesIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/playable-class/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW playable class for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="classId">The ID of the playable class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPlayableClass(int classId, Action<WowPlayableClass_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/playable-class/{0}", classId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW playable class for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="playableClassId">The ID of the playable class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPlayableClassMedia(int playableClassId, Action<WowPlayableClassMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/playable-class/{0}", playableClassId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves WoW PvP talent slots for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="classId">The ID of the playable class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPvpTalentSlots(int classId, Action<WowPvpTalentSlots_Json> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/playable-class/{0}/pvp-talent-slots", classId.ToString());
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

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
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetRealmsIndex(Action<WowRealmsIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/realm/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW realm for the specified region as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <param name="realmSlug">The realm's data-friendly name. Use CGetRealmsIndex to get a list of realms and their slugs.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <returns></returns>
		public static IEnumerator CGetRealm(string realmSlug, Action<WowRealm_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
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



