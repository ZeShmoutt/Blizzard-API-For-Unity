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
			/// Coroutine that retrieves a list of all WoW auctions in a specific connected realm.
			/// </summary>
			/// <param name="connectedRealmId">The ID of the connected realm.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <returns></returns>
			public static IEnumerator GetAuctions(int connectedRealmId, Action<WowAuctions_JSON> action_Result, Action<string> action_LastModified = null, BattleNetRegion region = BattleNetRegion.UnitedStates)
			{
				string path = string.Format("/data/wow/connected-realm/{0}/auctions", connectedRealmId);
				yield return SendRequest(region, namespaceDynamic, path, action_Result, action_LastModified: action_LastModified);
			}
		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for an index of World of Warcraft auctions.
	/// </summary>
	[Serializable]
	public class WowAuctions_JSON : Object_Json
	{
		public LinkStruct _links;

		public HRefStruct connected_realm;

		[Serializable]
		public struct AuctionItemModifier
		{
			public int type;
			public int value;
		}

		[Serializable]
		public struct AuctionItem
		{
			public int id;
			public int context;
			public int[] bonus_lists;
			public AuctionItemModifier[] modifiers;
			public int pet_breed_id;
			public int pet_level;
			public int pet_quality_id;
			public int pet_species_id;
		}

		[Serializable]
		public struct Auction
		{
			public int id;
			public AuctionItem item;
			public int buyout;
			public int quantity;
			public string time_left;
		}

		public Auction[] auctions;
	}
}