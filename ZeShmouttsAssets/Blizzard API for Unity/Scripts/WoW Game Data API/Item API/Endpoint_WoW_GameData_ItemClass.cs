namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft item classes.
	/// </summary>
	[System.Serializable]
	public class WowItemClass_JSON : Object_Json
	{
		public LinkStruct _links;

		public int class_id;
		public LocalizedString name;
		public RefNameIdStruct[] item_subclasses;
	}
}