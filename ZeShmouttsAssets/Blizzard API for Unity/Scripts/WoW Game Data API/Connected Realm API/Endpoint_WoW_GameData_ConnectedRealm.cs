namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft connected realms.
	/// </summary>
	[System.Serializable]
	public class WowConnectedRealm_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public bool has_queue;
		public TypeNameStruct status;
		public TypeNameStruct population;
		public WowRealm_JSON[] realms;

		public HRefStruct mythic_leaderboards;
		public HRefStruct auctions;
	}
}