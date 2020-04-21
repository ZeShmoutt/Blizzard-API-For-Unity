using System;
using System.Globalization;
using UnityEngine;
using ZeShmouttsAssets.BlizzardAPI;
using ZeShmouttsAssets.BlizzardAPI.JSON;

public class BlizzardAPI_Example : MonoBehaviour
{
	private WoWAchievement_JSON achievement;
	private DateTime lastModified;

	void Start()
	{
		// Retrieve informations about the World of Warcraft achievement "The Loremaster" (https://www.wowhead.com/achievement=7520/)
		// When the data has been retrieved, log a message in the console with some of the retrieved infos.
		StartCoroutine(BlizzardAPI.WowGameData.GetAchievement(7520, SetAchievement, SetLastModified));
	}

	void SetAchievement(WoWAchievement_JSON json)
	{
		achievement = json;

		DebugMessageWhenBothRetrieved();
	}

	void SetLastModified(string lastModifiedString)
	{
		lastModified = DateTime.ParseExact(lastModifiedString, "r", CultureInfo.InvariantCulture);

		DebugMessageWhenBothRetrieved();
	}

	void DebugMessageWhenBothRetrieved()
	{
		if (achievement != null && lastModified != DateTime.MinValue)
		{
			Debug.LogFormat(
				"Name = '{0}' ; Description = '{1}' ; Value = {2} points (last modified : {3})",
				achievement.name.en_US,
				achievement.description.en_US,
				achievement.points,
				lastModified.ToString()
			);
		}
	}
}