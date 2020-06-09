namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		/// <summary>
		/// API endpoints related to StarCraft II game data.
		/// Reference : https://develop.battle.net/documentation/starcraft-2/game-data-apis
		/// </summary>
		public static partial class SC2GameData
		{
			public enum Queue
			{
				WoL_1v1 = 1,
				WoL_2v2 = 2,
				WoL_3v3 = 3,
				WoL_4v4 = 4,
				HotS_1v1 = 101,
				HotS_2v2 = 102,
				HotS_3v3 = 103,
				HotS_4v4 = 104,
				LotV_1v1 = 201,
				LotV_2v2 = 202,
				LotV_3v3 = 203,
				LotV_4v4 = 204,
				LotV_Archon = 206
			}

			public enum TeamType
			{
				Arranged = 0,
				Random = 1
			}

			public enum League
			{
				Bronze = 0,
				Silver = 1,
				Gold = 2,
				Platinum = 3,
				Diamond = 4,
				Master = 5,
				Grandmaster = 6
			}
		}
	}
}