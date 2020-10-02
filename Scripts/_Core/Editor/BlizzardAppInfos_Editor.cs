using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace ZeShmouttsAssets.BlizzardAPI.Editor
{
	[CustomEditor(typeof(BlizzardAppInfos))]
	internal class BlizzardAppInfos_Editor : UnityEditor.Editor
	{
		internal static BlizzardAppInfos GetOrCreateSettings()
		{
			var settings = AssetDatabase.LoadAssetAtPath<BlizzardAppInfos>(BlizzardAppInfos.SETTINGS_PATH);
			if (settings == null)
			{
				string dataPath = Application.dataPath;
				string dirPath = string.Join("/", dataPath.Substring(0, dataPath.IndexOf("Assets")), BlizzardAppInfos.SETTINGS_FOLDER);
				if (!Directory.Exists(dirPath))
				{
					Directory.CreateDirectory(dirPath);
				}

				settings = ScriptableObject.CreateInstance<BlizzardAppInfos>();
				AssetDatabase.CreateAsset(settings, BlizzardAppInfos.SETTINGS_PATH);
				AssetDatabase.SaveAssets();
			}
			return settings;
		}

		internal static SerializedObject GetSerializedSettings()
		{
			return new SerializedObject(GetOrCreateSettings());
		}

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
			SettingsService.OpenProjectSettings(BlizzardAppInfosProvider.PROJECT_SETTINGS_PATH);
		}
	}

	// Lots of shameless copy-pasting to add it to the project settings window.
	internal class BlizzardAppInfosProvider : SettingsProvider
	{
		public const string PROJECT_SETTINGS_PATH = "Project/Blizzard App Infos";
		private SerializedObject blizzardAppInfosSettings;

		private class Styles
		{
			public static GUIContent clientId = new GUIContent("Client ID");
			public static GUIContent clientSecret = new GUIContent("Client Secret");
		}

		public BlizzardAppInfosProvider(string path, SettingsScope scope = SettingsScope.User) : base(path, scope) { }

		public static bool IsSettingsAvailable()
		{
			return File.Exists(BlizzardAppInfos.SETTINGS_PATH);
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
			blizzardAppInfosSettings = BlizzardAppInfos_Editor.GetSerializedSettings();
		}

		public override void OnGUI(string searchContext)
		{
			EditorGUILayout.PropertyField(blizzardAppInfosSettings.FindProperty("clientId"), Styles.clientId);
			EditorGUILayout.PropertyField(blizzardAppInfosSettings.FindProperty("clientSecret"), Styles.clientSecret);
		}

		[SettingsProvider]
		public static SettingsProvider CreateBlizzardAppInfosProvider()
		{
			if (!IsSettingsAvailable())
			{
				BlizzardAppInfos_Editor.GetOrCreateSettings();
			}

			var provider = new BlizzardAppInfosProvider(PROJECT_SETTINGS_PATH, SettingsScope.Project);
			provider.keywords = GetSearchKeywordsFromGUIContentProperties<Styles>();
			return provider;
		}
	}
}