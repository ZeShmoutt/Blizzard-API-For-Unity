using System;

namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	#region Base

	public abstract class Object_JSON
	{
		/// <summary>
		/// Converts the object to a JSON string.
		/// </summary>
		/// <returns>Returns a JSON-formatted string.</returns>
		public override string ToString()
		{
			return UnityEngine.JsonUtility.ToJson(this);
		}
	}

	#endregion

	#region Common structs

	/// <summary>
	/// Storage for localized versions of a string in the 15 languages that Blizzard supports.
	/// Note : not all games support all languages.
	/// </summary>
	[Serializable]
	public struct LocalizedString
	{
		/// <summary>
		/// English (United States).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string en_US;
		/// <summary>
		/// Spanish (Mexico).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string es_MX;
		/// <summary>
		/// Portuguese (Brazil).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string pt_BR;
		/// <summary>
		/// German.
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string de_DE;
		/// <summary>
		/// English (United Kingdoms).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string en_GB;
		/// <summary>
		/// Spanish (Spain).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string es_ES;
		/// <summary>
		/// French.
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string fr_FR;
		/// <summary>
		/// Italian.
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string it_IT;
		/// <summary>
		/// Russian.
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string ru_RU;
		/// <summary>
		/// Korean.
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string ko_KR;
		/// <summary>
		/// Chinese (traditional).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string zh_TW;
		/// <summary>
		/// Chinese (simplified).
		/// Used in : Hearthstone, World of Warcraft, World of Warcraft (Classic).
		/// </summary>
		public string zh_CN;
		/// <summary>
		/// Japanese.
		/// Used in : Hearthstone.
		/// </summary>
		public string ja_JP;
		/// <summary>
		/// Polish.
		/// Used in : Hearthstone.
		/// </summary>
		public string pl_PL;
		/// <summary>
		/// Thai.
		/// Used in : Hearthstone.
		/// </summary>
		public string th_TH;
	}

	/// <summary>
	/// "href" (string).
	/// </summary>
	[Serializable]
	public struct HRefStruct
	{
		public string href;
	}

	/// <summary>
	/// "self" (HRefStruct).
	/// </summary>
	[Serializable]
	public struct LinkStruct
	{
		public HRefStruct self;
	}

	/// <summary>
	/// "type" (string), "name" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct TypeNameStruct
	{
		public string type;
		public LocalizedString name;
	}

	/// <summary>
	/// "type" (string).
	/// </summary>
	[Serializable]
	public struct TypeStruct
	{
		public string type;
	}

	/// <summary>
	/// "key" (HRefStruct), "id" (int).
	/// </summary>
	[Serializable]
	public struct RefIdStruct
	{
		public HRefStruct key;
		public int id;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int).
	/// </summary>
	[Serializable]
	public struct RefNameIdStruct
	{
		public HRefStruct key;
		public LocalizedString name;
		public int id;
	}

	/// <summary>
	/// "name" (LocalizedString), "id" (int).
	/// </summary>
	[Serializable]
	public struct NameIdStruct
	{
		public LocalizedString name;
		public int id;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (string), "id" (int).
	/// </summary>
	[Serializable]
	public struct RefStringIdStruct
	{
		public HRefStruct key;
		public string name;
		public int id;
	}

	/// <summary>
	/// "key" (string), "value" (string).
	/// </summary>
	[Serializable]
	public struct KeyValueStruct
	{
		public string key;
		public string value;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int), "slug" (string).
	/// </summary>
	[Serializable]
	public struct RealmStruct
	{
		public HRefStruct key;
		public LocalizedString name;
		public int id;
		public string slug;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int), "realm" (RealmStruct), "faction" (TypeNameStruct).
	/// </summary>
	[Serializable]
	public struct GuildStruct
	{
		public HRefStruct key;
		public string name;
		public int id;
		public RealmStruct realm;
		public TypeNameStruct faction;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int), "display_string" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct TitleStruct
	{
		public HRefStruct key;
		public string name;
		public int id;
		public string display_string;
	}

	/// <summary>
	/// "value" (float), "display_string" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct ValueFloatDisplayStruct
	{
		public float value;
		public string display_string;
	}

	/// <summary>
	/// "value" (int), "display_string" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct ValueIntDisplayStruct
	{
		public int value;
		public string display_string;
	}

	/// <summary>
	/// "value" (TypeNameStruct), "display_string" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct ValueTypeDisplayStruct
	{
		public TypeNameStruct value;
		public string display_string;
	}

	/// <summary>
	/// "male" (LocalizedString), "female" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct GenderedLocalizedString
	{
		public LocalizedString male;
		public LocalizedString female;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (string), "id" (long), "realm" (RealmStruct).
	/// </summary>
	[Serializable]
	public struct CharacterStruct
	{
		public HRefStruct key;
		public string name;
		public long id;
		public RealmStruct realm;
	}

	/// <summary>
	/// "r" (int), "g" (int), "b" (int), "a" (int).
	/// </summary>
	[Serializable]
	public struct ColorStruct
	{
		public int r;
		public int g;
		public int b;
		public int a;
	}

	/// <summary>
	/// "slug" (string).
	/// </summary>
	[Serializable]
	public struct SlugStruct
	{
		public string slug;
	}

	/// <summary>
	/// "name" (string), "id" (int), "realm" (RealmStruct).
	/// </summary>
	[Serializable]
	public struct ProfileStruct
	{
		public string name;
		public int id;
		public RealmStruct realm;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString).
	/// </summary>
	[Serializable]
	public struct RefNameStruct
	{
		public HRefStruct key;
		public LocalizedString name;
	}

	/// <summary>
	/// "id" (int), "type" (string).
	/// </summary>
	[Serializable]
	public struct IdTypeStruct
	{
		public int id;
		public string type;
	}

	/// <summary>
	/// "display_string" (LocalizedString), "color" (ColorStruct).
	/// </summary>
	[Serializable]
	public struct DisplayStringColorStruct
	{
		public LocalizedString display_string;
		public ColorStruct color;
	}

	#endregion
}