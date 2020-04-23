namespace ZeShmouttsAssets.BlizzardAPI
{
	#region Base type
	// Note : outside of the 'BlizzardAPI' class for convenience

	/// <summary>
	/// Enum type used for Battle.net server regions.
	/// </summary>
	public enum BattleNetRegion
	{
		UnitedStates,
		Europe,
		Korea,
		Taiwan,
		China
	}

	#endregion

	/// <summary>
	/// Interface for working with the Blizzard API inside Unity.
	/// </summary>
	public static partial class BlizzardAPI
	{
		#region Constants

		private const string regionUnitedStates = "us";
		private const string regionEurope = "eu";
		private const string regionKorea = "kr";
		private const string regionTaiwan = "tw";
		private const string regionChina = "cn";

		#endregion

		#region Shortcuts

		/// <summary>
		/// Returns a formatted API url based on the region.
		/// </summary>
		/// <param name="region">Targeted region.</param>
		/// <returns></returns>
		private static string UrlDomain(BattleNetRegion region)
		{
			switch (region)
			{
				case BattleNetRegion.China:
					return string.Concat(urlStart, urlDomainCN);
				default:
					return string.Concat(urlStart, RegionToString(region), urlDomain);
			}
		}

		/// <summary>
		/// Returns a short version of the region's name used in URLs (such as "eu", "us", "kr", etc.). Defaults to "us".
		/// </summary>
		/// <param name="region">Region to convert.</param>
		/// <returns></returns>
		private static string RegionToString(BattleNetRegion region)
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

		/// <summary>
		/// Returns an enum value corresponding to the region's short name used in URLs (such as "eu", "us", "kr", etc.). Defaults to "BattleNetRegion.UnitedStates".
		/// </summary>
		/// <param name="regionString">String to convert.</param>
		/// <returns></returns>
		private static BattleNetRegion StringToRegion(string regionString)
		{
			switch (regionString)
			{
				case regionUnitedStates:
					return BattleNetRegion.UnitedStates;
				case regionEurope:
					return BattleNetRegion.Europe;
				case regionKorea:
					return BattleNetRegion.Korea;
				case regionTaiwan:
					return BattleNetRegion.Taiwan;
				case regionChina:
					return BattleNetRegion.China;
				default:
					return BattleNetRegion.UnitedStates;
			}
		}

		#endregion
	}
}