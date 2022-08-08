using Newtonsoft.Json;

namespace TestProject1.Models
{
    public  class DataContain
    {
        [JsonProperty("mainpage")]
        public static string Mainpage { get; set; }

        [JsonProperty("gmail")]
        public static string Gmail { get; set; }

        [JsonProperty("password")]
        public static string Password { get; set; }
    }
}
