namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft creature types.
	/// </summary>
	[System.Serializable]
	public class WowCreatureType_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
	}
}