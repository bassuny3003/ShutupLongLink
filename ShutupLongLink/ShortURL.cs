using BitlyAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShutupLongLink
{
    public static class ShortURL
    {
        #region Adfly URL Shortener

        public static string AdflyURLShortener(string AdflyAPIKey, string UID, string AdType, string LongURL)
        {
            Uri requestUri = new Uri("http://api.adf.ly/api.php?key=" + AdflyAPIKey + "&uid=" + UID + "&advert_type=" + AdType + "&domain=adf.ly&url=" + LongURL.Trim());

            string ShortURL = new WebClient().DownloadString(requestUri);

            return ShortURL;
        }

        #endregion

        #region R7URL Shortener

        public static string R7URLShortener(string R7APIKey, string Alias, string LongURL)
        {
            Uri requestUri = new Uri("https://7r6.com/api?api=" + R7APIKey + "&url=" + LongURL + "&alias=" + Alias + "");

            string respondjoson = new WebClient().DownloadString(requestUri);

            respondjoson = respondjoson.Replace("{\"status\":\"", "");

            if (respondjoson.StartsWith("error"))
            {
                respondjoson = respondjoson.Replace("error\",\"message\":[\"", "");

                if (respondjoson.StartsWith("URL is invalid."))
                {
                    respondjoson = "URL is invalid.";
                }
                else if (respondjoson.StartsWith("Alias already exists."))
                {
                    respondjoson = "Alias already exists.";

                }
                else if (respondjoson.StartsWith("This domain is not allowed on our system."))
                {
                    respondjoson = "This domain is not allowed on R7URL system.";
                }
            }
            else
            {
                respondjoson = respondjoson.Replace("success\",", "");
                respondjoson = respondjoson.Replace("\"message\":\"\",", "");
                respondjoson = respondjoson.Replace("\"shortenedUrl\":\"", "");
                respondjoson = respondjoson.Replace("\\", "");
                respondjoson = respondjoson.Replace("\"}", "");
            }

            return respondjoson;
        }

        #endregion

        #region Shortest URL Shortener

        public static string ShortestURLShortener(string ShortestAPIKey, string LongURL)
        {
            Uri myUri = new Uri("http://api.shorte.st/s/" + ShortestAPIKey + "/" + LongURL);

            string respondjoson = new WebClient().DownloadString(myUri);

            respondjoson = respondjoson.Replace("\"", "");
            respondjoson = respondjoson.Replace("}", "");
            respondjoson = respondjoson.Replace("{status:ok,shortenedUrl:", "");
            //shrtBox.Text = shrtBox.Text.Replace("http:\\/\\/", "");
            respondjoson = respondjoson.Replace("\\/", "/");

            return respondjoson;
        }

        #endregion

        #region TinyURL Shortener

        public static string TinyURLShortener(string LongURL)
        {
            string myShortURL;

            string myLongURL = "http://tinyurl.com/api-create.php?url=" + LongURL.ToLower();

            var request = (HttpWebRequest)WebRequest.Create(myLongURL);
            request.Method = "Get";
            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream());

            myShortURL = reader.ReadToEnd();


            return myShortURL;
        }

        public static async Task<string> TinyURLShortenerAsync(string TinyURLAPIKey, string LongURL)
        {
            var url = "https://api.tinyurl.com/create?api_token=" + TinyURLAPIKey;

            HttpClient client = new HttpClient();

            var BaseBodyData = new Dictionary<string, string>
            {
                { "url", LongURL },
                { "domain", "tiny.one" },
                { "alias", "mohamed5a111aa"}

            };

            StringContent body = new StringContent(JsonConvert.SerializeObject(BaseBodyData), UnicodeEncoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync(url, body);

            var link = JsonConvert.DeserializeObject<dynamic>(await responseMessage.Content.ReadAsStringAsync());

            try
            {
                return link.data.tiny_url;
            }
            catch (Exception)
            {
                string respons = await responseMessage.Content.ReadAsStringAsync();

                respons = respons.Replace("{\"data\":[],\"code\":5,", "");
                respons = respons.Replace("\"errors\":[\"", "");
                respons = respons.Replace("\"]}", "");

                return respons;
            }
        }

        #endregion

        #region Rebrandly Shortener

            public static async Task<string> RebrandlyShortenerAsync(string RebrandlyAPIKey, string LongURL)
        {
            string ShortURL;

            var payload = new
            {
                destination = LongURL,
                domain = new
                {
                    fullName = "rebrand.ly",
                }
                //, slashtag = "A_NEW_SLASHTAG"
                //, title = "Rebrandly YouTube channel"
            };

            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api.rebrandly.com") })
            {
                httpClient.DefaultRequestHeaders.Add("apikey", RebrandlyAPIKey);
                //httpClient.DefaultRequestHeaders.Add("workspace", "YOUR_WORKSPACE_ID");

                var body = new StringContent(JsonConvert.SerializeObject(payload), UnicodeEncoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("/v1/links", body))
                {
                    response.EnsureSuccessStatusCode();

                    var link = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());

                    //Console.WriteLine($"Long URL was {payload.destination}, short URL is {link.shortUrl}");

                    ShortURL =  "https://" + link.shortUrl;
                }
            }

            return ShortURL;
        }

        #endregion

        #region bitly Shortener

        public static async Task<string> bitlyShortenerAsync(string bitlyAPIKey, string LongURL)
        {
            var bitly = new Bitly(bitlyAPIKey);
            var linkResponse = await bitly.PostShorten(LongURL);
            var ShortURL = linkResponse.Link;

            return ShortURL;
        }

        #endregion

        #region Picsee.io Shortener

        public static async Task<string> PicseeShortenerAsync(string PicseeAPIKey, string LongURL)
        {
            var url = "https://api.pics.ee/v1/links/?access_token=" + PicseeAPIKey;

            HttpClient client = new HttpClient();

            var BaseBodyData = new Dictionary<string, string>
            {
                {"url", LongURL},
                {"externalId","customer_test_1" }
            };

            StringContent body = new StringContent(JsonConvert.SerializeObject(BaseBodyData), UnicodeEncoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync(url, body);

            var link = JsonConvert.DeserializeObject<dynamic>(await responseMessage.Content.ReadAsStringAsync());


            return link.data.picseeUrl;
        }

        #endregion

        #region BL.ink Shortener

        public static string Email { get; set; }

        public static string Password { get; set; }

        public static string RefreshToken { get; set; }

        public static string Authorization { get; private set; }

        public static string DomainID { get; set; }


        public static async Task<string> GetAuthorizationByRefreshTokenAsync()
        {
            var url = "https://app.bl.ink/api/v4/access_token";

            HttpClient client = new HttpClient();

            var BaseBodyData = new Dictionary<string, string>
            {
                {"email", Email},
                {"refresh_token", RefreshToken}

            };

            StringContent body = new StringContent(JsonConvert.SerializeObject(BaseBodyData), UnicodeEncoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync(url, body);

            var link = JsonConvert.DeserializeObject<dynamic>(await responseMessage.Content.ReadAsStringAsync());


            return Authorization = "Bearer " + Convert.ToString(link.access_token);
        }

        public static async Task<string> GetAuthorizationByPassword()
        {
            var url = "https://app.bl.ink/api/v4/access_token";

            HttpClient client = new HttpClient();

            var BaseBodyData = new Dictionary<string, string>
            {
                {"email", Email},
                {"refresh_token", Password}

            };

            StringContent body = new StringContent(JsonConvert.SerializeObject(BaseBodyData), UnicodeEncoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync(url, body);

            var link = JsonConvert.DeserializeObject<dynamic>(await responseMessage.Content.ReadAsStringAsync());


            return Authorization = "Bearer " + Convert.ToString(link.access_token);
        }

        public static async Task<string> GetListDomainID()
        {
            var url = "https://app.bl.ink/api/v4/domains";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", Authorization);

            var responseMessage = await client.GetAsync(url);

            var link = JsonConvert.DeserializeObject<dynamic>(await responseMessage.Content.ReadAsStringAsync());


            return DomainID = Convert.ToString(link["objects"][0]["id"]);
        }

        public static async Task<string> BLinkShortenerAsync(string LongURL)
        {
            var url = "https://app.bl.ink/api/v4/" + DomainID + "/links";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", Authorization);


            var BaseBodyData = new Dictionary<string, string>
            {
                {"url", LongURL}
            };

            StringContent body = new StringContent(JsonConvert.SerializeObject(BaseBodyData), UnicodeEncoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync(url, body);

            var link = JsonConvert.DeserializeObject<dynamic>(await responseMessage.Content.ReadAsStringAsync());


            return link["objects"][0]["short_link"];
        }

        #endregion

    }
}
