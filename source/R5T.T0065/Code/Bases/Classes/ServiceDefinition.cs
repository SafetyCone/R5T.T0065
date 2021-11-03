using System;


namespace R5T.T0065
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceDefinition : IServiceDefinition
    {
        #region Static
        
        public static ServiceDefinition Instance { get; } = new();

        #endregion
    }
}