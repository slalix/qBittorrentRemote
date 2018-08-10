using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;

namespace qbittorrentremote
{
    class WebWorker
    {
        static string Protocol = "https";
        static string WebUIURL = "example.com";
        static string Port = "8080";

        private static readonly HttpClient WebUIHttpClient = new HttpClient();
        public static string Auth(string username, string password)
        {
            CookieContainer WebUICookies = new CookieContainer();
            HttpClientHandler WebUIResponseHandler = new HttpClientHandler();
            WebUIResponseHandler.CookieContainer = WebUICookies;

            HttpClient WebUIAuthClient = new HttpClient(WebUIResponseHandler);

            Uri WebUIAuthURI = new Uri(GetWebUILink() + "/login");
            WebUIAuthClient.BaseAddress = WebUIAuthURI;

            Dictionary<string, string> PostData = new Dictionary<string, string>
                                                        {
                                                           { "username", username },
                                                           { "password", password }
                                                        };
            FormUrlEncodedContent WebUIAuthPostContent = new FormUrlEncodedContent(PostData);

            HttpResponseMessage WebUIAuthResponse = WebUIAuthClient.PostAsync("", WebUIAuthPostContent).Result;

            IEnumerable<Cookie> WebUIAuthResponseCookies = WebUICookies.GetCookies(WebUIAuthURI).Cast<Cookie>();
            Cookie WebUIAuthSIDCookie = WebUIAuthResponseCookies.ElementAt(0);

            return WebUIAuthSIDCookie.Value;
        }

        static List<string> CategoriesList = new List<string>();
        static List<string> SavePathsList = new List<string>();
        public static async Task<List<WebUITorrent>> GetTorrentListAsync(string SID, string StatusFilter, string CategoryFilter)
        {
            List<WebUITorrent> TorrentList = new List<WebUITorrent>();

            string JsonStringResponse = "";
            using (HttpClientHandler handler = new HttpClientHandler())
            using (HttpClient http = new HttpClient(handler))
            {
                handler.CookieContainer.Add(new Cookie("SID", SID, "/", WebUIURL));
                JsonStringResponse = await http.GetStringAsync(GetWebUILink() + "/query/torrents?filter=" + StatusFilter.ToLower() + "&sort=name"/* + "&category=" + CategoryFilter*/);
            }

            JArray JsonResponse = JArray.Parse(JsonStringResponse);

            foreach (JObject JsonTorrent in JsonResponse)
            {
                if (!CategoriesList.Contains(JsonTorrent["category"].ToString()))
                    CategoriesList.Add(JsonTorrent["category"].ToString());

                if (!SavePathsList.Contains(JsonTorrent["save_path"].ToString()))
                    SavePathsList.Add(JsonTorrent["save_path"].ToString());

                TorrentList.Add(new WebUITorrent(JsonTorrent["added_on"].ToString(),           JsonTorrent["amount_left"].ToString(),        JsonTorrent["auto_tmm"].ToString(),
                                                 JsonTorrent["category"].ToString(),           JsonTorrent["completed"].ToString(),          JsonTorrent["completion_on"].ToString(),
                                                 JsonTorrent["dl_limit"].ToString(),           JsonTorrent["dlspeed"].ToString(),            JsonTorrent["downloaded"].ToString(),
                                                 JsonTorrent["downloaded_session"].ToString(), JsonTorrent["eta"].ToString(),                JsonTorrent["f_l_piece_prio"].ToString(),
                                                 JsonTorrent["force_start"].ToString(),        JsonTorrent["hash"].ToString(),               JsonTorrent["last_activity"].ToString(),
                                                 JsonTorrent["magnet_uri"].ToString(),         JsonTorrent["max_ratio"].ToString(),          JsonTorrent["max_seeding_time"].ToString(),
                                                 JsonTorrent["name"].ToString(),               JsonTorrent["num_complete"].ToString(),       JsonTorrent["num_incomplete"].ToString(),
                                                 JsonTorrent["num_leechs"].ToString(),         JsonTorrent["num_seeds"].ToString(),          JsonTorrent["priority"].ToString(),
                                                 JsonTorrent["progress"].ToString(),           JsonTorrent["ratio"].ToString(),              JsonTorrent["ratio_limit"].ToString(),
                                                 JsonTorrent["save_path"].ToString(),          JsonTorrent["seeding_time_limit"].ToString(), JsonTorrent["seen_complete"].ToString(),
                                                 JsonTorrent["seq_dl"].ToString(),             JsonTorrent["size"].ToString(),               JsonTorrent["state"].ToString(),
                                                 JsonTorrent["super_seeding"].ToString(),      JsonTorrent["tags"].ToString(),               JsonTorrent["time_active"].ToString(),
                                                 JsonTorrent["total_size"].ToString(),         JsonTorrent["tracker"].ToString(),            JsonTorrent["up_limit"].ToString(),
                                                 JsonTorrent["uploaded"].ToString(),           JsonTorrent["uploaded_session"].ToString(),   JsonTorrent["upspeed"].ToString()));
            }

            return TorrentList;
        }

        public static List<string> GetCategories()
        {
            CategoriesList.Sort();
            return CategoriesList;
        }

        public static List<string> GetSavePaths()
        {
            SavePathsList.Sort();
            return SavePathsList;
        }

        public static async Task<string> GetqBitTorrentVersion()
        {
            string responseString = await WebUIHttpClient.GetStringAsync(GetWebUILink() + "/version/qbittorrent");
            return responseString;
        }

        private static string GetWebUILink()
        {
            return Protocol + "://" + WebUIURL + ":" + Port;
        }

        private static void AddTorrentToWebUI(string SavePath, string Category, string TorrentPath)
        {

        }
    }
}
