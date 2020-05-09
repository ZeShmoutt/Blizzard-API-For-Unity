namespace ZeShmouttsAssets.BlizzardAPI
{
	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		/// <summary>
		/// Creates a nicely formatted API path to a WoW character.
		/// </summary>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="characterName">The lowercase name of the character.</param>
		/// <returns>Returns an API path.</returns>
		internal static string FormatWowCharacterEndpointPath(string realmSlug, string characterName)
		{
			return string.Concat(basePath_Wow_character, realmSlug, "/", characterName);
		}

		/// <summary>
		/// Creates a nicely formatted API path to a WoW guild.
		/// </summary>
		/// <param name="realmSlug">The slug of the realm.</param>
		/// <param name="nameSlug">The slug of the guild (usually, the guild's name in lowercase with spaces replaced by '-').</param>
		/// <returns>Returns an API path.</returns>
		internal static string FormatWowGuildEndpointPath(string realmSlug, string nameSlug)
		{
			return string.Concat(basePath_Wow_guild, realmSlug, "/", nameSlug);
		}
	}
}
