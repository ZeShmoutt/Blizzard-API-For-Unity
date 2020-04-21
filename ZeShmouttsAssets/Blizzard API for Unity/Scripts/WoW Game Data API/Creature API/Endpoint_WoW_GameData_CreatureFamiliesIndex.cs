namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft creature families.
	/// </summary>
	[System.Serializable]
	public class WowCreatureFamiliesIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] creature_families;
	}
}