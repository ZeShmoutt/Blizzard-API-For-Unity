namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft playable races.
	/// </summary>
	[System.Serializable]
	public class WowPlayableRacesIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] races;
	}
}