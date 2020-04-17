namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for medias of a World of Warcraft guild crest border.
	/// </summary>
	[System.Serializable]
	public class WowGuildCrestBorderMedia_JSON : Object_Json
	{
		public LinkStruct _links;

		public KeyValueStruct[] assets;
		public int id;
	}
}