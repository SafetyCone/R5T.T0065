using System;


namespace R5T.T0065
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceImplementation : IServiceImplementation
    {
        #region Static
        
        public static ServiceImplementation Instance { get; } = new();

        #endregion
    }
}