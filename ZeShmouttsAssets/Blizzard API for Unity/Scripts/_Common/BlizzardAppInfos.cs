using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Experimental.UIElements;

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
	[CreateAssetMenu(fileName = "BlizzardAppInfos", menuName = "ZeShmoutt's Assets/BlizzardAppInfos")]
	class BlizzardAppInfos : ScriptableObject
	{
		public const string settingsFolder = "Assets/ZeShmouttsAssets/Resources/";
		public const string settingsFilename = "BlizzardAppInfos.asset";
		public const string settingsPath = settingsFolder + settingsFilename;

		public string ClientID { get => clientId; }
		public string ClientSecret { get => clientSecret; }

		[SerializeField]
		private string clientId = "";

		[SerializeField]
		private string clientSecret = "";

#if UNITY_EDITOR
		internal static BlizzardAppInfos GetOrCreateSettings()
		{
			var settings = AssetDatabase.LoadAssetAtPath<BlizzardAppInfos>(settingsPath);
			if (settings == null)
			{
				string dataPath = Application.dataPath;
				string dirPath = string.Join("/", dataPath.Substring(0, dataPath.IndexOf("Assets")), settingsFolder);
				if (!Directory.Exists(dirPath))
				{
					Directory.CreateDirectory(dirPath);
				}

				settings = ScriptableObject.CreateInstance<BlizzardAppInfos>();
				AssetDatabase.CreateAsset(settings, settingsPath);
				AssetDatabase.SaveAssets();
			}
			return settings;
		}

		internal static SerializedObject GetSerializedSettings()
		{
			return new SerializedObject(GetOrCreateSettings());
		}
#endif
	}
}

#if UNITY_EDITOR

namespace ZeShmouttsAssets.BlizzardAPI.Editor
{
	// Lots of shameless copy-pasting to add it to the project settings window.
	class BlizzardAppInfosProvider : SettingsProvider
	{
		public const string projectSettingsPath = "Project/Blizzard App Infos";
		private SerializedObject blizzardAppInfosSettings;

		class Styles
		{
			public static GUIContent clientId = new GUIContent("Client ID");
			public static GUIContent clientSecret = new GUIContent("Client Secret");
		}

		public BlizzardAppInfosProvider(string path, SettingsScope scope = SettingsScope.User) : base(path, scope) { }

		public static bool IsSettingsAvailable()
		{
			return File.Exists(BlizzardAppInfos.settingsPath);
		}

		public override void OnDeactivate()
		{
			base.OnDeactivate();

			if (blizzardAppInfosSettings != null)
			{
				blizzardAppInfosSettings.ApplyModifiedProperties();
			}
		}

		public override void OnActivate(string searchContext, VisualElement rootElement)
		{
			blizzardAppInfosSettings = BlizzardAppInfos.GetSerializedSettings();
		}

		public override void OnGUI(string searchContext)
		{
			EditorGUILayout.PropertyField(blizzardAppInfosSettings.FindProperty("clientId"), Styles.clientId);
			EditorGUILayout.PropertyField(blizzardAppInfosSettings.FindProperty("clientSecret"), Styles.clientSecret);
		}

		[SettingsProvider]
		public static SettingsProvider CreateBlizzardAppInfosProvider()
		{
			if (IsSettingsAvailable())
			{
				var provider = new BlizzardAppInfosProvider(projectSettingsPath, SettingsScope.Project);
				provider.keywords = GetSearchKeywordsFromGUIContentProperties<Styles>();
				return provider;
			}
			return null;
		}
	}

	[CustomEditor(typeof(BlizzardAppInfos))]
	internal class BlizzardAppInfos_Editor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			EditorGUILayout.Space();
			if (GUILayout.Button("Open in project settings"))
			{
				OpenProjectSettings();
			}
		}

		[MenuItem("Blizzard API/Settings...", priority = 0)]
		public static void OpenProjectSettings()
		{
			SettingsService.OpenProjectSettings(BlizzardAppInfosProvider.projectSettingsPath);
		}
	}
}
#endif