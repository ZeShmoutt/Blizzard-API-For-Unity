namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's professions.
	/// </summary>
	[System.Serializable]
	public class WowCharacterProfessionsSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		[System.Serializable]
		public struct Profession
		{
			public RefNameIdStruct profession;
			public ProfessionTier[] tiers;
		}

		[System.Serializable]
		public struct ProfessionTier
		{
			public int skill_points;
			public int max_skill_points;
			public ProfessionTierNameId tier;

			public RefNameIdStruct[] known_recipes;
		}

		[System.Serializable]
		public struct ProfessionTierNameId
		{
			public string name;
			public int id;
		}

		public Profession[] primaries;
		public Profession[] secondaries;
	}
}