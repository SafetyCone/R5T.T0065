using System;


namespace R5T.T0065
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceDefinitionOperator : IServiceDefinitionOperator
    {
        #region Static
        
        public static ServiceDefinitionOperator Instance { get; } = new();

        #endregion
    }
}