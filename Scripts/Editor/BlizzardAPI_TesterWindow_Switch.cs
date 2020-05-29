// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

using System;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI.Editor
{
	public partial class BlizzardAPI_TesterWindow : EditorWindow
	{
		internal static void StartAPICall(int domain, int method, object[] methodParameters)
		{
			switch (domain)
			{
				case 0:
					StartWowClassicGameDataAPICall(method, methodParameters);
					break;
				case 1:
					StartWowGameDataAPICall(method, methodParameters);
					break;
				case 2:
					StartWowProfileAPICall(method, methodParameters);
					break;
				default:
					break;
			}
		}

		private static void StartWowClassicGameDataAPICall(int method, object[] methodParameters)
		{
			switch (method)
			{
				case 0:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreature((int)methodParameters[0], (Action<Json_WowClassic_Creature>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureDisplayMedia((int)methodParameters[0], (Action<Json_WowClassic_CreatureDisplayMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureFamiliesIndex((Action<Json_WowClassic_CreatureFamiliesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureFamily((int)methodParameters[0], (Action<Json_WowClassic_CreatureFamily>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureFamilyMedia((int)methodParameters[0], (Action<Json_WowClassic_CreatureFamilyMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureType((int)methodParameters[0], (Action<Json_WowClassic_CreatureType>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureTypesIndex((Action<Json_WowClassic_CreatureTypesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetGuildCrestBorderMedia((int)methodParameters[0], (Action<Json_WowClassic_GuildCrestBorderMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetGuildCrestComponentsIndex((Action<Json_WowClassic_GuildCrestComponentsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetGuildCrestEmblemMedia((int)methodParameters[0], (Action<Json_WowClassic_GuildCrestEmblemMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItem((int)methodParameters[0], (Action<Json_WowClassic_Item>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemClass((int)methodParameters[0], (Action<Json_WowClassic_ItemClass>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemClassesIndex((Action<Json_WowClassic_ItemClassesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemMedia((int)methodParameters[0], (Action<Json_WowClassic_ItemMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemSubclass((int)methodParameters[0], (int)methodParameters[1], (Action<Json_WowClassic_ItemSubclass>)methodParameters[2], (string)methodParameters[3], (Action<string>)methodParameters[4], (BattleNetRegion)methodParameters[5]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableClass((int)methodParameters[0], (Action<Json_WowClassic_PlayableClass>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableClassMedia((int)methodParameters[0], (Action<Json_WowClassic_PlayableClassMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableClassesIndex((Action<Json_WowClassic_PlayableClassesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableRace((int)methodParameters[0], (Action<Json_WowClassic_PlayableRace>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 19:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableRacesIndex((Action<Json_WowClassic_PlayableRacesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 20:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPowerType((int)methodParameters[0], (Action<Json_WowClassic_PowerType>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 21:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPowerTypesIndex((Action<Json_WowClassic_PowerTypesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				default:
					break;
			}
		}

		private static void StartWowGameDataAPICall(int method, object[] methodParameters)
		{
			switch (method)
			{
				case 0:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievement((int)methodParameters[0], (Action<Json_Wow_Achievement>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementCategoriesIndex((Action<Json_Wow_AchievementCategoriesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementCategory((int)methodParameters[0], (Action<Json_Wow_AchievementCategory>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementMedia((int)methodParameters[0], (Action<Json_Wow_AchievementMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementsIndex((Action<Json_Wow_AchievementsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAuctions((int)methodParameters[0], (Action<Json_Wow_Auctions>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAzeriteEssence((int)methodParameters[0], (Action<Json_Wow_AzeriteEssence>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAzeriteEssenceMedia((int)methodParameters[0], (Action<Json_Wow_AzeriteEssenceMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAzeriteEssencesIndex((Action<Json_Wow_AzeriteEssencesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetConnectedRealm((int)methodParameters[0], (Action<Json_Wow_ConnectedRealm>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetConnectedRealmsIndex((Action<Json_Wow_ConnectedRealmsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreature((int)methodParameters[0], (Action<Json_Wow_Creature>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureDisplayMedia((int)methodParameters[0], (Action<Json_Wow_CreatureDisplayMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureFamiliesIndex((Action<Json_Wow_CreatureFamiliesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureFamily((int)methodParameters[0], (Action<Json_Wow_CreatureFamily>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureFamilyMedia((int)methodParameters[0], (Action<Json_Wow_CreatureFamilyMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureType((int)methodParameters[0], (Action<Json_Wow_CreatureType>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureTypesIndex((Action<Json_Wow_CreatureTypesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetGuildCrestBorderMedia((int)methodParameters[0], (Action<Json_Wow_GuildCrestBorderMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 19:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetGuildCrestComponentsIndex((Action<Json_Wow_GuildCrestComponentsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 20:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetGuildCrestEmblemMedia((int)methodParameters[0], (Action<Json_Wow_GuildCrestEmblemMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 21:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItem((int)methodParameters[0], (Action<Json_Wow_Item>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 22:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemClass((int)methodParameters[0], (Action<Json_Wow_ItemClass>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 23:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemClassesIndex((Action<Json_Wow_ItemClassesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 24:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemMedia((int)methodParameters[0], (Action<Json_Wow_ItemMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 25:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemSet((int)methodParameters[0], (Action<Json_Wow_ItemSet>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 26:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemSetsIndex((Action<Json_Wow_ItemSetsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 27:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemSubclass((int)methodParameters[0], (int)methodParameters[1], (Action<Json_Wow_ItemSubclass>)methodParameters[2], (string)methodParameters[3], (Action<string>)methodParameters[4], (BattleNetRegion)methodParameters[5]));
					break;
				case 28:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalEncounter((int)methodParameters[0], (Action<Json_Wow_JournalEncounter>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 29:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalEncountersIndex((Action<Json_Wow_JournalEncountersIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 30:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalExpansion((int)methodParameters[0], (Action<Json_Wow_JournalExpansion>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 31:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalExpansionsIndex((Action<Json_Wow_JournalExpansionsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 32:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalInstance((int)methodParameters[0], (Action<Json_Wow_JournalInstance>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 33:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalInstanceMedia((int)methodParameters[0], (Action<Json_Wow_JournalInstanceMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 34:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalInstancesIndex((Action<Json_Wow_JournalInstancesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 35:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMount((int)methodParameters[0], (Action<Json_Wow_Mount>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 36:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMountsIndex((Action<Json_Wow_MountsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 37:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneAffix((int)methodParameters[0], (Action<Json_Wow_MythicKeystoneAffix>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 38:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneAffixMedia((int)methodParameters[0], (Action<Json_Wow_MythicKeystoneAffixMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 39:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneAffixesIndex((Action<Json_Wow_MythicKeystoneAffixesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 40:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneDungeon((int)methodParameters[0], (Action<Json_Wow_MythicKeystoneDungeon>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 41:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneDungeonsIndex((Action<Json_Wow_MythicKeystoneDungeonsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 42:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneIndex((Action<Json_Wow_MythicKeystoneIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 43:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystonePeriod((int)methodParameters[0], (Action<Json_Wow_MythicKeystonePeriod>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 44:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystonePeriodsIndex((Action<Json_Wow_MythicKeystonePeriodsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 45:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneSeason((int)methodParameters[0], (Action<Json_Wow_MythicKeystoneSeason>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 46:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneSeasonsIndex((Action<Json_Wow_MythicKeystoneSeasonsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 47:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneLeaderboard((int)methodParameters[0], (int)methodParameters[1], (int)methodParameters[2], (Action<Json_Wow_MythicKeystoneLeaderboard>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5], (BattleNetRegion)methodParameters[6]));
					break;
				case 48:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneLeaderboardsIndex((int)methodParameters[0], (Action<Json_Wow_MythicKeystoneLeaderboardsIndex>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 49:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicRaidLeaderboard((string)methodParameters[0], (string)methodParameters[1], (Action<Json_Wow_MythicRaidLeaderboard>)methodParameters[2], (string)methodParameters[3], (Action<string>)methodParameters[4], (BattleNetRegion)methodParameters[5]));
					break;
				case 50:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPet((int)methodParameters[0], (Action<Json_Wow_Pet>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 51:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPetsIndex((Action<Json_Wow_PetsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 52:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableClass((int)methodParameters[0], (Action<Json_Wow_PlayableClass>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 53:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableClassMedia((int)methodParameters[0], (Action<Json_Wow_PlayableClassMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 54:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableClassesIndex((Action<Json_Wow_PlayableClassesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 55:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTalentSlots((int)methodParameters[0], (Action<Json_Wow_PvPTalentSlots>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 56:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableRace((int)methodParameters[0], (Action<Json_Wow_PlayableRace>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 57:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableRacesIndex((Action<Json_Wow_PlayableRacesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 58:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableSpecialization((int)methodParameters[0], (Action<Json_Wow_PlayableSpecialization>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 59:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableSpecializationMedia((int)methodParameters[0], (Action<Json_Wow_PlayableSpecializationMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 60:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableSpecializationsIndex((Action<Json_Wow_PlayableSpecializationsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 61:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPowerType((int)methodParameters[0], (Action<Json_Wow_PowerType>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 62:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPowerTypesIndex((Action<Json_Wow_PowerTypesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 63:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfession((int)methodParameters[0], (Action<Json_Wow_Profession>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 64:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfessionMedia((int)methodParameters[0], (Action<Json_Wow_ProfessionMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 65:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfessionSkillTier((int)methodParameters[0], (int)methodParameters[1], (Action<Json_Wow_ProfessionSkillTier>)methodParameters[2], (string)methodParameters[3], (Action<string>)methodParameters[4], (BattleNetRegion)methodParameters[5]));
					break;
				case 66:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfessionsIndex((Action<Json_Wow_ProfessionsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 67:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRecipe((int)methodParameters[0], (Action<Json_Wow_Recipe>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 68:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRecipeMedia((int)methodParameters[0], (Action<Json_Wow_RecipeMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 69:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPLeaderboard((int)methodParameters[0], (string)methodParameters[1], (Action<Json_Wow_PvPLeaderboard>)methodParameters[2], (string)methodParameters[3], (Action<string>)methodParameters[4], (BattleNetRegion)methodParameters[5]));
					break;
				case 70:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPLeaderboardsIndex((int)methodParameters[0], (Action<Json_Wow_PvPLeaderboardsIndex>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 71:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPRewardsIndex((int)methodParameters[0], (Action<Json_Wow_PvPRewardsIndex>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 72:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPSeason((int)methodParameters[0], (Action<Json_Wow_PvPSeason>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 73:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPSeasonsIndex((Action<Json_Wow_PvPSeasonsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 74:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTier((int)methodParameters[0], (Action<Json_Wow_PvPTier>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 75:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTierMedia((int)methodParameters[0], (Action<Json_Wow_PvPTierMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 76:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTiersIndex((Action<Json_Wow_PvPTiersIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 77:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuest((int)methodParameters[0], (Action<Json_Wow_Quest>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 78:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestArea((int)methodParameters[0], (Action<Json_Wow_QuestArea>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 79:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestAreasIndex((Action<Json_Wow_QuestAreasIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 80:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestCategoriesIndex((Action<Json_Wow_QuestCategoriesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 81:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestCategory((int)methodParameters[0], (Action<Json_Wow_QuestCategory>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 82:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestType((int)methodParameters[0], (Action<Json_Wow_QuestType>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 83:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestTypesIndex((Action<Json_Wow_QuestTypesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 84:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestsIndex((Action<Json_Wow_QuestsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 85:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRealm((string)methodParameters[0], (Action<Json_Wow_Realm>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 86:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRealm((int)methodParameters[0], (Action<Json_Wow_Realm>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 87:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRealmsIndex((Action<Json_Wow_RealmsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 88:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRegion((int)methodParameters[0], (Action<Json_Wow_Region>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 89:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRegionsIndex((Action<Json_Wow_RegionsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 90:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationFaction((int)methodParameters[0], (Action<Json_Wow_ReputationFaction>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 91:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationFactionsIndex((Action<Json_Wow_ReputationFactionsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 92:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationTiers((int)methodParameters[0], (Action<Json_Wow_ReputationTiers>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 93:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationTiersIndex((Action<Json_Wow_ReputationTiersIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 94:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetSpell((int)methodParameters[0], (Action<Json_Wow_Spell>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 95:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetSpellMedia((int)methodParameters[0], (Action<Json_Wow_SpellMedia>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 96:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTalent((int)methodParameters[0], (Action<Json_Wow_PvPTalent>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 97:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTalentsIndex((Action<Json_Wow_PvPTalentsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 98:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalent((int)methodParameters[0], (Action<Json_Wow_Talent>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 99:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalentsIndex((Action<Json_Wow_TalentsIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 100:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTitle((int)methodParameters[0], (Action<Json_Wow_Title>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3], (BattleNetRegion)methodParameters[4]));
					break;
				case 101:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTitlesIndex((Action<Json_Wow_TitlesIndex>)methodParameters[0], (string)methodParameters[1], (Action<string>)methodParameters[2], (BattleNetRegion)methodParameters[3]));
					break;
				case 102:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetWoWTokenIndex((BattleNetRegion)methodParameters[0], (Action<Json_Wow_WoWTokenIndex>)methodParameters[1], (string)methodParameters[2], (Action<string>)methodParameters[3]));
					break;
				default:
					break;
			}
		}

		private static void StartWowProfileAPICall(int method, object[] methodParameters)
		{
			switch (method)
			{
				case 0:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterAchievementStatistics((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterAchievementStatistics>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterAchievementsSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterAchievementsSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterAppearanceSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterAppearanceSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterCollectionsIndex((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterCollectionsIndex>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMountsCollectionSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterMountsCollectionSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterPetsCollectionSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterPetsCollectionSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterDungeons((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterDungeons>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterEncountersSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterEncountersSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterRaids((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterRaids>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterEquipmentSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterEquipmentSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterHunterPetsSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterHunterPetsSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMediaSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterMediaSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMythicKeystoneProfileIndex((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterMythicKeystoneProfileIndex>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMythicKeystoneSeasonDetails((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (int)methodParameters[3], (Action<Json_Wow_CharacterMythicKeystoneSeasonDetails>)methodParameters[4], (string)methodParameters[5], (Action<string>)methodParameters[6]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterProfessionsSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterProfessionsSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterProfileStatus((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterProfileStatus>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterProfileSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterProfileSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterPvPBracketStatistics((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (string)methodParameters[3], (Action<Json_Wow_CharacterPvPBracketStatistics>)methodParameters[4], (string)methodParameters[5], (Action<string>)methodParameters[6]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterPvPSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterPvPSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 19:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterCompletedQuests((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterCompletedQuests>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 20:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterQuests((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterQuests>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 21:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterReputationsSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterReputationsSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 22:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterSpecializationsSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterSpecializationsSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 23:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterStatisticsSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterStatisticsSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 24:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterTitlesSummary((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_CharacterTitlesSummary>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 25:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuild((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_Guild>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 26:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuildAchievements((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_GuildAchievements>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 27:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuildActivity((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_GuildActivity>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				case 28:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuildRoster((BattleNetRegion)methodParameters[0], (string)methodParameters[1], (string)methodParameters[2], (Action<Json_Wow_GuildRoster>)methodParameters[3], (string)methodParameters[4], (Action<string>)methodParameters[5]));
					break;
				default:
					break;
			}
		}
	}
}
