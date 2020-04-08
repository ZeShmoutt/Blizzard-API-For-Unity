namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft azerite essence.
	/// </summary>
	[System.Serializable]
	public class WowAzeriteEssence_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefNameIdStruct[] allowed_specializations;

		[System.Serializable]
		public struct AzeritePower
		{
			public int id;
			public int rank;
			public RefNameIdStruct main_power_spell;
			public RefNameIdStruct passive_power_spell;
		}
		public AzeritePower[] powers;
		public RefIdStruct media;
	}
}