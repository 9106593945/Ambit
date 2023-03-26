//-----------------------------------------------------------------------
// <copyright file="SQLConfig.cs" company="Dexoc Solutions">
//     Copyright Dexoc Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Ambit.Data
{
    /// <summary>
    /// SQL configuration class which holds stored procedure name.
    /// </summary>
    internal sealed class SQLConfig
    {
        
        #region Users        
        public const string CustomerLoginUpsert = "dbo.CustomerLoginUpsert";
        public const string Login = "dbo.Login";

        #endregion

    }
}
