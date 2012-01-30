using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

namespace VSAchievements.Api.Objects.JsonUtilities
{
    public class ApiJsonDeserializer : IDeserializer
    {
        public T Deserialize<T>(RestResponse response) where T : new()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.DeserializeObject<T>(response.Content, settings);
        }

        public string RootElement { get; set; }

        public string Namespace { get; set; }

        public string DateFormat { get; set; }
    }
}

