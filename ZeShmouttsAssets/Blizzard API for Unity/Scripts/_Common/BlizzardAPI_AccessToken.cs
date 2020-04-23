using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		#region Constants

		private const string oauthTokenURL = ".battle.net/oauth/token";
		private const string oauthAuthorizeURL = ".battle.net/oauth/authorize";

		private const string prefsTokenGeneral = "BlizzardOAuthTokenGeneral";
		private const string prefsTokenProfile = "BlizzardOAuthTokenProfile";

		#endregion

		#region Variables

#pragma warning disable 0649
		/// <summary>
		/// JSON structure for OAUth access tokens.
		/// </summary>
		[Serializable]
		private struct AccessToken_JSON
		{
			public string access_token;
			public string token_type;
			public int expires_in;
			public string scope;
		}

		/// <summary>
		/// JSON structure for stored OAUth access tokens.
		/// </summary>
		[Serializable]
		private struct StoredToken_JSON
		{
			public string access_token;
			public string token_type;
			public string expiration;
			public string scope;
		}

		/// <summary>
		/// OAuth access token.
		/// </summary>
		[Serializable]
		private class AccessToken
		{
			/// <summary>
			/// The OAuth token.
			/// </summary>
			public string token { get; private set; }

			/// <summary>
			/// The type of the token.
			/// </summary>
			public string type { get; private set; }

			/// <summary>
			/// The time and date at which the token will expire.
			/// </summary>
			public DateTime expiration { get; private set; }

			/// <summary>
			/// The scope of the token.
			/// </summary>
			public string scope { get; private set; }

			public AccessToken(string access_token, string token_type, DateTime expiration, string scope)
			{
				this.token = access_token;
				this.type = token_type;
				this.expiration = expiration;
				this.scope = scope;
			}

			public AccessToken(string access_token, string token_type, int expires_in, string scope)
			{
				this.token = access_token;
				this.type = token_type;
				this.expiration = DateTime.Now.AddSeconds(expires_in);
			}

			public AccessToken(AccessToken_JSON json)
			{
				this.token = json.access_token;
				this.type = json.token_type;
				this.expiration = DateTime.Now.AddSeconds(json.expires_in);
				this.scope = json.scope;
			}
		}
#pragma warning restore 0649

		private static AccessToken accessToken;

		#endregion

		#region Methods

		/// <summary>
		/// Retrieves an access token from the selected PlayerPrefs.
		/// </summary>
		/// <param name="prefsName">PlayerPrefs where the token is stored.</param>
		/// <returns>Returns an access token converted from JSON, or 'null' if the PlayerPrefs is invalid.</returns>
		private static AccessToken GetPrefsToken(string prefsName)
		{
			string tokenString = PlayerPrefs.GetString(prefsName);

			if (string.IsNullOrEmpty(tokenString)) { return null; }

			StoredToken_JSON tokenJson = JsonUtility.FromJson<StoredToken_JSON>(tokenString);
			long temp;
			try { temp = Convert.ToInt64(tokenJson.expiration); } catch { temp = 0; }
			DateTime expiration = temp != 0 ? DateTime.FromBinary(temp) : DateTime.Now.AddSeconds(-1);

			return new AccessToken(tokenJson.access_token, tokenJson.token_type, expiration, tokenJson.scope);
		}

		/// <summary>
		/// Saves an access token at the selected PlayerPrefs.
		/// </summary>
		/// <param name="prefsName">PlayerPrefs where the token will be saved as JSON.</param>
		/// <param name="token">Access toekn to save.</param>
		private static void SetPrefsToken(string prefsName, AccessToken token)
		{
			StoredToken_JSON tokenJson = new StoredToken_JSON()
			{
				access_token = token.token,
				token_type = token.type,
				expiration = token.expiration.ToBinary().ToString(),
				scope = token.scope
			};

			PlayerPrefs.SetString(prefsName, JsonUtility.ToJson(tokenJson));
		}

		/// <summary>
		/// Coroutine checks the cached access token validity. If it isn't valid, retrieves a token from PlayerPrefs if it exists, or get a new token from Blizzard using OAuth.
		/// </summary>
		/// <param name="region">Region used to get the access token.</param>
		/// <param name="result">Action to execute with the access token once retrieved.</param>
		/// <returns></returns>
		public static IEnumerator CheckAccessToken(BattleNetRegion region = BattleNetRegion.UnitedStates, Action<string> result = null)
		{
			DateTime currentDate = DateTime.Now;

			if (accessToken != null && accessToken.token.Length <= 0 && accessToken.expiration >= currentDate)
			{
				// If we already have a valid access token in the cache, update it and skip the rest
				SetPrefsToken(prefsTokenGeneral, accessToken);
				Debug.LogFormat("Cached token still valid : '{0}' (expires {1})", accessToken.token, accessToken.expiration.ToString());

				if (result != null)
				{
					result(accessToken.token);
				}

				yield break;
			}
			else
			{
				// Making sure that we don't keep anything from the invalid "token"
				accessToken = null;

				// If the token is invalid, try to fetch it from the PlayerPrefs first
				AccessToken storedToken = GetPrefsToken(prefsTokenGeneral);

				if (storedToken != null && storedToken.token.Length > 0 && storedToken.expiration > currentDate)
				{
					// If the stored access token is still valid, replace the cache with it and skip the rest
					Debug.LogFormat("Stored token still valid : '{0}' (expires {1})", storedToken.token, storedToken.expiration.ToString());

					if (result != null)
					{
						result(storedToken.token);
					}

					accessToken = storedToken;
					yield break;
				}
				else
				{
					Debug.Log("Invalid access token, retrieving a new token...");

					// The stored token is also invalid, fetch an entirely new token, cache it, and store it
					string url = string.Concat(urlStart, RegionToString(region), oauthTokenURL);

					Dictionary<string, string> form = new Dictionary<string, string>()
					{
						{ "grant_type", "client_credentials" },
						{ "client_id", AppInfos.BlizzardClientID },
						{ "client_secret", AppInfos.BlizzardClientSecret }
					};

					UnityWebRequest tokenRequest = UnityWebRequest.Post(url, form);
					yield return tokenRequest.SendWebRequest();

					if (!tokenRequest.isNetworkError && !tokenRequest.isHttpError)
					{
						string resultContent = tokenRequest.downloadHandler.text;
						AccessToken_JSON json = JsonUtility.FromJson<AccessToken_JSON>(resultContent);

						accessToken = new AccessToken(json);

						SetPrefsToken(prefsTokenGeneral, accessToken);
						Debug.LogFormat("Access token granted : '{0}' ; expires {1}", accessToken.token, accessToken.expiration.ToString());

						if (result != null)
						{
							result(accessToken.token);
						}
					}
					else
					{
						Debug.LogError("<color=red>Error : </color>" + tokenRequest.error);
					}
				}
			}
		}

		#endregion
	}
}