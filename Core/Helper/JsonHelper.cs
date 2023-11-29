using System.Text.Json;

namespace RayihaRestaurant.Core.Helper
{
    public static class JsonHelper
    {
        public static string SerializeObject<T>(T obj) => JsonSerializer.Serialize(obj);

        public static T? DeserializeObject<T>(string json) => JsonSerializer.Deserialize<T>(json);
    }

}
