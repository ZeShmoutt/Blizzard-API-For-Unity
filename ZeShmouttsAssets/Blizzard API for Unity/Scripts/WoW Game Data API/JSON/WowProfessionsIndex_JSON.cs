namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft professions.
	/// </summary>
	[System.Serializable]
	public class WowProfessionsIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		public RefNameIdStruct[] professions;
	}
}