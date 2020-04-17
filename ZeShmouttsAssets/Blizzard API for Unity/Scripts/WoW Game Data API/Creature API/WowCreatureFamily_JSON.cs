namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft creature families.
	/// </summary>
	[System.Serializable]
	public class WowCreatureFamily_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefNameIdStruct specialization;

		public RefIdStruct media;
	}
}