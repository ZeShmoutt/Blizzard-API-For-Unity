namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft creature types.
	/// </summary>
	[System.Serializable]
	public class WowCreatureTypesIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] creature_types;
	}
}