#if UNITY_EDITORCOROUTINES
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI.Editor
{
	public partial class BlizzardAPI_TesterWindow : EditorWindow
	{
		#region Constants

		private static readonly GUIContent labelTitle = new GUIContent("Blizzard API Testing Tool");
		private static readonly GUIContent labelDomainPrefix = new GUIContent("API Domain");
		private static readonly GUIContent labelEndpointPrefix = new GUIContent("API Endpoint");
		private static readonly GUIContent labelInvalidDomain = new GUIContent("No suitable methods in this API domain");
		private static readonly GUIContent labelParameters = new GUIContent("Parameters");
		private static readonly GUIContent labelNoParameters = new GUIContent("No parameters for this API endpoint");
		private static readonly GUIContent labelInvalidParameters = new GUIContent("Unsupported parameter");
		private static readonly GUIContent labelSendRequestButton = new GUIContent("Send request");

		private static KeyValuePair<string, string>[] callbackMethodsJson = new KeyValuePair<string, string>[]
		{
			new KeyValuePair<string, string>("None", null),
			new KeyValuePair<string, string>("Save to file", "ResultCallbackSaveToFile"),
		};

		private static KeyValuePair<string, string>[] callbackMethodsString = new KeyValuePair<string, string>[]
		{
			new KeyValuePair<string, string>("None", null),
			new KeyValuePair<string, string>("Log in console", "ResultCallbackDebug"),
		};

		private const string filePath = "/ZeShmouttsAssets/Editor/Retrieved JSON/";
		private const string fileExtension = ".json";

		#endregion

		#region Variables

		int domainId;
		int methodId;

		int[] parametersInt;
		string[] parametersString;
		BattleNetRegion[] parametersRegion;
		object[] parameters;

		Type[] domains;
		MethodInfo[] methodInfos;
		ParameterInfo[] parametersInfos;
		MethodInfo selectedMethod;

		int callbackJsonId;
		int callbackStringId;

		#endregion

		#region Editor Window basics

		[MenuItem("Blizzard API/API Testing Tool", priority = 2)]
		public static void ShowWindow()
		{
			GetWindow<BlizzardAPI_TesterWindow>(false, "Blizzard API Tester", true);
		}

		private void OnGUI()
		{
			EditorGUILayout.LabelField(labelTitle, EditorStyles.largeLabel);
			DrawDomainChoice();
			EditorGUILayout.Space();
			DrawDomainMethodsChoice();
			DrawParametersFields();
			EditorGUILayout.Space();
			DrawSendRequestButton();
		}

		#endregion

		#region GUI

		private void DrawDomainChoice()
		{
			domains = typeof(BlizzardAPI).GetNestedTypes(BindingFlags.Static | BindingFlags.Public);

			string[] domainNames = domains.Select(x => x.Name).ToArray();
			EditorGUILayout.BeginHorizontal(GUI.skin.box);
			EditorGUILayout.PrefixLabel(labelDomainPrefix);

			EditorGUI.BeginChangeCheck();
			domainId = EditorGUILayout.Popup(domainId, domainNames);
			if (EditorGUI.EndChangeCheck())
			{
				methodId = 0;
				Repaint();
			}

			EditorGUILayout.EndHorizontal();
		}

		private void DrawDomainMethodsChoice()
		{
			if (domains.Length <= 0)
			{
				EditorGUILayout.LabelField(labelInvalidDomain, EditorStyles.centeredGreyMiniLabel);
				return;
			}

			Type type = domains[domainId];

			methodInfos = type.GetMethods(BindingFlags.Static | BindingFlags.Public).Where(x => !x.Name.EndsWith("Raw")).ToArray();

			string[] methodNames = methodInfos.Select(x => x.Name).ToArray();

			EditorGUILayout.BeginHorizontal(GUI.skin.box);
			EditorGUILayout.PrefixLabel(labelEndpointPrefix);

			EditorGUI.BeginChangeCheck();
			methodId = EditorGUILayout.Popup(methodId, methodNames);
			if (EditorGUI.EndChangeCheck())
			{
				selectedMethod = methodInfos[methodId];
				parametersInfos = selectedMethod.GetParameters();
				parametersInt = new int[parametersInfos.Length];
				parametersString = new string[parametersInfos.Length];
				parametersRegion = new BattleNetRegion[parametersInfos.Length];
				parameters = new object[parametersInfos.Length];
				callbackJsonId = 0;
				callbackStringId = 0;
				OnGUI();
			}

			EditorGUILayout.EndHorizontal();
		}

		private void DrawParametersFields()
		{
			if (parametersInfos == null || parametersInfos.Length <= 0)
			{
				EditorGUILayout.LabelField(labelNoParameters, EditorStyles.centeredGreyMiniLabel);
				return;
			}

			EditorGUILayout.Space();
			EditorGUILayout.LabelField(labelParameters, EditorStyles.boldLabel);
			EditorGUILayout.BeginVertical(GUI.skin.box);

			for (int i = 0; i < parametersInfos.Length; i++)
			{
				if (parametersInfos[i].ParameterType == typeof(int))
				{
					parametersInt[i] = EditorGUILayout.IntField(parametersInfos[i].Name, parametersInt[i]);
					parameters[i] = parametersInt[i];
				}
				else if (parametersInfos[i].ParameterType == typeof(string))
				{
					parametersString[i] = EditorGUILayout.TextField(parametersInfos[i].Name, parametersString[i]);
					parameters[i] = parametersString[i];
				}
				else if (parametersInfos[i].ParameterType == typeof(BattleNetRegion))
				{
					parametersRegion[i] = (BattleNetRegion)EditorGUILayout.EnumPopup(parametersInfos[i].Name, parametersRegion[i]);
					parameters[i] = parametersRegion[i];
				}
				else if (parametersInfos[i].ParameterType == typeof(Action<string>))
				{
					EditorGUILayout.BeginHorizontal();
					EditorGUILayout.PrefixLabel(parametersInfos[i].Name);

					EditorGUI.BeginChangeCheck();
					callbackStringId = EditorGUILayout.Popup(callbackStringId, callbackMethodsString.Select(x => x.Key).ToArray());
					if (EditorGUI.EndChangeCheck())
					{
						parameters[i] = CreateAction(typeof(string), callbackMethodsString[callbackStringId].Value);
					}

					EditorGUILayout.EndHorizontal();
				}
				else if (IsActionDelegate(parametersInfos[i].ParameterType))
				{
					Type[] actionTypes = parametersInfos[i].ParameterType.GenericTypeArguments;
					if (actionTypes.Length == 1 && actionTypes[0].IsSubclassOf(typeof(Object_JSON)))
					{
						EditorGUILayout.BeginHorizontal();
						EditorGUILayout.PrefixLabel(parametersInfos[i].Name);

						EditorGUI.BeginChangeCheck();
						callbackJsonId = EditorGUILayout.Popup(callbackJsonId, callbackMethodsJson.Select(x => x.Key).ToArray());
						if (EditorGUI.EndChangeCheck())
						{
							parameters[i] = CreateAction(actionTypes[0], callbackMethodsJson[callbackJsonId].Value);
						}

						EditorGUILayout.EndHorizontal();
					}
					else
					{
						EditorGUILayout.LabelField(new GUIContent(parametersInfos[i].Name), labelInvalidParameters, EditorStyles.miniLabel);
					}
				}
				else
				{
					EditorGUILayout.LabelField(new GUIContent(parametersInfos[i].Name), labelInvalidParameters, EditorStyles.miniLabel);
				}
			}

			EditorGUILayout.EndVertical();
		}

		private void DrawSendRequestButton()
		{
			if (GUILayout.Button(labelSendRequestButton))
			{
				Debug.Log("Retrieving JSON...");
				StartAPICall(domainId, methodId, parameters);
			}
		}

		#endregion

		#region Delegate creation

		private static dynamic CreateAction(Type type, string method)
		{
			if (method == null) { return null; }

			Type delegateType = typeof(Action<>).MakeGenericType(type);
			MethodInfo methodInfo1 = typeof(BlizzardAPI_TesterWindow).GetMethod(method, BindingFlags.Static | BindingFlags.NonPublic);
			dynamic del = (dynamic)Delegate.CreateDelegate(delegateType, methodInfo1);
			return del;
		}

		#endregion

		#region Callbacks

		private static void ResultCallbackDebug(string target)
		{
			Debug.Log(target);
		}

		private static void ResultCallbackSaveToFile(Object_JSON target)
		{
			string fileName = string.Format("{0}_{1}", target.GetType().Name, DateTime.Now.ToString("yyyyMMddHHmmss"));
			string json = FormatJson(target.ToString());
			SaveToFile(fileName, json);
		}

		private static void SaveToFile(string fileName, string content)
		{
			Directory.CreateDirectory(Application.dataPath + filePath);
			string assetPath = filePath + fileName + fileExtension;
			File.WriteAllText(Application.dataPath + assetPath, content);

			AssetDatabase.Refresh();
			AssetDatabase.SaveAssets();
			EditorUtility.FocusProjectWindow();
			UnityEngine.Object obj = AssetDatabase.LoadAssetAtPath<UnityEngine.Object>("Assets" + assetPath);
			Selection.activeObject = obj;
			EditorGUIUtility.PingObject(obj);
		}

		#endregion

		#region Thanks Internet

		// Copied off https://stackoverflow.com/a/15851563
		internal static bool IsActionDelegate(Type sourceType)
		{
			return sourceType.IsSubclassOf(typeof(MulticastDelegate)) && sourceType.GetMethod("Invoke").ReturnType == typeof(void);
		}

		// Copied off https://stackoverflow.com/a/57100143
		private static string FormatJson(string json)
		{
			char indent = '\t';
			var indentation = 0;
			var quoteCount = 0;
			var escapeCount = 0;

			var result =
				from ch in json ?? string.Empty
				let escaped = (ch == '\\' ? escapeCount++ : escapeCount > 0 ? escapeCount-- : escapeCount) > 0
				let quotes = ch == '"' && !escaped ? quoteCount++ : quoteCount
				let unquoted = quotes % 2 == 0
				let colon = ch == ':' && unquoted ? ": " : null
				let nospace = char.IsWhiteSpace(ch) && unquoted ? string.Empty : null
				let lineBreak = ch == ',' && unquoted ? ch + Environment.NewLine + string.Concat(Enumerable.Repeat(indent, indentation)) : null
				let openChar = (ch == '{' || ch == '[') && unquoted ? ch + Environment.NewLine + string.Concat(Enumerable.Repeat(indent, ++indentation)) : ch.ToString()
				let closeChar = (ch == '}' || ch == ']') && unquoted ? Environment.NewLine + string.Concat(Enumerable.Repeat(indent, --indentation)) + ch : ch.ToString()
				select colon ?? nospace ?? lineBreak ?? (
					openChar.Length > 1 ? openChar : closeChar
				);

			return string.Concat(result);
		}

		#endregion
	}
}
#endif