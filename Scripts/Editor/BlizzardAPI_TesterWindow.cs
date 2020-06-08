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
			new KeyValuePair<string, string>("Log in console", "ResultCallbackDebug")
		};

		private const string filePath = "/ZeShmouttsAssets/Editor/Retrieved JSON/";
		private const string fileExtension = ".json";

		#endregion

		#region Variables

		private int domainId;
		private int methodId;

		private int[] parametersInt;
		private string[] parametersString;
		private BattleNetRegion[] parametersRegion;
		private HearthstoneCardSearch parameterCardSearch;
		private HearthstoneCardBackSearch parameterCardBackSearch;
		private bool[] parameterSearchEnabled;
		private object[] parameters;

		private Type[] domains;
		private MethodInfo[] methodInfos;
		private ParameterInfo[] parametersInfos;
		private MethodInfo selectedMethod;

		private int callbackJsonId;
		private int callbackStringId;

		#endregion

		#region Editor Window basics

		[MenuItem("Blizzard API/API Testing Tool", priority = 2)]
		public static void ShowWindow()
		{
			GetWindow<BlizzardAPI_TesterWindow>(false, "Blizzard API Tester", true);
		}

		private void OnEnable()
		{
			domains = typeof(BlizzardAPI).GetNestedTypes(BindingFlags.Static | BindingFlags.Public);
			OnDomainChanged(0);
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
				OnDomainChanged(domainId);
			}

			EditorGUILayout.EndHorizontal();
		}

		private void DrawDomainMethodsChoice()
		{
			if (domains == null || domains.Length <= 0)
			{
				EditorGUILayout.LabelField(labelInvalidDomain, EditorStyles.centeredGreyMiniLabel);
				return;
			}

			string[] methodNames = methodInfos.Select(x => x.Name).ToArray();

			EditorGUILayout.BeginHorizontal(GUI.skin.box);
			EditorGUILayout.PrefixLabel(labelEndpointPrefix);

			EditorGUI.BeginChangeCheck();
			methodId = EditorGUILayout.Popup(methodId, methodNames);
			if (EditorGUI.EndChangeCheck())
			{
				OnMethodChanged(methodId);
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
				else if (parametersInfos[i].ParameterType == typeof(HearthstoneCardSearch))
				{
					DrawHearthstoneCardSearchParameter(i);
				}
				else if (parametersInfos[i].ParameterType == typeof(HearthstoneCardBackSearch))
				{
					DrawHearthstoneCardBackSearchParameter(i);
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

		private void DrawHearthstoneCardSearchParameter(int parameterIndex)
		{
			EditorGUILayout.BeginVertical(GUI.skin.box);

			EditorGUILayout.LabelField("Search parameters", EditorStyles.largeLabel);

			EditorGUI.indentLevel++;

			DrawCardSearchParameter(0, "Set", ref parameterCardSearch.set, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardSet.All);
			DrawCardSearchParameter(1, "Class", ref parameterCardSearch.@class, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardClass.All);
			DrawCardSearchParameter(2, "Mana cost", ref parameterCardSearch.manaCost, DrawIntField);
			DrawCardSearchParameter(3, "Attack", ref parameterCardSearch.attack, DrawIntField);
			DrawCardSearchParameter(4, "Health", ref parameterCardSearch.health, DrawIntField);
			DrawCardSearchParameter(5, "Collectible", ref parameterCardSearch.collectible, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardCollectability.All);
			DrawCardSearchParameter(6, "Rarity", ref parameterCardSearch.rarity, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardRarity.All);
			DrawCardSearchParameter(7, "Type", ref parameterCardSearch.type, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardType.All);
			if (parameterCardSearch.type == BlizzardAPI.HearthstoneGameData.CardType.Minion)
			{
				DrawCardSearchParameter(8, "Minion type", ref parameterCardSearch.minionType, DrawEnumField, BlizzardAPI.HearthstoneGameData.MinionType.All);
			}
			else
			{
				bool guiEnabled = GUI.enabled;
				GUI.enabled = false;
				EditorGUILayout.BeginHorizontal();
				EditorGUILayout.ToggleLeft("Minion type", false);
				EditorGUILayout.LabelField("N/A", EditorStyles.miniLabel);
				EditorGUILayout.EndHorizontal();
				GUI.enabled = guiEnabled;
				parameterCardSearch.minionType = BlizzardAPI.HearthstoneGameData.MinionType.All;
			}
			DrawCardSearchParameter(9, "Keyword", ref parameterCardSearch.keyword, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardKeyword.All);
			DrawCardSearchParameter(10, "Game mode", ref parameterCardSearch.gameMode, DrawEnumField, BlizzardAPI.HearthstoneGameData.GameMode.StandardWildFormats);
			DrawCardSearchParameter(11, "Page", ref parameterCardSearch.page, DrawIntField, -1);
			DrawCardSearchParameter(12, "Page size", ref parameterCardSearch.pageSize, DrawIntField, -1);
			DrawCardSearchParameter(13, "Sort type", ref parameterCardSearch.sort, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardSortType.SortByManaCost);
			DrawCardSearchParameter(14, "Sort order", ref parameterCardSearch.order, DrawEnumField, BlizzardAPI.HearthstoneGameData.SortOrder.Ascending);

			EditorGUI.indentLevel--;

			parameters[parameterIndex] = parameterCardSearch;

			EditorGUILayout.EndVertical();

			EditorGUILayout.Space();
		}

		private void DrawHearthstoneCardBackSearchParameter(int parameterIndex)
		{
			EditorGUILayout.BeginVertical(GUI.skin.box);

			EditorGUILayout.LabelField("Search parameters", EditorStyles.largeLabel);

			EditorGUI.indentLevel++;

			DrawCardSearchParameter(0, "Category", ref parameterCardBackSearch.category, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardBackCategory.All);
			DrawCardSearchParameter(1, "Page", ref parameterCardBackSearch.page, DrawIntField, -1);
			DrawCardSearchParameter(2, "Page size", ref parameterCardBackSearch.pageSize, DrawIntField, -1);
			DrawCardSearchParameter(3, "Sort type", ref parameterCardBackSearch.sort, DrawEnumField, BlizzardAPI.HearthstoneGameData.CardBackSortType.SortByDate);
			DrawCardSearchParameter(4, "Sort order", ref parameterCardBackSearch.order, DrawEnumField, BlizzardAPI.HearthstoneGameData.SortOrder.Ascending);

			EditorGUI.indentLevel--;

			parameters[parameterIndex] = parameterCardBackSearch;

			EditorGUILayout.EndVertical();

			EditorGUILayout.Space();
		}

		private void DrawCardSearchParameter<T>(int index, string name, ref T parameter, Func<T, T> drawFunction, T disabledValue)
		{
			EditorGUILayout.BeginHorizontal();
			parameterSearchEnabled[index] = EditorGUILayout.ToggleLeft(name, parameterSearchEnabled[index]);
			if (parameterSearchEnabled[index])
			{
				parameter = drawFunction(parameter);
			}
			else
			{
				EditorGUILayout.LabelField("N/A", EditorStyles.miniLabel);
				parameter = disabledValue;

			}
			EditorGUILayout.EndHorizontal();
		}

		private void DrawCardSearchParameter<T>(int index, string name, ref T[] parameter, Func<T, T> drawFunction)
		{
			EditorGUILayout.BeginHorizontal();
			parameterSearchEnabled[index] = EditorGUILayout.ToggleLeft(name, parameterSearchEnabled[index]);
			if (parameterSearchEnabled[index])
			{
				if (parameter == null || parameter.Length != 1)
				{
					parameter = new T[1];
				}
				parameter[0] = drawFunction(parameter[0]);
			}
			else
			{
				EditorGUILayout.LabelField("N/A", EditorStyles.miniLabel);
				parameter = null;

			}
			EditorGUILayout.EndHorizontal();
		}

		private string DrawStringField(string parameter)
		{
			return EditorGUILayout.TextField(parameter);
		}

		private int DrawIntField(int parameter)
		{
			return EditorGUILayout.IntField(parameter);
		}

		private T DrawEnumField<T>(T parameter) where T : Enum
		{
			return (T)EditorGUILayout.EnumPopup(parameter);
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

		#region UI Callbacks

		private void OnDomainChanged(int id)
		{
			domainId = id;

			Type type = domains[domainId];
			methodInfos = type.GetMethods(BindingFlags.Static | BindingFlags.Public).Where(x => !x.Name.EndsWith("Raw")).ToArray();

			methodId = 0;
			OnMethodChanged(methodId);
		}

		private void OnMethodChanged(int id)
		{
			selectedMethod = methodInfos[id];
			parametersInfos = selectedMethod.GetParameters();
			parametersInt = new int[parametersInfos.Length];
			parametersString = new string[parametersInfos.Length];
			parametersRegion = new BattleNetRegion[parametersInfos.Length];
			parameterCardSearch = new HearthstoneCardSearch();
			parameterCardBackSearch = new HearthstoneCardBackSearch();
			parameterSearchEnabled = new bool[15];
			parameters = new object[parametersInfos.Length];
			callbackJsonId = 0;
			callbackStringId = 0;
			EditorUtility.SetDirty(this);
			Repaint();
		}

		#endregion

		#region Result Callbacks

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