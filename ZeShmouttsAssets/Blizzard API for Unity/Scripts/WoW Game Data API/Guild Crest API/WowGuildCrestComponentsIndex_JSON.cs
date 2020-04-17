namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft guild crest components.
	/// </summary>
	[System.Serializable]
	public class WowGuildCrestComponentsIndex_JSON : Object_Json
	{
		public LinkStruct _links;

		[System.Serializable]
		public struct GuildCrestEmblem
		{
			public int id;
			public RefIdStruct media;
		}

		public GuildCrestEmblem[] emblems;
	}
}