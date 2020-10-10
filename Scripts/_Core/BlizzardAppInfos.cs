using UnityEngine;

namespace ZeShmouttsAssets.BlizzardAPI
{
	public static class AppInfos
	{
		public static string BlizzardClientID => GetAppInfos().ClientID;
		public static string BlizzardClientSecret => GetAppInfos().ClientSecret;

		private static BlizzardAppInfos appInfos;
		private const string PATH = BlizzardAppInfos.SETTINGS_FILENAME;

		private static BlizzardAppInfos GetAppInfos()
		{
			if (appInfos != null)
			{
				return appInfos;
			}
			else
			{
				BlizzardAppInfos foundAppInfos = Resources.Load<BlizzardAppInfos>(PATH);
				if (foundAppInfos != null)
				{
					appInfos = foundAppInfos;
					return foundAppInfos;
				}
				else
				{
					throw new System.NullReferenceException();
				}
			}
		}
	}

	// Create a new type of Settings Asset.
	public class BlizzardAppInfos : ScriptableObject
	{
		public const string SETTINGS_FOLDER = "Assets/ZeShmouttsAssets/Resources/";
		public const string SETTINGS_FILENAME = "BlizzardAppInfos";
		public const string SETTINGS_EXTENSION = ".asset";
		public const string SETTINGS_PATH = SETTINGS_FOLDER + SETTINGS_FILENAME + SETTINGS_EXTENSION;

		public string ClientID => clientId;
		public string ClientSecret => clientSecret;

		[SerializeField]
		private string clientId = "";

		[SerializeField]
		private string clientSecret = "";
	}
}