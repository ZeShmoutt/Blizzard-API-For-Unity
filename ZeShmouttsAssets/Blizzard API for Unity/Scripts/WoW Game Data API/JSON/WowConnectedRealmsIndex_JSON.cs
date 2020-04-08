namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft connected realms.
	/// </summary>
	[System.Serializable]
	public class WowConnectedRealmsIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public HRefStruct[] connected_realms;
	}
}