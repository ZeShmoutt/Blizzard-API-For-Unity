using System;
using System.Collections;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		/// <summary>
		/// API endpoints related to World of Warcraft game data (items, spells, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/game-data-apis
		/// </summary>
		public static partial class WowGameData
		{
			/// <summary>
			/// Coroutine that retrieves a WoW item.
			/// </summary>
			/// <param name="itemId">The ID of the item.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetItem(int itemId, Action<WowItem_JSON> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/item/{0}", itemId);
				yield return SendRequest(region, namespaceStatic, path, action_Result, ifModifiedSince, action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for stuff.
	/// </summary>
	[Serializable]
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

		[Serializable]
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