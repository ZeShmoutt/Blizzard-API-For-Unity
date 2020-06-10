using System;

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for Diablo III, representing a leaderboard.
	/// </summary>
	[Serializable]
	public abstract class Json_D3_Leaderboard : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		[Serializable]
		public struct Data
		{
			public string id;
			public int number;
			public long timestamp;
			public string @string;
		}

		[Serializable]
		public struct Player
		{
			public string key;
			public int accountId;
			public Data[] data;
		}

		[Serializable]
		public struct Row
		{
			public Player player;
			public int order;
			public Data[] data;
		}
		public Row[] row;

		public string key;
		public LocalizedString title;

		[Serializable]
		public struct Column
		{
			public string id;
			public bool hidden;
			public int order;
			public LocalizedString label;
			public string type;
		}
		public Column[] column;

		public string last_update_time;
		public string generated_by;
		public bool achievement_points;
		public bool hardcore;
		public bool greater_rift;
		public string greater_rift_solo_class;
		public int greater_rift_team_size;
		// {{JSON_END}}
	}
}
