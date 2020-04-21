namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's medias.
	/// </summary>
	[System.Serializable]
	public class WowCharacterMediaSummary_JSON : Object_Json
	{
		public LinkStruct _links;

		[System.Serializable]
		public struct CharacterStruct
		{
			public HRefStruct key;
			public string name;
			public int id;
			public RealmStruct realm;
		}
		public CharacterStruct character;
		public string avatar_url;
		public string bust_url;
		public string render_url;
	}
}