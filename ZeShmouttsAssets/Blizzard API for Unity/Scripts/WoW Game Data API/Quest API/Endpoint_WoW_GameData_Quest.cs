// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

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
			internal const string apiPath_Quest = basePath_Wow_gameData + "/quest/{0}";

			/// <summary>
			/// Coroutine that retrieves a quest by ID.
			/// </summary>
			/// <param name="questId">The ID of the quest.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetQuest(int questId, Action<Json_Wow_Quest> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_Quest, questId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a quest by ID, as a raw JSON string.
			/// </summary>
			/// <param name="questId">The ID of the quest.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetQuestRaw(int questId, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = DefaultRegion)
			{
				string path = string.Format(apiPath_Quest, questId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a quest.
	/// </summary>
	[Serializable]
	public class Json_Wow_Quest : Object_JSON
	{
		// {{JSON_START}}
		// Note : probably incomplete

		public LinkStruct _links;

		public int id;
		public LocalizedString title;
		public RefNameIdStruct type;
		public RefNameIdStruct category;
		public RefNameIdStruct area;
		public LocalizedString description;
		public int recommended_minimum_level;
		public int recommended_maximum_level;

		[Serializable]
		public struct QuestRequirementOperator
		{
			public TypeNameStruct @operator;
			public QuestRequirementOperator[] conditions;
			public RefNameIdStruct target;
		}

		[Serializable]
		public struct QuestRequirement
		{
			public int min_character_level;
			public RefNameIdStruct[] races;
			public RefNameIdStruct[] classes;
			public TypeNameStruct faction;
			public QuestRequirementOperator quests;
		}
		public QuestRequirement requirements;


		[Serializable]
		public struct QuestRewardItemRequirement
		{
			public RefNameIdStruct[] playable_specializations;
		}

		[Serializable]
		public struct QuestRewardItem
		{
			public RefNameIdStruct item;
			public QuestRewardItemRequirement requirements;
		}

		public struct QuestRewardItems
		{
			public QuestRewardItem[] items;
			public QuestRewardItem[] choice_of;
		}

		[Serializable]
		public struct QuestRewardReputation
		{
			public RefNameIdStruct reward;
			public int value;
		}

		[Serializable]
		public struct QuestRewardMoneyUnits
		{
			public int gold;
			public int silver;
			public int copper;
		}

		[Serializable]
		public struct QuestRewardMoney
		{
			public int value;
			public QuestRewardMoneyUnits units;
		}

		[Serializable]
		public struct QuestRewards
		{
			public int experience;
			public QuestRewardItems items;
			public QuestRewardReputation[] reputations;
			public QuestRewardMoney money;
			public RefNameIdStruct spell;
		}
		public QuestRewards rewards;

		public bool is_repeatable;
		public bool is_daily;
		public bool is_weekly;
		// {{JSON_END}}
	}
}