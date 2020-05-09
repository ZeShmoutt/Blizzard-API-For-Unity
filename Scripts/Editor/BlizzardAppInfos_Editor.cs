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
			var settings = AssetDatabase.LoadAssetAtPath<BlizzardAppInfos>(BlizzardAppInfos.settingsPath);
			if (settings == null)
			{
				string dataPath = Application.dataPath;
				string dirPath = string.Join("/", dataPath.Substring(0, dataPath.IndexOf("Assets")), BlizzardAppInfos.settingsFolder);
				if (!Directory.Exists(dirPath))
				{
					Directory.CreateDirectory(dirPath);
				}

				settings = ScriptableObject.CreateInstance<BlizzardAppInfos>();
				AssetDatabase.CreateAsset(settings, BlizzardAppInfos.settingsPath);
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
			SettingsService.OpenProjectSettings(BlizzardAppInfosProvider.projectSettingsPath);
		}
	}

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
			if (IsSettingsAvailable())
			{
				var provider = new BlizzardAppInfosProvider(projectSettingsPath, SettingsScope.Project);
				provider.keywords = GetSearchKeywordsFromGUIContentProperties<Styles>();
				return provider;
			}
			return null;
		}
	}
}