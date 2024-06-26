﻿namespace Grand.Infrastructure.Caching.Constants;

public static partial class CacheKey
{
    #region Permission

    /// <summary>
    ///     Key for caching
    /// </summary>
    /// <remarks>
    ///     {0} : customer group ID
    ///     {1} : permission system name
    /// </remarks>
    public static string PERMISSIONS_ALLOWED_KEY => "Grand.permission.allowed-{0}-{1}";

    /// <summary>
    ///     Key for caching
    /// </summary>
    /// <remarks>
    ///     {0} : customer group ID
    ///     {1} : permission system name
    ///     {2} : permission action name
    /// </remarks>
    public static string PERMISSIONS_ALLOWED_ACTION_KEY => "Grand.permission.allowed.action-{0}-{1}-{2}";

    /// <summary>
    ///     Key pattern to clear cache
    /// </summary>
    public static string PERMISSIONS_PATTERN_KEY => "Grand.permission.";

    #endregion
}