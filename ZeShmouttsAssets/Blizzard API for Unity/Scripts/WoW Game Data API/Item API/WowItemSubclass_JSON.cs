namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft item subclasses.
	/// </summary>
	[System.Serializable]
	public class WowItemSubclass_JSON : Object_Json
	{
		public LinkStruct _links;

		public int class_id;
		public int subclass_id;
		public LocalizedString display_name;
		public bool hide_subclass_in_tooltips;
	}
}