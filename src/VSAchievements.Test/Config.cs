namespace VSAchievements.Test
{

    using AppConfig = System.Configuration.ConfigurationManager;

    internal static class Config
    {
        #region Properties

        internal static string Username = AppConfig.AppSettings["Username"] ?? "<INSERT USERNAME>";

        #endregion
    }
}


