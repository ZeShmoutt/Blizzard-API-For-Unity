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
		#region Constants

		private const string urlStart = "https://";

		private const string urlDomain = ".api.blizzard.com";
		private const string urlDomainCN = "gateway.battlenet.com.cn";

		private const string headerNamespace = "namespace=";
		private const string headerToken = "access_token=";

		private const string namespaceDynamic = "dynamic-";
		private const string namespaceProfile = "profile-";
		private const string namespaceStatic = "static-";

		private const string characterBasePath = "/profile/wow/character/";

		#endregion

		#region Misc tools

		/// <summary>
		/// Converts a date into a HTML date formatted string used in request headers (same as 'ToString("r")').
		/// </summary>
		/// <param name="date">Date to convert.</param>
		/// <returns></returns>
		private static string ToHTMLDate(this DateTime date)
		{
			return date.ToString("r");
		}

		#endregion

		#region Common request method

		private const string headerApiNamespace = "Battlenet-Namespace";
		private const string headerAuthorization = "Authorization";
		private const string headerIfModifiedSince = "If-Modified-Since";
		private const string headerLastModified = "Last-Modified";

		/// <summary>
		/// Send a request to Blizzard with the specified URL, and execute an action on the result.
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
		private static IEnumerator SendRequest<T>(BattleNetRegion region, string apiNamespace, string apiPath, Action<T> action_Result, string ifModifiedSince = null, Action<string> action_LastModified = null) where T : Object_Json
		{
			yield return CheckAccessToken(region);

			string url = UrlDomain(region) + apiPath;

			Dictionary<string, string> headers = new Dictionary<string, string>()
			{
				{ headerApiNamespace, apiNamespace + RegionToString(region) },
				{ headerAuthorization, "Bearer " + accessToken.token }
			};

			if (!string.IsNullOrEmpty(ifModifiedSince))
			{
				headers.Add(headerIfModifiedSince, ifModifiedSince);
			}

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
					T json = JsonUtility.FromJson<T>(resultContent);

					Debug.LogFormat("Retrieved {0} : {1}", typeof(T).Name, resultContent);

					if (action_Result != null)
					{
						action_Result(json);
					}

				}
				else
				{
					Debug.LogFormat("Requested document has not modified since {0}" + ifModifiedSince);
				}

				if (action_LastModified != null)
				{
					string lastModifiedString = request.GetResponseHeader(headerLastModified);
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