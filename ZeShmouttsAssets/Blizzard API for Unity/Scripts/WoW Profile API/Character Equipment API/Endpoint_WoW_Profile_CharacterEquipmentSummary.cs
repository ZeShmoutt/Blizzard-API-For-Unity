// ╔════════════════════════════════════╗
// ║ This file has been auto-generated. ║
// ╚════════════════════════════════════╝

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
		/// API endpoints related to World of Warcraft profile data (characters, account, etc.).
		/// Reference : https://develop.battle.net/documentation/world-of-warcraft/profile-apis
		/// </summary>
		public static partial class WowProfile
		{
						/// <summary>
			/// Coroutine that retrieves a summary of the items equipped by a character.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the data once retrieved and converted.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterEquipmentSummary(BattleNetRegion region, string realmSlug, string characterName, Action<Json_Wow_CharacterEquipmentSummary> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + "/equipment";
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

			/// <summary>
			/// Coroutine that retrieves a summary of the items equipped by a character, as a raw JSON string.
			/// </summary>
			/// <param name="region">The region of the data to retrieve.</param>
			/// <param name="realmSlug">The slug of the realm.</param>
			/// <param name="characterName">The lowercase name of the character.</param>
			/// <param name="action_Result">Action to execute with the raw JSON string.</param>
			/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
			/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
			/// <returns></returns>
			public static IEnumerator GetCharacterEquipmentSummaryRaw(BattleNetRegion region, string realmSlug, string characterName, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
			{
				string path = FormatWowCharacterEndpointPath(realmSlug, characterName) + "/equipment";
				yield return SendRequest(region, namespaceProfile, path, action_Result, ifModifiedSince, action_LastModified);
			}

		}
	}
}

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	/// <summary>
	/// JSON structure for World of Warcraft, representing a summary of the items equipped by a character.
	/// </summary>
	[Serializable]
	public class Json_Wow_CharacterEquipmentSummary : Object_JSON
	{
		// {{JSON_START}}
		public LinkStruct _links;

		public CharacterStruct character;

		[Serializable]
		public struct EquippedItemTransmog
		{
			public RefNameIdStruct item;
			public LocalizedString display_string;
			public int item_modified_appearance_id;
		}

		[Serializable]
		public struct EquippedItemRequirement
		{
			public ValueIntDisplayStruct level;
			public ValueTypeDisplayStruct faction;
		}

		[Serializable]
		public struct EquippedItemStats
		{
			public TypeNameStruct type;
			public int value;
			public bool is_negated;
			public bool is_equip_bonus;
			public DisplayStringColorStruct display;
		}

		[Serializable]
		public struct EquippedItemArmor
		{
			public int value;
			public DisplayStringColorStruct display;
		}

		[Serializable]
		public struct EquippedItemValueDisplay
		{
			public LocalizedString header;
			public LocalizedString gold;
			public LocalizedString silver;
			public LocalizedString copper;
		}

		[Serializable]
		public struct EquippedItemValue
		{
			public int value;
			public EquippedItemValueDisplay display_strings;
		}

		[Serializable]
		public struct EquippedItemSpellTooltip
		{
			public RefNameIdStruct spell;
			public LocalizedString description;
			public LocalizedString cast_time;
			public ColorStruct display_color;
		}

		[Serializable]
		public struct EquippedItemAzeritePowers
		{
			public int id;
			public int tier;
			public EquippedItemSpellTooltip spell_tooltip;
			public bool is_display_hidden;
		}

		[Serializable]
		public struct EquippedItemAzeriteEssence
		{
			public int slot;
			public int rank;
			public EquippedItemSpellTooltip main_spell_tooltip;
			public EquippedItemSpellTooltip passive_spell_tooltip;
			public RefNameIdStruct essence;
			public RefIdStruct media;
		}

		[Serializable]
		public struct EquippedItemAzeriteDetails
		{
			// Heart of Azeroth
			public float percentage_to_next_level;
			public EquippedItemAzeriteEssence[] selected_essences;
			public ValueIntDisplayStruct level;

			// Azerite Armor
			public EquippedItemAzeritePowers[] selected_powers;
			public LocalizedString selected_powers_string;
		}

		[Serializable]
		public struct EquippedItemSocket
		{
			public TypeNameStruct socket_type;
			public RefNameIdStruct item;
			public LocalizedString display_string;
			public RefIdStruct media;
		}

		[Serializable]
		public struct EquippedItemEnchantment
		{
			public LocalizedString display_string;
			public RefNameIdStruct source_item;
			public int enchantment_id;
			public IdTypeStruct enchantment_slot;
			public EquippedItemSpellTooltip spell;
		}

		[Serializable]
		public struct EquippedWeaponDamage
		{
			public int min_value;
			public int max_value;
			public LocalizedString display_string;
			public TypeNameStruct damage_class;
		}

		[Serializable]
		public struct EquippedWeapon
		{
			public EquippedWeaponDamage value;
			public ValueIntDisplayStruct attack_speed;
			public ValueFloatDisplayStruct dps;
		}

		[Serializable]
		public struct EquippedItem
		{
			public RefIdStruct item;
			public EquippedItemSocket[] sockets;
			public EquippedItemEnchantment[] enchantments;
			public TypeNameStruct slot;
			public int quantity;
			public int context;
			public int[] bonus_list;
			public TypeNameStruct quality;
			public LocalizedString name;
			public int modified_appearance_id;
			public EquippedItemAzeriteDetails azerite_details;
			public RefIdStruct media;
			public RefNameIdStruct item_class;
			public RefNameIdStruct item_subclass;
			public TypeNameStruct inventory_type;
			public TypeNameStruct binding;
			public LocalizedString unique_equipped;
			public EquippedWeapon weapon;
			public EquippedItemArmor armor;
			public EquippedItemStats[] stats;
			public EquippedItemSpellTooltip[] spells;
			public EquippedItemValue sell_price;
			public EquippedItemRequirement requirements;
			public EquippedItemSet set;
			public LocalizedString description;
			public ValueIntDisplayStruct level;
			public EquippedItemTransmog transmog;
			public ValueIntDisplayStruct durability;
			public bool is_subclass_hidden;
			public bool is_corrupted;
			public DisplayStringColorStruct name_description;
		}
		public EquippedItem[] equipped_items;

		[Serializable]
		public struct ItemSetEffect
		{
			public LocalizedString display_string;
			public int required_count;
		}

		[Serializable]
		public struct ItemSetItem
		{
			public RefNameIdStruct item;
			public bool is_equipped;
		}

		[Serializable]
		public struct EquippedItemSet
		{
			public RefNameIdStruct item_set;
			public ItemSetItem[] items;
			public ItemSetEffect[] effects;
			public LocalizedString display_string;
		}
		public EquippedItemSet[] equipped_item_sets;
		// {{JSON_END}}
	}
}