using RestSharp;
using VSAchievements.Api.Constants;
using VSAchievements.Api.Objects;
using VSAchievements.Api.Objects.JsonUtilities;

namespace VSAchievements.Api
{
    public class VSAchivements
    {
        #region Fields & Consts

        public const string BaseUrl = " http://channel9.msdn.com/";
        private readonly string ApiUrl;

        #endregion

        #region Constructors

        public VSAchivements(string baseUrl = BaseUrl)
        {
            
            ApiUrl = baseUrl;
        }

        #endregion

        #region Api Methods

        public VSAchievementsResponse<AchievementsCollection> GetAchivements()
        {
            RestRequest request = new RestRequest(Methods.GetAll);
            request.AddParameter(Methods.Params.Json, true);
            VSAchievementsResponse<AchievementsCollection> response = Execute<AchievementsCollection>(request);
            return response;
        }

        public VSAchievementsResponse<UserAchievementsCollection> GetUserAchivements(string username,
                                                                                     AchivementStatus status = AchivementStatus.All)
        {
            RestRequest request = new RestRequest(Methods.GetUserAchivements);
            request.AddParameter(Methods.Params.Json, true);
            request.AddParameter(Methods.Params.Username, username, ParameterType.UrlSegment);
            if (status == AchivementStatus.Earned)
                request.AddParameter(Methods.Params.Raw, true);
            VSAchievementsResponse<UserAchievementsCollection> response = Execute<UserAchievementsCollection>(request);
            return response;
        }

        #endregion

        #region Helper Methods

        private VSAchievementsResponse<T> Execute<T>(RestRequest request) where T : new()
        {
            RestClient client = new RestClient(ApiUrl);
            request = RequestSetup(client, request);
            return new VSAchievementsResponse<T>(client.Execute<T>(request));
        }

        private VSAchievementsResponse Execute(RestRequest request)
        {
            RestClient client = new RestClient(ApiUrl);
            request = RequestSetup(client, request);
            return new VSAchievementsResponse(client.Execute(request));
        }


        private RestRequest RequestSetup(RestClient client, RestRequest request)
        {
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            client.AddHandler("application/json", new ApiJsonDeserializer());
            client.AddHandler("text/json", new ApiJsonDeserializer());
            client.AddHandler("text/x-json", new ApiJsonDeserializer());
            return request;
        }

        #endregion
    }
}
