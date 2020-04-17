namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a World of Warcraft recipe.
	/// </summary>
	[System.Serializable]
	public class WowRecipe_JSON : Object_Json
	{
		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public RefIdStruct media;
		public RefNameIdStruct crafted_item;

		[System.Serializable]
		public struct Reagent
		{
			public RefNameIdStruct reagent;
			public int quantity;
		}
		public Reagent[] reagents;

		public int rank;
	}
}