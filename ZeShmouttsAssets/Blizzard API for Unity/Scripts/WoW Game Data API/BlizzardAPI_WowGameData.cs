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
		/// Coroutine that retrieves the index of WoW achievement categories as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW achievement category as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="achievementCategoryId">ID of the achievement category to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementCategory(int achievementCategoryId, Action<WowAchievementCategory_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/achievement-category/{0}", achievementCategoryId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the index of WoW achievements as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW achievement as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="achievementId">ID of the achievement to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievement(int achievementId, Action<WoWAchievement_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/achievement/{0}", achievementId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW achievement as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="achievementId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAchievementMedia(int achievementId, Action<WowAchievementMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/achievement/{0}", achievementId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Auction House API

		/// <summary>
		/// Coroutine that retrieves a list of all WoW auctions in a connected realm as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="connectedRealmId">ID of the achievement to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAuctions(int connectedRealmId, Action<WowAuctions_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/connected-realm/{0}/auctions", connectedRealmId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Azerite Essence API

		/// <summary>
		/// Coroutine that retrieves the index of WoW azerite essences as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW azerite essence as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssence(int azeriteEssenceId, Action<WowAzeriteEssence_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/azerite-essence/{0}", azeriteEssenceId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="azeriteEssenceId">ID of the azerite essence to retrieve the corresponding media.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetAzeriteEssenceMedia(int azeriteEssenceId, Action<WowAzeriteEssenceMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/azerite-essence/{0}", azeriteEssenceId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Connected Realm API

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW azerite essence as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves the medias of a WoW azerite essence as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="connectedRealmId">ID of the connected realm to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetConnectedRealm(int connectedRealmId, Action<WowConnectedRealm_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/connected-realm/{0}", connectedRealmId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceDynamic, path, result);
		}

		#endregion

		#region Creature API

		/// <summary>
		/// Coroutine that retrieves an index of WoW creature families as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW creature family as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureFamilyId">The ID of the creature family.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureFamily(int creatureFamilyId, Action<WowCreatureFamily_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/creature-family/{0}", creatureFamilyId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves an index of WoW creature types as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW creature type as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureTypeId">ID of the creature type to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureType(int creatureTypeId, Action<WowCreatureType_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/creature-type/{0}", creatureTypeId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW creature as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureId">ID of the creature to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreature(int creatureId, Action<WowCreature_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/creature/{0}", creatureId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW creature as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureDisplayId">ID of the creature to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureDisplayMedia(int creatureDisplayId, Action<WowCreatureDisplayMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/creature-display/{0}", creatureDisplayId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW creature family as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="creatureFamilyId">The ID of the creature family.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetCreatureFamilyMedia(int creatureFamilyId, Action<WowCreatureFamilyMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/creature-family/{0}", creatureFamilyId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Guild Crest API

		/// <summary>
		/// Coroutine that retrieves an index of WoW guild crest components as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves the medias of a WoW guild crest border as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="borderId">ID of the creature type to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetGuildCrestBorderMedia(int borderId, Action<WowGuildCrestBorderMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/guild-crest/border/{0}", borderId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW guild crest emblem as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="emblemId">ID of the creature to retrieve.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetGuildCrestEmblemMedia(int emblemId, Action<WowGuildCrestEmblemMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/guild-crest/emblem/{0}", emblemId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		#endregion

		#region Item API

		/// <summary>
		/// Coroutine that retrieves an index of WoW item classes as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW item class as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemClassId">The ID of the item class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemClass(int itemClassId, Action<WowItemClass_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/item-class/{0}", itemClassId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves an index of WoW item sets as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW item set as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemSetId">The ID of the item set.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemSet(int itemSetId, Action<WowItemSet_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/item-set/{0}", itemSetId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW item as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemId">The ID of the item.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItem(int itemId, Action<WowItem_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/item/{0}", itemId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW item as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="itemId">The ID of the item.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetItemMedia(int itemId, Action<WowItemMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/item/{0}", itemId);
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
		/// Coroutine that retrieves an index of WoW item classes as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW playable class as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="classId">The ID of the playable class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPlayableClass(int classId, Action<WowPlayableClass_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/playable-class/{0}", classId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW playable class as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="playableClassId">The ID of the playable class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPlayableClassMedia(int playableClassId, Action<WowPlayableClassMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/playable-class/{0}", playableClassId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves WoW PvP talent slots as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="classId">The ID of the playable class.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetPvpTalentSlots(int classId, Action<WowPvpTalentSlots_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/playable-class/{0}/pvp-talent-slots", classId);
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

		#region Profession API

		/// <summary>
		/// Coroutine that retrieves an index of WoW professions as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetProfessionsIndex(Action<WowProfessionsIndex_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = "/data/wow/profession/index";
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW profession as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="professionId">The ID of the profession.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetProfession(int professionId, Action<WowProfession_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/profession/{0}", professionId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW profession as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="professionId">The ID of the profession.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetProfessionMedia(int professionId, Action<WowProfessionMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/profession/{0}", professionId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW profession as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="professionId">The ID of the profession.</param>
		/// <param name="skillTierId">The ID of the skill tier.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetProfessionSkillTier(int professionId, int skillTierId, Action<WowProfessionSkillTier_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/profession/{0}/skill-tier/{1}", professionId, skillTierId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW profession as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="recipeId">The ID of the recipe.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetRecipe(int recipeId, Action<WowRecipe_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/recipe/{0}", recipeId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves a WoW profession as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="recipeId">The ID of the recipe.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetRecipeMedia(int recipeId, Action<WowRecipeMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/recipe/{0}", recipeId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

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
		/// Coroutine that retrieves the index of WoW realms as JSON, then convert the JSON to something easier to handle.
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
		/// Coroutine that retrieves a WoW realm as JSON, then convert the JSON to something easier to handle.
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

		/// <summary>
		/// Coroutine that retrieves a WoW spell as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="spellId">The ID of the spell.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetSpell(int spellId, Action<WowSpell_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/spell/{0}", spellId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

		/// <summary>
		/// Coroutine that retrieves the medias of a WoW spell as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="spellId">The ID of the spell.</param>
		/// <param name="result">Action to execute with the data once retrieved and converted.</param>
		/// <param name="region">The region of the data to retrieve.</param>
		/// <returns></returns>
		public static IEnumerator CGetSpellMedia(int spellId, Action<WowSpellMedia_JSON> result, BlizzardAPI.BattleNetRegion region = BlizzardAPI.BattleNetRegion.UnitedStates)
		{
			string path = string.Format("/data/wow/media/spell/{0}", spellId);
			yield return BlizzardAPI.SendRequest(region, BlizzardAPI.namespaceStatic, path, result);
		}

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



