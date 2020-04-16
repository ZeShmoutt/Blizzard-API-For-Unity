namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's completed quests.
	/// </summary>
	[System.Serializable]
	public class WowCharacterCompletedQuests_JSON : Object_Json
	{
		public LinkStruct _links;

		public CharacterStruct character;
		public RefNameIdStruct[] quests;
	}
}