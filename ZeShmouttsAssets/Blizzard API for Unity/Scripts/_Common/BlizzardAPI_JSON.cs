namespace ZeShmouttsAssets.BlizzardAPI.JSON
{
	#region Base

	public abstract class Object_Json { }

	#endregion

	#region Common structs

	/// <summary>
	/// Storage for localized versions of a string in the 12 languages that Blizzard supports.
	/// </summary>
	[System.Serializable]
	public struct LocalizedString
	{
		public string en_US;
		public string es_MX;
		public string pt_BR;
		public string de_DE;
		public string en_GB;
		public string es_ES;
		public string fr_FR;
		public string it_IT;
		public string ru_RU;
		public string ko_KR;
		public string zh_TW;
		public string zh_CN;
	}

	/// <summary>
	/// "href" (string).
	/// </summary>
	[System.Serializable]
	public struct HRefStruct
	{
		public string href;
	}

	/// <summary>
	/// "self" (HRefStruct).
	/// </summary>
	[System.Serializable]
	public struct LinkStruct
	{
		public HRefStruct self;
	}

	/// <summary>
	/// "type" (string), "name" (LocalizedString).
	/// </summary>
	[System.Serializable]
	public struct TypeNameStruct
	{
		public string type;
		public LocalizedString name;
	}

	/// <summary>
	/// "key" (HRefStruct), "id" (int).
	/// </summary>
	[System.Serializable]
	public struct RefIdStruct
	{
		public HRefStruct key;
		public int id;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int).
	/// </summary>
	[System.Serializable]
	public struct RefNameIdStruct
	{
		public HRefStruct key;
		public LocalizedString name;
		public int id;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (string), "id" (int).
	/// </summary>
	[System.Serializable]
	public struct RefStringIdStruct
	{
		public HRefStruct key;
		public string name;
		public int id;
	}

	/// <summary>
	/// "key" (string), "value" (string).
	/// </summary>
	[System.Serializable]
	public struct KeyValueStruct
	{
		public string key;
		public string value;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int), "slug" (string).
	/// </summary>
	[System.Serializable]
	public struct RealmStruct
	{
		public HRefStruct key;
		public LocalizedString name;
		public int id;
		public string slug;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int), "realm" (RealmStruct).
	/// </summary>
	[System.Serializable]
	public struct GuildStruct
	{
		public HRefStruct key;
		public string name;
		public int id;
		public RealmStruct realm;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (LocalizedString), "id" (int), "display_string" (LocalizedString).
	/// </summary>
	[System.Serializable]
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
	[System.Serializable]
	public struct ValueDisplayStruct
	{
		public float value;
		public string display_string;
	}

	/// <summary>
	/// "male" (LocalizedString), "female" (LocalizedString).
	/// </summary>
	[System.Serializable]
	public struct GenderName
	{
		public LocalizedString male;
		public LocalizedString female;
	}

	/// <summary>
	/// "key" (HRefStruct), "name" (string), "id" (int), "realm" (RealmStruct).
	/// </summary>
	[System.Serializable]
	public struct CharacterStruct
	{
		public HRefStruct key;
		public string name;
		public int id;
		public RealmStruct realm;
	}

	[System.Serializable]
	public struct ColorStruct
	{
		public int R;
		public int G;
		public int B;
		public int A;
	}

	#endregion
}