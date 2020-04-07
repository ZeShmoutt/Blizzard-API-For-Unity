namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft realms index.
	/// </summary>
	[System.Serializable]
	public class WowRealmsIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RealmStruct[] realms;
	}
}