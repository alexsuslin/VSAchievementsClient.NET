using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using VSAchievements.Api.Constants;

namespace VSAchievements.Api.Objects
{
    [DataContract]
    public class AchievementsCollection
    {
        [DataMember(Name = Methods.Params.Name)]
        public string Name { get; set; }

        [DataMember(Name = Methods.Params.FriendlyName)]
        public string FriendlyName { get; set; }

        [DataMember(Name = Methods.Params.Description)]
        public string Description { get; set; }

        [DataMember(Name = Methods.Params.Icon)]
        public string IconUrl { get; set; }

        [DataMember(Name = Methods.Params.InstallLink)]
        public string InstallLink { get; set; }

        [DataMember(Name = Methods.Params.ID)]
        public Guid ID { get; set; }

        [DataMember(Name = Methods.Params.PromoDescription)]
        public string PromoDescription { get; set; }

        [DataMember(Name = Methods.Params.TwitterHashtag)]
        public string TwitterHashtag { get; set; }

        [DataMember(Name = Methods.Params.Achievements)]
        public List<Achivement> Achievements { get; set; }
    }
}
