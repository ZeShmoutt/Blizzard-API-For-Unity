namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for the medias of a World of Warcraft playable class.
	/// </summary>
	[System.Serializable]
	public class WowPlayableClassMedia_JSON : Object_Json
	{
		public LinkStruct _links;

		public KeyValueStruct[] assets;
		public int id;
	}
}