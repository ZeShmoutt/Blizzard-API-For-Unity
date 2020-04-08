namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft azerite essence.
	/// </summary>
	[System.Serializable]
	public class WowAzeriteEssencesIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] azerite_essences;
	}
}