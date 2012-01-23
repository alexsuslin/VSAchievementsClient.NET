using System.Runtime.Serialization;
using VSAchievements.Api.Constants;

namespace VSAchievements.Api.Objects
{
    [DataContract]
    public class UserAchievementsCollection: AchievementsCollection
    {
        [DataMember(Name = Methods.Params.UserFriendlyName)]
        public string UserFriendlyName { get; set; }

        [DataMember(Name = Methods.Params.TotalScore)]
        public int TotalScore { get; set; }
    }
}
