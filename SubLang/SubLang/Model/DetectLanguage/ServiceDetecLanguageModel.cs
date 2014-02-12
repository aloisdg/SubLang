using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubLang.Model.DetectLanguage;

namespace SubLang.Model.DetectLanguage
{
    public static class ServiceDetecLanguageModel
    {
        private const string key = "###";
        private const string api = "http://ws.detectlanguage.com/0.2/detect";

        public static string langs { get; set; }

        //?q[]=bonjour+tout+le+monde&key=788dafca4265255c8b081c64d57b9e11;

        public static DetectLanguageModel.Result DetectSimple(this string text)
        {
            string[] texts = new string[] { text };
            return texts.Detect();
        }

        public static DetectLanguageModel.Result Detect(this string[] texts)
        {
            var res = new DetectLanguageModel.Result();
            if (texts.Length > 0)
            {
                string args = "?";
                for (int i = 0; i < texts.Length; i++)
                    if (!String.IsNullOrWhiteSpace(texts[i]))
                        args += "q[]=" + System.Net.WebUtility.UrlEncode(texts[i]) + "&";
                CallAPI(args);
            }
            return res;
        }

        private static async void CallAPI(string args)
        {
            Uri url = new Uri(api + args + "key=" + key, UriKind.Absolute);
            string json = await Helper.HttpHelper.GetString(url);
            langs = json;
            System.Diagnostics.Debug.WriteLine(langs);
        }

        //private static DetectLanguageModel.Result Get(string text)
        //{
        //}
    }
}
