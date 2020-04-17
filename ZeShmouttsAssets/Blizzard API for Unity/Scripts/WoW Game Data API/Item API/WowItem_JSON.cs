namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for stuff.
	/// </summary>
	[System.Serializable]
	public class WowItem_JSON : Object_Json
	{
		// Note : missing some stuff. Check with different item types (weapon, armor, consumable, etc.).

		public LinkStruct _links;

		public int id;
		public LocalizedString name;
		public TypeNameStruct quality;
		public int level;
		public int required_level;
		public RefIdStruct media;
		public RefNameIdStruct item_class;
		public RefNameIdStruct item_subclass;
		public TypeNameStruct inventory_type;
		public int purchase_price;
		public int sell_price;
		public int max_count;
		public bool is_equippable;
		public bool is_stackable;

		[System.Serializable]
		public struct ItemPreview
		{
			public RefIdStruct item;
			public TypeNameStruct quality;
			public LocalizedString name;
			public RefIdStruct media;
			public RefNameIdStruct item_class;
			public RefNameIdStruct item_subclass;
			public TypeNameStruct inventory_type;
			public TypeNameStruct binding;
			public LocalizedString unique_equipped;
		}
	}
}