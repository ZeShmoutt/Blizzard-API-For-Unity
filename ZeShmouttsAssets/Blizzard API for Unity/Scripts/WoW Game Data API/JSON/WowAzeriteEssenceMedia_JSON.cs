namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft azerite essence media.
	/// </summary>
	[System.Serializable]
	public class WowAzeriteEssenceMedia_JSON : Object_Json
	{
		public LinkStruct _links;

		public KeyValueStruct[] assets;
		public int id;
	}
}