using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubLang.Helper
{
    public static class JSonHelper
    {
        public static string Serialize<T>(T value)
        {
            string rawValue = Newtonsoft.Json.JsonConvert.SerializeObject(value);
            return rawValue;
        }

        public static T Deserialize<T>(string rawValue)
        {
            T value = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(rawValue);
            return value;
        }
    }
}
