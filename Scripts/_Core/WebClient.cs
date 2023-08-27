using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public static class WebClient
{
	private static HttpClient m_client = null;
	public static HttpClient Client
	{
		get
		{
			if (m_client == null)
			{
				Debug.Log("No HTTP client found, creating one...");
				m_client = new HttpClient();
				Debug.Log("HTTP client created.");
			}
			else
			{
				Debug.Log("HTTP client found.");
			}
			return m_client;
		}
	}
}
