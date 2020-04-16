using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static class BlizzardAPI
	{
		#region Constants

		public const string urlStart = "https://";

		public const string oauthTokenURL = ".battle.net/oauth/token";
		public const string oauthAuthorizeURL = ".battle.net/oauth/authorize";

		public const string prefsTokenGeneral = "BlizzardOAuthTokenGeneral";
		public const string prefsTokenProfile = "BlizzardOAuthTokenProfile";

		private const string urlDomain = ".api.blizzard.com";
		private const string urlDomainCN = "gateway.battlenet.com.cn";

		public const string headerNamespace = "namespace=";
		public const string headerToken = "access_token=";

		public const string namespaceDynamic = "dynamic-";
		public const string namespaceProfile = "profile-";
		public const string namespaceStatic = "static-";

		public enum BattleNetRegion { UnitedStates, Europe, Korea, Taiwan, China }

		#endregion

		#region Region tools

		private const string regionUnitedStates = "us";
		private const string regionEurope = "eu";
		private const string regionKorea = "kr";
		private const string regionTaiwan = "tw";
		private const string regionChina = "cn";

		/// <summary>
		/// Returns a formatted API url based on the region.
		/// </summary>
		/// <param name="region">Targeted region.</param>
		/// <returns></returns>
		public static string UrlDomain(BattleNetRegion region)
		{
			switch (region)
			{
				case BattleNetRegion.China:
					return string.Concat(urlStart, urlDomainCN);
				default:
					return string.Concat(urlStart, region.RegionToString(), urlDomain);
			}
		}

		/// <summary>
		/// Returns a short version of the region's name used in URLs (such as "eu", "us", "kr", etc.).
		/// </summary>
		/// <param name="region">Region to convert.</param>
		/// <returns></returns>
		public static string RegionToString(this BattleNetRegion region)
		{
			switch (region)
			{
				case BattleNetRegion.UnitedStates:
					return regionUnitedStates;
				case BattleNetRegion.Europe:
					return regionEurope;
				case BattleNetRegion.Korea:
					return regionKorea;
				case BattleNetRegion.Taiwan:
					return regionTaiwan;
				case BattleNetRegion.China:
					return regionChina;
				default:
					return "";
			}
		}

		#endregion

		#region URL building tools

		/// <summary>
		/// Creates a nicely formatted request URL, including the namespace and access token.
		/// </summary>
		/// <param name="region">Region to retrieve the data from.</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="queryParameters">Additional query parameters to add to the request. No "&" needed.</param>
		/// <returns></returns>
		public static string UrlFormatter(BattleNetRegion region, string apiPath, string apiNamespace, params string[] queryParameters)
		{
			StringBuilder sb = new StringBuilder();
			string regionString = region.RegionToString();

			sb.Append(UrlDomain(region));
			sb.Append(apiPath);
			sb.Append("?");
			sb.Append(headerNamespace);
			sb.Append(apiNamespace);
			sb.Append(regionString);
			sb.Append("&");
			sb.Append(headerToken);
			sb.Append(accessToken.token);

			if (queryParameters.Length > 0)
			{
				for (int i = 0; i < queryParameters.Length; i++)
				{
					sb.Append("&");
					sb.Append(queryParameters[i]);
				}
			}

			return sb.ToString();
		}

		#endregion

		#region Access Token variables

		/// <summary>
		/// JSON structure for OAUth access tokens.
		/// </summary>
		public struct AccessToken_JSON
		{
			public string access_token;
			public string token_type;
			public int expires_in;
			public string scope;
		}

		/// <summary>
		/// JSON structure for stored OAUth access tokens.
		/// </summary>
		public struct StoredToken_JSON
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
		public class AccessToken
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

		public static AccessToken accessToken;

		#endregion

		#region Access Token methods

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
		public static IEnumerator CheckAccessToken(BattleNetRegion region, Action<string> result = null)
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
					string url = string.Concat(urlStart, region.RegionToString(), oauthTokenURL);

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

		#region Common request method

		/// <summary>
		/// Send a request to Blizzard with the specified URL, and execute an action on the result.
		/// </summary>
		/// <typeparam name="T">Type of JSON result expected (character, realm, etc.).</typeparam>
		/// <param name="region">Region to retrieve the data from.</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="result">Action to apply to the result.</param>
		/// <returns></returns>
		public static IEnumerator SendRequest<T>(BattleNetRegion region, string apiNamespace, string apiPath, Action<T> result) where T : Object_Json
		{
			yield return CheckAccessToken(region);

			string url = UrlFormatter(region, apiPath, apiNamespace);

			UnityWebRequest request = UnityWebRequest.Get(url);
			yield return request.SendWebRequest();

			if (!request.isNetworkError && !request.isHttpError)
			{
				string resultContent = request.downloadHandler.text;
				T json = JsonUtility.FromJson<T>(resultContent);

				Debug.LogFormat("Retrieved {0} : {1}", typeof(T).Name, resultContent);

				if (result != null)
				{
					result(json);
				}
			}
			else
			{
				Debug.LogError("<color=red>Error : </color>" + request.error);
			}
		}

		/// <summary>
		/// EXPERIMENTAL FEATURE, USE WITH CAUTION. Same as SendRequest except it uses web request headers to send the token and namespace, instead of cramming everything in the url.
		/// </summary>
		/// <typeparam name="T">Type of JSON result expected (character, realm, etc.).</typeparam>
		/// <param name="region">Region to retrieve the data from.</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="headers">Headers to send with the web request.</param>
		/// <param name="result">Action to apply to the result.</param>
		/// <returns></returns>
		public static IEnumerator SendRequestHeaders<T>(BattleNetRegion region, string apiNamespace, string apiPath, Dictionary<string, string> headers, Action<T> result) where T : Object_Json
		{
			yield return CheckAccessToken(region);

			string url = UrlDomain(region) + apiPath;

			UnityWebRequest request = UnityWebRequest.Get(url);
			foreach (KeyValuePair<string, string> item in headers)
			{
				request.SetRequestHeader(item.Key, item.Value);
			}

			yield return request.SendWebRequest();

			if (!request.isNetworkError && !request.isHttpError)
			{
				string resultContent = request.downloadHandler.text;
				T json = JsonUtility.FromJson<T>(resultContent);

				Debug.LogFormat("Retrieved {0} : {1}", typeof(T).Name, resultContent);

				if (result != null)
				{
					result(json);
				}
			}
			else
			{
				Debug.LogError("<color=red>Error : </color>" + request.error);
			}
		}

		#endregion
	}
}