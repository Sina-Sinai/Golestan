using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolestanFramework.JsonFile
{
    public static class JsonFileUtils
    {
        private static readonly JsonSerializerSettings _options
            = new() { NullValueHandling = NullValueHandling.Ignore };

        public static void Write(object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, _options);
            if (File.Exists(fileName))
                File.WriteAllText(fileName, string.Empty);
            File.WriteAllText(fileName, jsonString);

        }

        public static T Read<T>(string fileName)
        {

            var result = File.ReadAllText(fileName, Encoding.UTF8);

            return JsonConvert.DeserializeObject<T>(result, _options);

        }
    }
}
