using System;
using UnityEngine;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public class BlizzardAPIUnity_Singleton : MonoBehaviour
	{
		#region Singleton

		public static BlizzardAPIUnity_Singleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = FindObjectOfType<BlizzardAPIUnity_Singleton>();
					if (instance == null)
					{
						GameObject obj = new GameObject("Blizzard API");
						instance = obj.AddComponent<BlizzardAPIUnity_Singleton>();
					}
				}
				return instance;
			}
		}
		private static BlizzardAPIUnity_Singleton instance;

		protected virtual void Awake()
		{
			if (instance == null)
			{
				instance = this;
				DontDestroyOnLoad(gameObject);
			}
			else
			{
				Destroy(gameObject);
			}
		}

		#endregion

		#region Access Token

		/// <summary>
		/// Get an OAuth access token from Blizzard, required to call the API.
		/// </summary>
		/// <param name="region">Region used to get the access token.</param>
		/// <param name="result">Action to execute with the access token once retrieved.</param>
		public static void GetAccessToken(API.BattleNetRegion region, Action<string> result = null)
		{
			Instance.StartCoroutine(API.CheckAccessToken(region, result));
		}

		#endregion

		#region Character

		/// <summary>
		/// Retrieves informations about a WoW character from Blizzard as JSON, then convert the JSON to something easier to handle.
		/// </summary>
		/// <param name="region">The server region to get the character from.</param>
		/// <param name="realm">The realm the character is on.</param>
		/// <param name="name">THe character's name.</param>
		/// <param name="result">Action to execute with the character data once retrieved and converted.</param>
		/// <param name="locale">Locale to use for the retrieved data. Defaults to English (US).</param>
		public static void GetWoWCharacter(API.BattleNetRegion region, string realm, string name, Action<WowCharacterProfileSummary_JSON> result = null, string locale = "en_US")
		{
			Instance.StartCoroutine(BlizzardAPI_WowProfile.CGetCharacterProfileSummary(region, realm, name, x => result(x)));
		}

		#endregion

		#region Realm list

		/// <summary>
		/// 
		/// </summary>
		/// <param name="region"></param>
		/// <param name="result"></param>
		public static void GetRealmList(API.BattleNetRegion region, Action<WowRealmsIndex_JSON> result = null)
		{
			Instance.StartCoroutine(BlizzardAPI_WowGameData.CGetRealmsIndex(region, x => result(x)));
		}

		#endregion
	}
}