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

		public const string oauthAuthorizeURL = "https://{0}.battle.net/oauth/authorize";
		public const string oauthTokenURL = "https://{0}.battle.net/oauth/token";

		public const string prefsTokenValue = "BlizzardOAuthTokenValue";
		public const string prefsTokenType = "BlizzardOAuthTokenType";
		public const string prefsTokenExpiration = "BlizzardOAuthTokenExpiration";

		public const string urlStart = "https://";
		public const string headerNamespace = "namespace=";
		public const string headerToken = "access_token=";

		public const string namespaceDynamic = "dynamic-";
		public const string namespaceProfile = "profile-";
		public const string namespaceStatic = "static-";

		public enum BattleNetRegion { UnitedStates, Europe, Korea, Taiwan, China }

		#endregion

		#region Region tools

		private const string urlDomain = ".api.blizzard.com";
		private const string urlDomainCN = "gateway.battlenet.com.cn";

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
					return urlStart + urlDomainCN;
				default:
					return urlStart + region.RegionToString() + urlDomain;
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
		public struct AccessTokenJSON
		{
			public string access_token;
			public string token_type;
			public int expires_in;
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

			public AccessToken(string access_token, string token_type, DateTime expiration)
			{
				this.token = access_token;
				this.type = token_type;
				this.expiration = expiration;
			}

			public AccessToken(string access_token, string token_type, int expires_in)
			{
				this.token = access_token;
				this.type = token_type;
				this.expiration = DateTime.Now.AddSeconds(expires_in);
			}

			public AccessToken(AccessTokenJSON json)
			{
				this.token = json.access_token;
				this.type = json.token_type;
				this.expiration = DateTime.Now.AddSeconds(json.expires_in);
			}
		}

		public static AccessToken accessToken;

		#endregion

		#region Access Token methods

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
				PlayerPrefs.SetString(prefsTokenValue, accessToken.token);
				PlayerPrefs.SetString(prefsTokenType, accessToken.type);
				PlayerPrefs.SetString(prefsTokenExpiration, accessToken.expiration.ToBinary().ToString());

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
				string token = PlayerPrefs.GetString(prefsTokenValue);
				string type = PlayerPrefs.GetString(prefsTokenType);
				string expString = PlayerPrefs.GetString(prefsTokenExpiration);
				long temp;

				try { temp = Convert.ToInt64(expString); }
				catch { temp = 0; }

				DateTime expiration = temp != 0 ? DateTime.FromBinary(temp) : DateTime.Now.AddSeconds(-1);

				AccessToken storedToken = new AccessToken(token, type, expiration);

				if (storedToken.token.Length > 0 && storedToken.expiration > currentDate)
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
					string url = string.Format(oauthTokenURL, region.RegionToString());

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
						AccessTokenJSON json = JsonUtility.FromJson<AccessTokenJSON>(resultContent);

						accessToken = new AccessToken(json);

						PlayerPrefs.SetString(prefsTokenValue, accessToken.token);
						PlayerPrefs.SetString(prefsTokenType, accessToken.type);
						PlayerPrefs.SetString(prefsTokenExpiration, accessToken.expiration.ToBinary().ToString());

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