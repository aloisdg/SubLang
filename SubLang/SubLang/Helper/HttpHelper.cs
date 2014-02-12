using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SubLang.Helper
{
    public static class HttpHelper
    {
        public static async Task<string> GetString(Uri url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public static async Task<string> PostString(Uri url, string data)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.PostAsync(url, new StringContent(data));
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
