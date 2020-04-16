namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft PvP talent slots.
	/// </summary>
	[System.Serializable]
	public class WowPvpTalentSlots_JSON : Object_Json
	{
		public LinkStruct _links;

		[System.Serializable]
		public struct TalentSlot
		{
			public int slot_number;
			public int unlock_player_level;
		}
		public TalentSlot[] talent_slots;
	}
}