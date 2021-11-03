using System;


namespace R5T.T0065
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceImplementationOperator : IServiceImplementationOperator
    {
        #region Static
        
        public static ServiceImplementationOperator Instance { get; } = new();

        #endregion
    }
}