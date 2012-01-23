using Newtonsoft.Json;
using RestSharp;
using VSAchievements.Api.Constants;

namespace VSAchievements.Api.Objects
{
    public class VSAchievementsResponse
    {
        #region Fields

        public readonly Status Status;
        public readonly bool isOk;

        #endregion
        
        protected internal IRestResponse Response { get; private set; }

        #region Constructors

        internal VSAchievementsResponse(IRestResponse response)
        {
            Response = response;
            Status = (Status) response.StatusCode;
            isOk = Status == Status.Success;
        }

        #endregion
    }


    public class VSAchievementsResponse<T> : VSAchievementsResponse
    {
        #region Properties

        public T Data { get; protected internal set; }

        #endregion

        #region Constructors

        internal VSAchievementsResponse(IRestResponse<T> response) : base(response)
        {
            // There is a bug in RestSharp
            //UserStatsWrapper wrapper = restResponse.Data;
            if (Status == Status.Success)
                Data = JsonConvert.DeserializeObject<T>(response.Content);
        }

        protected internal VSAchievementsResponse(IRestResponse response) : base(response)
        {
        }

        #endregion
    }
}
