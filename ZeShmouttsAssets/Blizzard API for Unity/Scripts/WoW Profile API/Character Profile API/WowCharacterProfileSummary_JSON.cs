namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft characters.
	/// </summary>
	[System.Serializable]
	public class WowCharacterProfileSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public string name;

		public TypeNameStruct gender;
		public TypeNameStruct faction;

		public RefNameIdStruct race;
		public RefNameIdStruct character_class;
		public RefNameIdStruct active_spec;

		public RealmStruct realm;

		public GuildStruct guild;

		public int level;
		public int experience;
		public int achievement_points;

		public HRefStruct achievements;
		public HRefStruct titles;
		public HRefStruct pvp_summary;
		public HRefStruct raid_progression;
		public HRefStruct media;

		public int last_login_timestamp;
		public int average_item_level;
		public int equipped_item_level;

		public HRefStruct specializations;
		public HRefStruct statistics;
		public HRefStruct mythic_keystone_profile;
		public HRefStruct equipment;
		public HRefStruct appearance;
		public HRefStruct collections;

		public HRefStruct reputations;
		public HRefStruct quests;
	}
}