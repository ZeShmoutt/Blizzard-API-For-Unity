#if UNITY_EDITORCOROUTINES
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;

namespace ZeShmouttsAssets.BlizzardAPI.Editor
{
	public class BlizzardAPI_AccessTokenWindow : EditorWindow
	{
		#region Constants

#if UNITY_2019_1_OR_NEWER
		private const int sizeX = 392;
		private const int sizeY = 70;
		private const int buttonSize = 46;
#else
		private const int sizeX = 380;
		private const int sizeY = 65;
		private const int buttonSize = 40;
#endif

		private const string windowTitle = "OAuth Access Token for Blizzard";
		private const string tokenTitle = "Access token";
		private const string tokenRetrieving = "Retrieving...";

		private const string refreshIcon = "d_TreeEditor.Refresh";
		private const string refreshTooltip = "Refresh";

		private const string copyIcon = "d_TreeEditor.Duplicate";
		private const string copyTooltip = "Copy to clipboard";

		#endregion

		#region Access token value

		private static bool hasToken;
		private static string accessToken;
		private EditorCoroutine tokenCoroutine;

		#endregion

		#region Initialization

		[MenuItem("Blizzard API/Get Access Token", priority = 101)]
		public static void ShowWindow()
		{
			BlizzardAPI_AccessTokenWindow window = CreateInstance(typeof(BlizzardAPI_AccessTokenWindow)) as BlizzardAPI_AccessTokenWindow;
			window.maxSize = new Vector2(sizeX, sizeY);
			window.minSize = new Vector2(sizeX, sizeY);
			window.titleContent = new GUIContent(windowTitle);
			window.ShowUtility();
		}

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
			accessToken = tokenRetrieving;
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

			EditorGUILayout.LabelField(tokenTitle, EditorStyles.centeredGreyMiniLabel);
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.BeginVertical(GUI.skin.box);
			EditorGUILayout.SelectableLabel(hasToken ? accessToken : tokenRetrieving, centeredLabel);
			EditorGUILayout.EndVertical();

			bool guiEnabled = GUI.enabled;
			GUI.enabled = hasToken;
			buttonContent = EditorGUIUtility.IconContent(copyIcon);
			buttonContent.tooltip = copyTooltip;
			if (GUILayout.Button(buttonContent, GUILayout.Width(buttonSize), GUILayout.Height(buttonSize)))
			{
				CopyToken();
			}
			GUI.enabled = guiEnabled;

			buttonContent = EditorGUIUtility.IconContent(refreshIcon);
			buttonContent.tooltip = refreshTooltip;
			if (GUILayout.Button(buttonContent, GUILayout.Width(buttonSize), GUILayout.Height(buttonSize)))
			{
				GetAccessToken();
			}

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
	}
}
#endif