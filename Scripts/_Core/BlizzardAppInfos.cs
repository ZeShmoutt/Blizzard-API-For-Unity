using UnityEngine;

namespace ZeShmouttsAssets.BlizzardAPI
{
	public static class AppInfos
	{
		public static string BlizzardClientID { get => GetAppInfos().ClientID; }
		public static string BlizzardClientSecret { get => GetAppInfos().ClientSecret; }

		private static BlizzardAppInfos appInfos;
		private const string path = BlizzardAppInfos.settingsFilename;

		private static BlizzardAppInfos GetAppInfos()
		{
			if (appInfos != null)
			{
				return appInfos;
			}
			else
			{
				BlizzardAppInfos foundAppInfos = Resources.Load<BlizzardAppInfos>(path);
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
	class BlizzardAppInfos : ScriptableObject
	{
		public const string settingsFolder = "Assets/ZeShmouttsAssets/Resources/";
		public const string settingsFilename = "BlizzardAppInfos";
		public const string settingsExtension = ".asset";
		public const string settingsPath = settingsFolder + settingsFilename + settingsExtension;

		public string ClientID { get => clientId; }
		public string ClientSecret { get => clientSecret; }

		[SerializeField]
		private string clientId = "";

		[SerializeField]
		private string clientSecret = "";
	}
}