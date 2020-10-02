using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using ZeShmouttsAssets.BlizzardAPI.JSON;

namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		#region URL constants

		private const string URL_START = "https://";

		private const string URL_DOMAIN = ".api.blizzard.com";
		private const string URL_DOMAIN_CN = "gateway.battlenet.com.cn";

		private const string HEADER_NAMESPACE = "namespace=";
		private const string HEADER_TOKEN = "access_token=";

		private const string NAMESPACE_DYNAMIC = "dynamic-";
		private const string NAMESPACE_PROFILE = "profile-";
		private const string NAMESPACE_STATIC = "static-";
		private const string NAMESPACE_CLASSIC_DYNAMIC = "dynamic-classic-";
		private const string NAMESPACE_CLASSIC_PROFILE = "profile-classic-";
		private const string NAMESPACE_CLASSIC_STATIC = "static-classic-";

		private const string HEADER_API_NAMESPACE = "Battlenet-Namespace";
		private const string HEADER_AUTHORIZATION = "Authorization";
		private const string HEADER_IF_MODIFIED_SINCE = "If-Modified-Since";
		private const string HEADER_LAST_MODIFIED = "Last-Modified";

		#endregion

		#region Common API paths

		private const string BASEPATH_MEDIA = "/media";
		private const string BASEPATH_DATA = "/data";

		private const string BASEPATH_D3_GAMEDATA = BASEPATH_DATA + "/d3";

		private const string BASEPATH_HEARTHSTONE_GAMEDATA = "/hearthstone";

		private const string BASEPATH_SC2_GAMEDATA = BASEPATH_DATA + "/sc2";

		private const string BASEPATH_WOW_GAMEDATA = BASEPATH_DATA + "/wow";
		private const string BASEPATH_WOW_CHARACTER = "/profile/wow/character/";
		private const string BASEPATH_WOW_GUILD = BASEPATH_DATA + "/wow/guild/";

		#endregion

		#region Misc tools

		/// <summary>
		/// Converts a date into a HTML date formatted string used in request headers (same as 'ToString("r")').
		/// </summary>
		/// <param name="date">Date to convert.</param>
		/// <returns></returns>
		public static string ToHTMLDate(this DateTime date)
		{
			return date.ToString("r");
		}

		#endregion

		#region Preformatted request

		/// <summary>
		/// Send a request to Blizzard with the specified parameters, converts the result to a JSON-based class, and execute an action on the result.
		/// </summary>
		/// <typeparam name="T">Type of JSON result expected (character, realm, etc.).</typeparam>
		/// <param name="region">Region to retrieve the data from.</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="action_Result">Action to execute with the result of the request.</param>
		/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
		/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
		/// <param name="additionalHeaders">Additional headers to send with the web request.</param>
		/// <returns></returns>
		public static IEnumerator SendRequest<T>(BattleNetRegion region, string apiNamespace, string apiPath, Action<T> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null) where T : Object_JSON
		{
			if (action_Result != null)
			{
				yield return SendRequest(region, apiNamespace, apiPath, x => action_Result(JsonUtility.FromJson<T>(x)), ifModifiedSince, action_LastModified);
			}
			else
			{
				yield return SendRequest(region, apiNamespace, apiPath, null, ifModifiedSince, action_LastModified);
			}
		}

		/// <summary>
		/// Send a request to Blizzard with the specified parameters, and execute an action on the JSON result.
		/// </summary>
		/// <param name="region">Region to retrieve the data from.</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="action_Result">Action to execute with the result of the request.</param>
		/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
		/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
		/// <param name="additionalHeaders">Additional headers to send with the web request.</param>
		/// <returns></returns>
		public static IEnumerator SendRequest(BattleNetRegion region, string apiNamespace, string apiPath, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
		{
			yield return CheckAccessToken();

			string url = UrlDomain(region) + apiPath;

			Dictionary<string, string> headers;
			if (!string.IsNullOrEmpty(apiNamespace))
			{
				headers = CreateHeaders(apiNamespace + RegionToString(region), ifModifiedSince);
			}
			else
			{
				headers = CreateHeaders(null, ifModifiedSince);
			}

			yield return APIRequest(url, headers, action_Result, action_LastModified);
		}

		#endregion

		#region Custom request by URL

		internal const string URL_NAMESPACE_PARAMETER = "namespace";

		/// <summary>
		/// Send a request to Blizzard with the specified URL, converts the result to a JSON-based class, and execute an action on the result.
		/// </summary>
		/// <typeparam name="T">Type of JSON result expected (character, realm, etc.).</typeparam>
		/// <param name="url">Region to retrieve the data from.</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="action_Result">Action to execute with the result of the request.</param>
		/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
		/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
		/// <param name="additionalHeaders">Additional headers to send with the web request.</param>
		/// <returns></returns>
		public static IEnumerator CustomRequest<T>(string url, Dictionary<string, string> additionalHeaders, Action<T> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null) where T : Object_JSON
		{
			if (action_Result != null)
			{
				yield return CustomRequest(url, additionalHeaders, x => action_Result(JsonUtility.FromJson<T>(x)), ifModifiedSince, action_LastModified);
			}
			else
			{
				yield return CustomRequest(url, additionalHeaders, null, ifModifiedSince, action_LastModified);
			}
		}

		/// <summary>
		/// Send a request to Blizzard with the specified URL, and execute an action on the JSON result.
		/// </summary>
		/// <param name="url">Region to retrieve the data from.</param>
		/// <param name="apiNamespace">Blizzard's API namespace used for this request (use API.Namespaces for that).</param>
		/// <param name="apiPath">URL path to the requested document (see the API documentation for that).</param>
		/// <param name="action_Result">Action to execute with the result of the request.</param>
		/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
		/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
		/// <param name="additionalHeaders">Additional headers to send with the web request.</param>
		/// <returns></returns>
		public static IEnumerator CustomRequest(string url, Dictionary<string, string> additionalHeaders, Action<string> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null)
		{
			yield return CheckAccessToken();

			Dictionary<string, string> headers = CreateHeaders(null, ifModifiedSince);
			if (additionalHeaders != null && additionalHeaders.Count > 0)
			{
				foreach (var item in additionalHeaders)
				{
					headers.Add(item.Key, item.Value);
				}
			}

			yield return APIRequest(url, headers, action_Result, action_LastModified);
		}

		#endregion

		#region Base request methods

		/// <summary>
		/// Create basic request headers from the specified parameters, including the access token.
		/// </summary>
		/// <param name="apiNamespace">Blizzard's API namespace used for the request (use BlizzardAPI.namespace for that).</param>
		/// <param name="ifModifiedSince">Adds a request header to check if the document has been modified since this date (in HTML format), which will return an empty response body if it's older.</param>
		/// <returns></returns>
		private static Dictionary<string, string> CreateHeaders(string apiNamespace, string ifModifiedSince)
		{
			Dictionary<string, string> headers = new Dictionary<string, string>
			{
				{ HEADER_AUTHORIZATION, "Bearer " + accessToken.token }
			};

			if (!string.IsNullOrEmpty(apiNamespace))
			{
				headers.Add(HEADER_API_NAMESPACE, apiNamespace);
			}

			if (!string.IsNullOrEmpty(ifModifiedSince))
			{
				headers.Add(HEADER_IF_MODIFIED_SINCE, ifModifiedSince);
			}

			return headers;
		}

		/// <summary>
		/// Send a request to Blizzard with the specified URL, and execute an action on the JSON result.
		/// </summary>
		/// <param name="url">The complete URL path to the data.</param>
		/// <param name="headers">The request headers.</param>
		/// <param name="action_Result">Action to execute with the result of the request.</param>
		/// <param name="action_LastModified">Action to execute with the date of the last server-side modification to the document.</param>
		/// <returns></returns>
		private static IEnumerator APIRequest(string url, Dictionary<string, string> headers, Action<string> action_Result, Action<string> action_LastModified)
		{
			UnityWebRequest request = UnityWebRequest.Get(url);
			foreach (KeyValuePair<string, string> item in headers)
			{
				request.SetRequestHeader(item.Key, item.Value);
			}

			yield return request.SendWebRequest();

			if (!request.isNetworkError && !request.isHttpError)
			{
				if (request.responseCode != 304)
				{
					string resultContent = request.downloadHandler.text;

					Debug.LogFormat("Retrieved JSON : {0}", resultContent);

					if (action_Result != null)
					{
						action_Result(resultContent);
					}
				}
				else
				{
					Debug.LogFormat("Requested document was not modified since {0}", headers[HEADER_IF_MODIFIED_SINCE]);
				}

				if (action_LastModified != null)
				{
					string lastModifiedString = request.GetResponseHeader(HEADER_LAST_MODIFIED);
					action_LastModified(lastModifiedString);
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