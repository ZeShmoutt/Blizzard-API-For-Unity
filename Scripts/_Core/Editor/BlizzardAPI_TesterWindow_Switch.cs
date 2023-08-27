// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

#if UNITY_EDITORCOROUTINES
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
					StartD3GameDataAPICall(method, methodParameters);
					break;
				case 1:
					StartHearthstoneGameDataAPICall(method, methodParameters);
					break;
				case 2:
					StartSC2GameDataAPICall(method, methodParameters);
					break;
				case 3:
					StartWowClassicGameDataAPICall(method, methodParameters);
					break;
				case 4:
					StartWowGameDataAPICall(method, methodParameters);
					break;
				case 5:
					StartWowProfileAPICall(method, methodParameters);
					break;
				default:
					break;
			}
		}

		private static void StartD3GameDataAPICall(int method, object[] methodParameters)
		{
			switch (method)
			{
				case 0:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.D3GameData.GetEra(seasonId: (int)methodParameters[0], action_Result: (Action<Json_D3_Era>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.D3GameData.GetEraIndex(action_Result: (Action<Json_D3_EraIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.D3GameData.GetEraLeaderboard(seasonId: (int)methodParameters[0], leaderboard: (string)methodParameters[1], action_Result: (Action<Json_D3_EraLeaderboard>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.D3GameData.GetSeason(seasonId: (int)methodParameters[0], action_Result: (Action<Json_D3_Season>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.D3GameData.GetSeasonIndex(action_Result: (Action<Json_D3_SeasonIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.D3GameData.GetSeasonLeaderboard(seasonId: (int)methodParameters[0], leaderboard: (string)methodParameters[1], action_Result: (Action<Json_D3_SeasonLeaderboard>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				default:
					break;
			}
		}

		private static void StartHearthstoneGameDataAPICall(int method, object[] methodParameters)
		{
			switch (method)
			{
				case 0:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.CardBackSearch(searchParameters: (HearthstoneCardBackSearch)methodParameters[0], action_Result: (Action<Json_Hearthstone_CardBacksList>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.FetchOneCardBack(cardBackId: (int)methodParameters[0], action_Result: (Action<Json_Hearthstone_CardBack>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.CardSearch(searchParameters: (HearthstoneCardSearch)methodParameters[0], action_Result: (Action<Json_Hearthstone_CardsList>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.FetchOneCard(cardId: (int)methodParameters[0], action_Result: (Action<Json_Hearthstone_Card>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.FetchDeck(deckCode: (string)methodParameters[0], action_Result: (Action<Json_Hearthstone_Deck>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataAll(action_Result: (Action<Json_Hearthstone_MetadataList>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataArenaIds(action_Result: (Action<int[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataCardBackCategories(action_Result: (Action<Json_Hearthstone_Metadata_CardBackCategory[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataClasses(action_Result: (Action<Json_Hearthstone_Metadata_Class[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataFilterableFields(action_Result: (Action<string[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataGameModes(action_Result: (Action<Json_Hearthstone_Metadata_GameMode[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataKeywords(action_Result: (Action<Json_Hearthstone_Metadata_Keyword[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataMinionTypes(action_Result: (Action<Json_Hearthstone_Metadata_MinionType[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataNumericFields(action_Result: (Action<string[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataRarities(action_Result: (Action<Json_Hearthstone_Metadata_Rarity[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataSetGroups(action_Result: (Action<Json_Hearthstone_Metadata_SetGroup[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataSets(action_Result: (Action<Json_Hearthstone_Metadata_Set[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataSpellSchools(action_Result: (Action<Json_Hearthstone_Metadata_SpellSchool[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.HearthstoneGameData.GetMetadataTypes(action_Result: (Action<Json_Hearthstone_Metadata_Type[]>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				default:
					break;
			}
		}

		private static void StartSC2GameDataAPICall(int method, object[] methodParameters)
		{
			switch (method)
			{
				case 0:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.SC2GameData.GetLeagueData(region: (BattleNetRegion)methodParameters[0], seasonId: (int)methodParameters[1], queue: (BlizzardAPI.SC2GameData.Queue)methodParameters[2], teamType: (BlizzardAPI.SC2GameData.TeamType)methodParameters[3], league: (BlizzardAPI.SC2GameData.League)methodParameters[4], action_Result: (Action<Json_SC2_GetLeagueData>)methodParameters[5], ifModifiedSince: (string)methodParameters[6], action_LastModified: (Action<string>)methodParameters[7], action_OnError: (Action<string>)methodParameters[8]));
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
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetConnectedRealm(connectedRealmId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_ConnectedRealm>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetConnectedRealmsIndex(action_Result: (Action<Json_WowClassic_ConnectedRealmsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreature(creatureId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_Creature>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureDisplayMedia(creatureDisplayId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_CreatureDisplayMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureFamiliesIndex(action_Result: (Action<Json_WowClassic_CreatureFamiliesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureFamily(creatureFamilyId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_CreatureFamily>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureFamilyMedia(creatureFamilyId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_CreatureFamilyMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureType(creatureTypeId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_CreatureType>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetCreatureTypesIndex(action_Result: (Action<Json_WowClassic_CreatureTypesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetGuildCrestBorderMedia(borderId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_GuildCrestBorderMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetGuildCrestComponentsIndex(action_Result: (Action<Json_WowClassic_GuildCrestComponentsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetGuildCrestEmblemMedia(emblemId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_GuildCrestEmblemMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItem(itemId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_Item>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemClass(itemClassId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_ItemClass>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemClassesIndex(action_Result: (Action<Json_WowClassic_ItemClassesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemMedia(itemId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_ItemMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetItemSubclass(itemClassId: (int)methodParameters[0], itemSubclassId: (int)methodParameters[1], action_Result: (Action<Json_WowClassic_ItemSubclass>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableClass(classId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_PlayableClass>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableClassesIndex(action_Result: (Action<Json_WowClassic_PlayableClassesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 19:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableClassMedia(playableClassId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_PlayableClassMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 20:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableRace(playableRaceId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_PlayableRace>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 21:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPlayableRacesIndex(action_Result: (Action<Json_WowClassic_PlayableRacesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 22:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPowerType(powerTypeId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_PowerType>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 23:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetPowerTypesIndex(action_Result: (Action<Json_WowClassic_PowerTypesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 24:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetRealm(realmSlug: (string)methodParameters[0], action_Result: (Action<Json_WowClassic_Realm>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 25:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetRealm(realmId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_Realm>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 26:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetRealmsIndex(action_Result: (Action<Json_WowClassic_RealmsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 27:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetRegion(regionId: (int)methodParameters[0], action_Result: (Action<Json_WowClassic_Region>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 28:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetRegionsIndex(action_Result: (Action<Json_WowClassic_RegionsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 29:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowClassicGameData.GetWoWTokenIndex(action_Result: (Action<Json_WowClassic_WoWTokenIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2]));
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
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievement(achievementId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Achievement>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementCategoriesIndex(action_Result: (Action<Json_Wow_AchievementCategoriesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementCategory(achievementCategoryId: (int)methodParameters[0], action_Result: (Action<Json_Wow_AchievementCategory>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementMedia(achievementId: (int)methodParameters[0], action_Result: (Action<Json_Wow_AchievementMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAchievementsIndex(action_Result: (Action<Json_Wow_AchievementsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAuctions(connectedRealmId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Auctions>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCommodities(action_Result: (Action<Json_Wow_Commodities>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAzeriteEssence(azeriteEssenceId: (int)methodParameters[0], action_Result: (Action<Json_Wow_AzeriteEssence>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAzeriteEssenceMedia(azeriteEssenceId: (int)methodParameters[0], action_Result: (Action<Json_Wow_AzeriteEssenceMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetAzeriteEssencesIndex(action_Result: (Action<Json_Wow_AzeriteEssencesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetConnectedRealm(connectedRealmId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ConnectedRealm>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetConnectedRealmsIndex(action_Result: (Action<Json_Wow_ConnectedRealmsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetConduit(conduitId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Conduit>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetConduitIndex(action_Result: (Action<Json_Wow_ConduitIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCovenant(covenantId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Covenant>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCovenantIndex(action_Result: (Action<Json_Wow_CovenantIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCovenantMedia(covenantId: (int)methodParameters[0], action_Result: (Action<Json_Wow_CovenantMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetSoulbind(soulbindId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Soulbind>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetSoulbindIndex(action_Result: (Action<Json_Wow_SoulbindIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 19:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreature(creatureId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Creature>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 20:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureDisplayMedia(creatureDisplayId: (int)methodParameters[0], action_Result: (Action<Json_Wow_CreatureDisplayMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 21:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureFamiliesIndex(action_Result: (Action<Json_Wow_CreatureFamiliesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 22:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureFamily(creatureFamilyId: (int)methodParameters[0], action_Result: (Action<Json_Wow_CreatureFamily>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 23:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureFamilyMedia(creatureFamilyId: (int)methodParameters[0], action_Result: (Action<Json_Wow_CreatureFamilyMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 24:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureType(creatureTypeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_CreatureType>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 25:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetCreatureTypesIndex(action_Result: (Action<Json_Wow_CreatureTypesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 26:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetGuildCrestBorderMedia(borderId: (int)methodParameters[0], action_Result: (Action<Json_Wow_GuildCrestBorderMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 27:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetGuildCrestComponentsIndex(action_Result: (Action<Json_Wow_GuildCrestComponentsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 28:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetGuildCrestEmblemMedia(emblemId: (int)methodParameters[0], action_Result: (Action<Json_Wow_GuildCrestEmblemMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 29:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetHeirloom(heirloomId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Heirloom>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 30:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetHeirloomIndex(action_Result: (Action<Json_Wow_HeirloomIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 31:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItem(itemId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Item>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 32:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemClass(itemClassId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ItemClass>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 33:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemClassesIndex(action_Result: (Action<Json_Wow_ItemClassesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 34:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemMedia(itemId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ItemMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 35:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemSet(itemSetId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ItemSet>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 36:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemSetsIndex(action_Result: (Action<Json_Wow_ItemSetsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 37:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetItemSubclass(itemClassId: (int)methodParameters[0], itemSubclassId: (int)methodParameters[1], action_Result: (Action<Json_Wow_ItemSubclass>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 38:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalEncounter(journalEncounterId: (int)methodParameters[0], action_Result: (Action<Json_Wow_JournalEncounter>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 39:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalEncountersIndex(action_Result: (Action<Json_Wow_JournalEncountersIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 40:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalExpansion(journalExpansionId: (int)methodParameters[0], action_Result: (Action<Json_Wow_JournalExpansion>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 41:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalExpansionsIndex(action_Result: (Action<Json_Wow_JournalExpansionsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 42:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalInstance(journalInstanceId: (int)methodParameters[0], action_Result: (Action<Json_Wow_JournalInstance>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 43:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalInstanceMedia(journalInstanceId: (int)methodParameters[0], action_Result: (Action<Json_Wow_JournalInstanceMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 44:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetJournalInstancesIndex(action_Result: (Action<Json_Wow_JournalInstancesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 45:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetModifiedCraftingCategory(categoryId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ModifiedCraftingCategory>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 46:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetModifiedCraftingCategoryIndex(action_Result: (Action<Json_Wow_ModifiedCraftingCategoryIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 47:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetModifiedCraftingIndex(action_Result: (Action<Json_Wow_ModifiedCraftingIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 48:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetModifiedCraftingReagentSlotType(slotTypeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ModifiedCraftingReagentSlotType>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 49:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetModifiedCraftingReagentSlotTypeIndex(action_Result: (Action<Json_Wow_ModifiedCraftingReagentSlotTypeIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 50:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMount(mountId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Mount>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 51:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMountsIndex(action_Result: (Action<Json_Wow_MountsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 52:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneAffix(keystoneAffixId: (int)methodParameters[0], action_Result: (Action<Json_Wow_MythicKeystoneAffix>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 53:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneAffixesIndex(action_Result: (Action<Json_Wow_MythicKeystoneAffixesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 54:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneAffixMedia(keystoneAffixId: (int)methodParameters[0], action_Result: (Action<Json_Wow_MythicKeystoneAffixMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 55:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneDungeon(dungeonId: (int)methodParameters[0], action_Result: (Action<Json_Wow_MythicKeystoneDungeon>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 56:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneDungeonsIndex(action_Result: (Action<Json_Wow_MythicKeystoneDungeonsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 57:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneIndex(action_Result: (Action<Json_Wow_MythicKeystoneIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 58:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystonePeriod(periodId: (int)methodParameters[0], action_Result: (Action<Json_Wow_MythicKeystonePeriod>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 59:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystonePeriodsIndex(action_Result: (Action<Json_Wow_MythicKeystonePeriodsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 60:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneSeason(seasonId: (int)methodParameters[0], action_Result: (Action<Json_Wow_MythicKeystoneSeason>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 61:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneSeasonsIndex(action_Result: (Action<Json_Wow_MythicKeystoneSeasonsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 62:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneLeaderboard(connectedRealmId: (int)methodParameters[0], dungeonId: (int)methodParameters[1], period: (int)methodParameters[2], action_Result: (Action<Json_Wow_MythicKeystoneLeaderboard>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6], region: (BattleNetRegion)methodParameters[7]));
					break;
				case 63:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicKeystoneLeaderboardsIndex(connectedRealmId: (int)methodParameters[0], action_Result: (Action<Json_Wow_MythicKeystoneLeaderboardsIndex>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 64:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetMythicRaidLeaderboard(raid: (string)methodParameters[0], faction: (string)methodParameters[1], action_Result: (Action<Json_Wow_MythicRaidLeaderboard>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 65:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPet(petId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Pet>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 66:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPetAbilitiesIndex(action_Result: (Action<Json_Wow_PetAbilitiesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 67:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPetAbility(petAbilityId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PetAbility>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 68:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPetAbilityMedia(petAbilityId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PetAbilityMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 69:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPetMedia(petId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PetMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 70:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPetsIndex(action_Result: (Action<Json_Wow_PetsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 71:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableClass(classId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PlayableClass>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 72:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableClassesIndex(action_Result: (Action<Json_Wow_PlayableClassesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 73:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableClassMedia(playableClassId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PlayableClassMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 74:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTalentSlots(classId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPTalentSlots>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 75:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableRace(playableRaceId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PlayableRace>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 76:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableRacesIndex(action_Result: (Action<Json_Wow_PlayableRacesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 77:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableSpecialization(specId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PlayableSpecialization>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 78:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableSpecializationMedia(specId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PlayableSpecializationMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 79:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPlayableSpecializationsIndex(action_Result: (Action<Json_Wow_PlayableSpecializationsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 80:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPowerType(powerTypeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PowerType>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 81:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPowerTypesIndex(action_Result: (Action<Json_Wow_PowerTypesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 82:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfession(professionId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Profession>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 83:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfessionMedia(professionId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ProfessionMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 84:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfessionsIndex(action_Result: (Action<Json_Wow_ProfessionsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 85:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetProfessionSkillTier(professionId: (int)methodParameters[0], skillTierId: (int)methodParameters[1], action_Result: (Action<Json_Wow_ProfessionSkillTier>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 86:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRecipe(recipeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Recipe>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 87:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRecipeMedia(recipeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_RecipeMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 88:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPLeaderboard(pvpSeasonId: (int)methodParameters[0], pvpBracket: (string)methodParameters[1], action_Result: (Action<Json_Wow_PvPLeaderboard>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 89:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPLeaderboardsIndex(pvpSeasonId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPLeaderboardsIndex>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 90:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPRewardsIndex(pvpSeasonId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPRewardsIndex>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 91:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPSeason(pvpSeasonId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPSeason>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 92:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPSeasonsIndex(action_Result: (Action<Json_Wow_PvPSeasonsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 93:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTier(pvpTierId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPTier>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 94:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTierMedia(pvpTierId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPTierMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 95:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTiersIndex(action_Result: (Action<Json_Wow_PvPTiersIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 96:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuest(questId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Quest>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 97:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestArea(questAreaId: (int)methodParameters[0], action_Result: (Action<Json_Wow_QuestArea>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 98:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestAreasIndex(action_Result: (Action<Json_Wow_QuestAreasIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 99:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestCategoriesIndex(action_Result: (Action<Json_Wow_QuestCategoriesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 100:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestCategory(questCategoryId: (int)methodParameters[0], action_Result: (Action<Json_Wow_QuestCategory>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 101:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestsIndex(action_Result: (Action<Json_Wow_QuestsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 102:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestType(questTypeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_QuestType>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 103:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetQuestTypesIndex(action_Result: (Action<Json_Wow_QuestTypesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 104:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRealm(realmSlug: (string)methodParameters[0], action_Result: (Action<Json_Wow_Realm>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 105:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRealm(realmId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Realm>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 106:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRealmsIndex(action_Result: (Action<Json_Wow_RealmsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 107:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRegion(regionId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Region>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 108:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetRegionsIndex(action_Result: (Action<Json_Wow_RegionsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 109:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationFaction(reputationFactionId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ReputationFaction>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 110:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationFactionsIndex(action_Result: (Action<Json_Wow_ReputationFactionsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 111:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationTiers(reputationTiersId: (int)methodParameters[0], action_Result: (Action<Json_Wow_ReputationTiers>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 112:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetReputationTiersIndex(action_Result: (Action<Json_Wow_ReputationTiersIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 113:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetSpell(spellId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Spell>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 114:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetSpellMedia(spellId: (int)methodParameters[0], action_Result: (Action<Json_Wow_SpellMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 115:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTalent(pvpTalentId: (int)methodParameters[0], action_Result: (Action<Json_Wow_PvPTalent>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 116:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetPvPTalentsIndex(action_Result: (Action<Json_Wow_PvPTalentsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 117:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalent(talentId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Talent>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 118:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalentsIndex(action_Result: (Action<Json_Wow_TalentsIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 119:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalentTree(talentTreeId: (int)methodParameters[0], specId: (int)methodParameters[1], action_Result: (Action<Json_Wow_TalentTree>)methodParameters[2], ifModifiedSince: (string)methodParameters[3], action_LastModified: (Action<string>)methodParameters[4], action_OnError: (Action<string>)methodParameters[5], region: (BattleNetRegion)methodParameters[6]));
					break;
				case 120:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalentTreeIndex(action_Result: (Action<Json_Wow_TalentTreeIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 121:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTalentTreeNodes(talentTreeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_TalentTreeNodes>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 122:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTechTalent(techTalentId: (int)methodParameters[0], action_Result: (Action<Json_Wow_TechTalent>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 123:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTechTalentIndex(action_Result: (Action<Json_Wow_TechTalentIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 124:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTechTalentMedia(techTalentId: (int)methodParameters[0], action_Result: (Action<Json_Wow_TechTalentMedia>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 125:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTechTalentTree(techTalentTreeId: (int)methodParameters[0], action_Result: (Action<Json_Wow_TechTalentTree>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 126:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTechTalentTreeIndex(action_Result: (Action<Json_Wow_TechTalentTreeIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 127:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTitle(titleId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Title>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 128:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetTitlesIndex(action_Result: (Action<Json_Wow_TitlesIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 129:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetToy(toyId: (int)methodParameters[0], action_Result: (Action<Json_Wow_Toy>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4], region: (BattleNetRegion)methodParameters[5]));
					break;
				case 130:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetToyIndex(action_Result: (Action<Json_Wow_ToyIndex>)methodParameters[0], ifModifiedSince: (string)methodParameters[1], action_LastModified: (Action<string>)methodParameters[2], action_OnError: (Action<string>)methodParameters[3], region: (BattleNetRegion)methodParameters[4]));
					break;
				case 131:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowGameData.GetWoWTokenIndex(region: (BattleNetRegion)methodParameters[0], action_Result: (Action<Json_Wow_WoWTokenIndex>)methodParameters[1], ifModifiedSince: (string)methodParameters[2], action_LastModified: (Action<string>)methodParameters[3], action_OnError: (Action<string>)methodParameters[4]));
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
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterAchievementsSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterAchievementsSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 1:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterAchievementStatistics(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterAchievementStatistics>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 2:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterAppearanceSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterAppearanceSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 3:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterCollectionsIndex(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterCollectionsIndex>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 4:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterHeirloomsCollectionSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterHeirloomsCollectionSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 5:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMountsCollectionSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterMountsCollectionSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 6:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterPetsCollectionSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterPetsCollectionSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 7:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterToysCollectionSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterToysCollectionSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 8:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterDungeons(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterDungeons>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 9:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterEncountersSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterEncountersSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 10:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterRaids(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterRaids>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 11:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterEquipmentSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterEquipmentSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 12:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterHunterPetsSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterHunterPetsSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 13:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMediaSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterMediaSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 14:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMythicKeystoneProfileIndex(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterMythicKeystoneProfileIndex>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 15:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterMythicKeystoneSeasonDetails(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], seasonId: (int)methodParameters[3], action_Result: (Action<Json_Wow_CharacterMythicKeystoneSeasonDetails>)methodParameters[4], ifModifiedSince: (string)methodParameters[5], action_LastModified: (Action<string>)methodParameters[6], action_OnError: (Action<string>)methodParameters[7]));
					break;
				case 16:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterProfessionsSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterProfessionsSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 17:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterProfileStatus(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterProfileStatus>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 18:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterProfileSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterProfileSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 19:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterPvPBracketStatistics(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], pvpBracket: (string)methodParameters[3], action_Result: (Action<Json_Wow_CharacterPvPBracketStatistics>)methodParameters[4], ifModifiedSince: (string)methodParameters[5], action_LastModified: (Action<string>)methodParameters[6], action_OnError: (Action<string>)methodParameters[7]));
					break;
				case 20:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterPvPSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterPvPSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 21:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterCompletedQuests(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterCompletedQuests>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 22:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterQuests(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterQuests>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 23:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterReputationsSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterReputationsSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 24:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterSoulbinds(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterSoulbinds>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 25:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterSpecializationsSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterSpecializationsSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 26:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterStatisticsSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterStatisticsSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 27:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetCharacterTitlesSummary(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], characterName: (string)methodParameters[2], action_Result: (Action<Json_Wow_CharacterTitlesSummary>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 28:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuild(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], nameSlug: (string)methodParameters[2], action_Result: (Action<Json_Wow_Guild>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 29:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuildAchievements(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], nameSlug: (string)methodParameters[2], action_Result: (Action<Json_Wow_GuildAchievements>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 30:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuildActivity(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], nameSlug: (string)methodParameters[2], action_Result: (Action<Json_Wow_GuildActivity>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				case 31:
					EditorCoroutineUtility.StartCoroutineOwnerless(BlizzardAPI.WowProfile.GetGuildRoster(region: (BattleNetRegion)methodParameters[0], realmSlug: (string)methodParameters[1], nameSlug: (string)methodParameters[2], action_Result: (Action<Json_Wow_GuildRoster>)methodParameters[3], ifModifiedSince: (string)methodParameters[4], action_LastModified: (Action<string>)methodParameters[5], action_OnError: (Action<string>)methodParameters[6]));
					break;
				default:
					break;
			}
		}
	}
}
#endif