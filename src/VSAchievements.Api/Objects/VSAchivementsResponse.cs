using RestSharp;
using VSAchievements.Api.Constants;

namespace VSAchievements.Api.Objects
{
    public interface IVSAchievementsResponse
    {
        bool IsOk { get; }
        Status Status { get; set; }
    }

    public interface IVSAchievementsResponse<T> : IVSAchievementsResponse
    {
        T Data { get; set; }
    }

    public abstract class VSAchievementsResponseBase
    {
        #region Properties (Stats)

        protected internal IRestResponse Response { get; set; }

        public bool IsOk { get { return Status == Status.Success; } }

        public Status Status { get; set; }

        #endregion

        protected internal VSAchievementsResponseBase(IRestResponse response)
        {
            Response = response;
            Status = (Status)response.StatusCode;
        }

        protected VSAchievementsResponseBase()
        {
        }
    }

    public class VSAchievementsResponse<T> : VSAchievementsResponseBase, IVSAchievementsResponse<T>
    {

        protected internal VSAchievementsResponse(IRestResponse<T> response)
            : base(response)
        {
            Data = response.Data;
        }

        protected internal VSAchievementsResponse(IRestResponse response)
            : base(response)
        {
        }


        public static implicit operator VSAchievementsResponse<T>(RestResponse response)
        {
            return new VSAchievementsResponse<T>(response);
        }

        public static implicit operator VSAchievementsResponse<T>(RestResponse<T> response)
        {
            return new VSAchievementsResponse<T>(response);
        }

        #region Properties

        public T Data { get; set; }

        #endregion

    }

    public class VSAchievementsResponse : VSAchievementsResponseBase, IVSAchievementsResponse
    {
        protected internal VSAchievementsResponse(RestResponse response)
            : base(response)
        {
        }

        public static implicit operator VSAchievementsResponse(RestResponse response)
        {
            return new VSAchievementsResponse(response);
        }
    }
}
