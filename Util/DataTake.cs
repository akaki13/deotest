using Newtonsoft.Json;
using System;
using System.IO;
using TestProject1.Models;

namespace TestProject1.Util
{
    public static class DataTake
    {
        private static string path = @"Resources\data.json";
        public static void TakeConfigData()
        {
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            using (StreamReader r = new StreamReader(filepath))
            {
                string json = r.ReadToEnd();
                DataContain datacontain = JsonConvert.DeserializeObject<DataContain>(json);
            }
        }
    }
}
