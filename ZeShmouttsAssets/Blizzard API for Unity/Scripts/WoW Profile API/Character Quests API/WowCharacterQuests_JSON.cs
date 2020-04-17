namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for a summary of a World of Warcraft character's active quests.
	/// </summary>
	[System.Serializable]
	public class WowCharacterQuests_JSON : Object_Json
	{
		public LinkStruct _links;

		public CharacterStruct character;
		public RefNameIdStruct[] in_progress;
		public HRefStruct completed;
	}
}