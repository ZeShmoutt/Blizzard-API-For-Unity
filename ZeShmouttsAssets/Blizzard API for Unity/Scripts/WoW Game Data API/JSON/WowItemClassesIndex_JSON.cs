namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft item classes.
	/// </summary>
	[System.Serializable]
	public class WowItemClassesIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] item_classes;
	}
}