using System;


namespace R5T.T0065
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceComponentOperator : IServiceComponentOperator
    {
        #region Static
        
        public static ServiceComponentOperator Instance { get; } = new();

        #endregion
    }
}