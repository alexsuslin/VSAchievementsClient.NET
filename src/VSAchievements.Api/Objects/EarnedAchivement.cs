using System;
using System.Runtime.Serialization;
using VSAchievements.Api.Constants;

namespace VSAchievements.Api.Objects
{
    [DataContract]
    public class EarnedAchivement
    {
        [DataMember(Name = Methods.Params.Name)]
        public string Name { get; set; }

        [DataMember(Name = Methods.Params.DateEarned)]
        public DateTime DateEarned { get; set; }
    }
}
