using System.Runtime.Serialization;
using VSAchievements.Api.Constants;

namespace VSAchievements.Api.Objects
{
    [DataContract]
    public class Achivement : EarnedAchivement
    {
        [DataMember(Name = Methods.Params.FriendlyName)]
        public string FriendlyName { get; set; }

        [DataMember(Name = Methods.Params.Description)]
        public string Description { get; set; }

        [DataMember(Name = Methods.Params.Category)]
        public string Category { get; set; }

        [DataMember(Name = Methods.Params.Points)]
        public int Points { get; set; }

        [DataMember(Name = Methods.Params.Icon)]
        public string IconUrl { get; set; }

        [DataMember(Name = Methods.Params.IconSmall)]
        public string IconSmallUrl { get; set; }
    }
}
