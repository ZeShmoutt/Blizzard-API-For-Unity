namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft profession skill tier.
	/// </summary>
	[System.Serializable]
	public class WowProfessionSkillTier_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public int minimum_skill_level;
		public int maximum_skill_level;

		[System.Serializable]
		public struct ProfessionSkillTierCategory
		{
			public LocalizedString name;
			public RefNameIdStruct[] recipes;
		}
		public ProfessionSkillTierCategory[] categories;
	}
}