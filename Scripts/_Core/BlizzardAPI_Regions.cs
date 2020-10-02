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

		private const string REGION_UNITED_STATES = "us";
		private const string REGION_EUROPE = "eu";
		private const string REGION_KOREA = "kr";
		private const string REGION_TAIWAN = "tw";
		private const string REGION_CHINA = "cn";

		private const BattleNetRegion DEFAULT_REGION = BattleNetRegion.UnitedStates;

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
					return string.Concat(URL_START, URL_DOMAIN_CN);
				default:
					return string.Concat(URL_START, RegionToString(region), URL_DOMAIN);
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
					return REGION_UNITED_STATES;
				case BattleNetRegion.Europe:
					return REGION_EUROPE;
				case BattleNetRegion.Korea:
					return REGION_KOREA;
				case BattleNetRegion.Taiwan:
					return REGION_TAIWAN;
				case BattleNetRegion.China:
					return REGION_CHINA;
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
				case REGION_UNITED_STATES:
					return BattleNetRegion.UnitedStates;
				case REGION_EUROPE:
					return BattleNetRegion.Europe;
				case REGION_KOREA:
					return BattleNetRegion.Korea;
				case REGION_TAIWAN:
					return BattleNetRegion.Taiwan;
				case REGION_CHINA:
					return BattleNetRegion.China;
				default:
					return BattleNetRegion.UnitedStates;
			}
		}

		#endregion
	}
}