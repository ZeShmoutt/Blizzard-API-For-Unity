namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft profession.
	/// </summary>
	[System.Serializable]
	public class WowProfession_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public LocalizedString description;
		public TypeNameStruct type;
		public RefIdStruct media;

		public RefNameIdStruct[] skill_tiers;
	}
}