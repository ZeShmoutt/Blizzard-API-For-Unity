namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for medias of a World of Warcraft creature.
	/// </summary>
	[System.Serializable]
	public class WowCreatureDisplayMedia_JSON : Object_Json
	{
		public LinkStruct _links;

		public KeyValueStruct[] assets;
		public int id;
	}
}