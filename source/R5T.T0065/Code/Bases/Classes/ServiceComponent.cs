using System;


namespace R5T.T0065
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceComponent : IServiceComponent
    {
        #region Static
        
        public static ServiceComponent Instance { get; } = new();

        #endregion
    }
}