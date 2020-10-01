#if UNITY_EDITORCOROUTINES
using Unity.EditorCoroutines.Editor;
#endif
using UnityEditor;
using UnityEngine;

namespace ZeShmouttsAssets.BlizzardAPI.Editor
{
	public class BlizzardAPI_AccessTokenWindow : EditorWindow
	{
		#region Initialization

		private const string MENU_PATH = "Blizzard API/Get Access Token";

		[MenuItem(MENU_PATH, true)]
		public static bool EnableMenuItem()
		{
#if UNITY_EDITORCOROUTINES
			return true;
#else
			return false;
#endif
		}

		[MenuItem(MENU_PATH, false, priority = 101)]
		public static void ShowWindow()
		{
#if UNITY_EDITORCOROUTINES
			BlizzardAPI_AccessTokenWindow window = CreateInstance(typeof(BlizzardAPI_AccessTokenWindow)) as BlizzardAPI_AccessTokenWindow;
			window.maxSize = new Vector2(SIZE_X, SIZE_Y);
			window.minSize = new Vector2(SIZE_X, SIZE_Y);
			window.titleContent = new GUIContent(WINDOW_TITLE);
			window.ShowUtility();
#endif
		}

		#endregion

#if UNITY_EDITORCOROUTINES
		#region Constants

#if UNITY_2019_1_OR_NEWER
		private const int SIZE_X = 392;
		private const int SIZE_Y = 70;
		private const int BUTTON_SIZE = 46;
#else
		private const int SIZE_X = 380;
		private const int SIZE_Y = 65;
		private const int BUTTON_SIZE = 40;
#endif

		private const string WINDOW_TITLE = "OAuth Access Token for Blizzard";
		private const string TOKEN_TITLE = "Access token";
		private const string TOKEN_RETRIEVING = "Retrieving...";
		private const string DEPENDANCY_MISSING = "EditorCoroutines package is missing";

		private const string REFRESH_ICON = "d_TreeEditor.Refresh";
		private const string REFRESH_TOOLTIP = "Refresh";

		private const string COPY_ICON = "d_TreeEditor.Duplicate";
		private const string COPY_TOOLTIP = "Copy to clipboard";

		#endregion

		#region Access token value

		private static bool hasToken;
		private static string accessToken;
		private EditorCoroutine tokenCoroutine;

		#endregion

		#region Editor window basics

		private void OnEnable()
		{
			GetAccessToken();
		}

		private void OnDestroy()
		{
			EditorCoroutineUtility.StopCoroutine(tokenCoroutine);
		}

		#endregion

		#region Access Token

		private void GetAccessToken()
		{
			hasToken = false;
			accessToken = TOKEN_RETRIEVING;
			tokenCoroutine = EditorCoroutineUtility.StartCoroutine(BlizzardAPI.CheckAccessToken(result: OnAccessTokenRetrieved), this);
		}

		#endregion

		#region GUI

		private void OnGUI()
		{
			GUIContent buttonContent;
			GUIStyle centeredLabel = new GUIStyle(GUI.skin.label)
			{
				alignment = TextAnchor.MiddleCenter
			};

			EditorGUILayout.LabelField(TOKEN_TITLE, EditorStyles.centeredGreyMiniLabel);
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.BeginVertical(GUI.skin.box);
			EditorGUILayout.SelectableLabel(hasToken ? accessToken : TOKEN_RETRIEVING, centeredLabel);
			EditorGUILayout.EndVertical();

			bool guiEnabled = GUI.enabled;
			GUI.enabled = hasToken;
			buttonContent = EditorGUIUtility.IconContent(COPY_ICON);
			buttonContent.tooltip = COPY_TOOLTIP;
			if (GUILayout.Button(buttonContent, GUILayout.Width(BUTTON_SIZE), GUILayout.Height(BUTTON_SIZE)))
			{
				CopyToken();
			}
			GUI.enabled = true;
			buttonContent = EditorGUIUtility.IconContent(REFRESH_ICON);
			buttonContent.tooltip = REFRESH_TOOLTIP;
			if (GUILayout.Button(buttonContent, GUILayout.Width(BUTTON_SIZE), GUILayout.Height(BUTTON_SIZE)))
			{
				GetAccessToken();
			}
			GUI.enabled = guiEnabled;

			EditorGUILayout.EndHorizontal();
		}

		#endregion

		#region Callbacks

		private void OnAccessTokenRetrieved(string retrievedToken)
		{
			hasToken = true;
			accessToken = retrievedToken;
			Repaint();
		}

		private void CopyToken()
		{
			EditorGUIUtility.systemCopyBuffer = accessToken;
			Debug.LogFormat("<color=green>Access token '{0}' copied to clipboard.</color>", accessToken);
		}

		#endregion
#endif
	}
}