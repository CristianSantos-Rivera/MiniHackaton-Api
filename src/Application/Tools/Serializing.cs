using Newtonsoft.Json;

namespace Evner.Application.Tools
{
    public static class Serializing
    {
        public static T Mapper<T>(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
