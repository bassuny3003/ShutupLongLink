﻿using System;
using System.IO;
using System.Net;

namespace ShutupLongLink
{
    public static class ShortURL
    {

        public static string AdflyURLShortner(string AdflyAPIKey, string UID, string AdType, string LongURL)
        {
            Uri requestUri = new Uri("http://api.adf.ly/api.php?key=" + AdflyAPIKey + "&uid=" + UID + "&advert_type=" + AdType + "&domain=adf.ly&url=" + LongURL.Trim());

            string ShortURL = new WebClient().DownloadString(requestUri);

            return ShortURL;
        }

        public static string R7URLShortner(string R7APIKey, string Alias, string LongURL)
        {
            Uri requestUri = new Uri("https://7r6.com/api?api=" + R7APIKey + "&url=" + LongURL + "&alias=" + Alias + "");

            string respondjoson = new WebClient().DownloadString(requestUri);

            respondjoson = respondjoson.Replace("{\"status\":\"", "");

            if (respondjoson.StartsWith("error"))
            {
                respondjoson = "Alias already exists.";
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

        public static string ShortestURLShortner(string ShortestAPIKey, string LongURL)
        {
            Uri myUri = new Uri("http://api.shorte.st/s/"+ ShortestAPIKey + "/" + LongURL);

            string respondjoson = new WebClient().DownloadString(myUri);

            respondjoson = respondjoson.Replace("\"", "");
            respondjoson = respondjoson.Replace("}", "");
            respondjoson = respondjoson.Replace("{status:ok,shortenedUrl:", "");
            //shrtBox.Text = shrtBox.Text.Replace("http:\\/\\/", "");
            respondjoson = respondjoson.Replace("\\/", "/");

            return respondjoson;
        }

        public static string TinyURLShortner(string LongURL)
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

    }
}