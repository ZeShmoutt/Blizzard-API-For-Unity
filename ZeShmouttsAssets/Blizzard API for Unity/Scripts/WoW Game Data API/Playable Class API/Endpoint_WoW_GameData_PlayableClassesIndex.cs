namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft playable classes.
	/// </summary>
	[System.Serializable]
	public class WowPlayableClassesIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] classes;
	}
}