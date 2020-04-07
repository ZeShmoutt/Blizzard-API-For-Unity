using UnityEngine;
using ZeShmouttsAssets.BlizzardAPI;
using ZeShmouttsAssets.BlizzardAPI.JSON;

public class BlizzardAPI_Example : MonoBehaviour
{
	void Start()
	{
		//Retrieve informations about the World of Warcraft achievement "The Loremaster" (https://www.wowhead.com/achievement=7520/)
		StartCoroutine(BlizzardAPI_WowGameData.CGetAchievement(API.BattleNetRegion.UnitedStates, 7520, DebugMessage));
	}

	void DebugMessage(WoWAchievement_JSON achievement)
	{
		Debug.LogFormat("Name = '{0}' ; Description = '{1}' ; Value = {2} points", achievement.name.en_US, achievement.description.en_US, achievement.points);
	}
}