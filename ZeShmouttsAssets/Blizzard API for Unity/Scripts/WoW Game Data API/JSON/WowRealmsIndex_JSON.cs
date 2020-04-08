namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft realms.
	/// </summary>
	[System.Serializable]
	public class WowRealmsIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RealmStruct[] realms;
	}
}