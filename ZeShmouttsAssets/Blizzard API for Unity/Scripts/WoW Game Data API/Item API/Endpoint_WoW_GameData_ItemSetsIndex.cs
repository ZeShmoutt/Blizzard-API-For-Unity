namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft item sets.
	/// </summary>
	[System.Serializable]
	public class WowItemSetsIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] item_sets;
	}
}