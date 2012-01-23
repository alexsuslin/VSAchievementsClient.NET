namespace VSAchievements.Api.Constants
{
    public class Methods
    {
        public static readonly string GetUserAchivements = string.Format("niners/{{{0}}}/achievements/visualstudio", Params.Username);
        public const string GetAll = "achievements/visualstudio/";

        public struct Params
        {
            public const string DateEarned = "DateEarned";
            public const string Name = "Name";
            public const string FriendlyName = "FriendlyName";
            public const string Description = "Description";
            public const string Icon = "Icon";
            public const string InstallLink = "InstallLink";
            public const string ID = "ID";
            public const string PromoDescription = "PromoDescription";
            public const string TwitterHashtag = "TwitterHashtag";
            public const string Achievements = "Achievements";
            public const string Category = "Category";
            public const string Points = "Points";
            public const string IconSmall = "IconSmall";
            public const string Json = "json";
            public const string Username = "Username";
            public const string UserFriendlyName = "UserFriendlyName";
            public const string TotalScore = "TotalScore";
            public const string Raw = "raw";
        }
    }
}
