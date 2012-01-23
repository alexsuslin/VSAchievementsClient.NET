using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSAchievements.Api;
using VSAchievements.Api.Constants;
using VSAchievements.Api.Objects;

namespace VSAchievements.Test
{
    [TestClass]
    public class Tests
    {
        private VSAchivementsApi Client;

        public Tests()
        {
            Client = new VSAchivementsApi();
        }


        [TestMethod]
        public void GetAll()
        {
            VSAchievementsResponse<AchievementsCollection> response = Client.GetAchivements();
            Assert.IsNotNull(response.Data);
            foreach (Achivement archivement in response.Data.Achievements)
            {
                Assert.IsNotNull(archivement);
            }
        }

        [TestMethod]
        public void GetUserAchivements()
        {
            VSAchievementsResponse<UserAchievementsCollection> response = Client.GetUserAchivements(Config.Username);
            Assert.IsNotNull(response.Data);
            foreach (Achivement archivement in response.Data.Achievements)
            {
                Assert.IsNotNull(archivement);
            }
        }

        [TestMethod]
        public void GetEarnedUserAchivements()
        {
            VSAchievementsResponse<UserAchievementsCollection> response = Client.GetUserAchivements(Config.Username, AchivementStatus.Earned);
            Assert.IsNotNull(response.Data);
            foreach (EarnedAchivement archivement in response.Data.Achievements)
            {
                Assert.IsNotNull(archivement);
            }
        }
    }
}
