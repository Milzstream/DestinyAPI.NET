using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HtmlScrap
{
    public class HtmlScrape
    {
        //Variables
        private WebClient client;

        public HtmlScrape(String baseUrl)
        {
            client = new GZipWebClient();
            client.BaseAddress = baseUrl;
        }

        /// <summary>
        ///     Adds headers to the request
        /// </summary>
        /// <param name="type">This is the name of the header</param>
        /// <param name="value">This is the value of the header</param>
        public void AddHeader(HttpRequestHeader name, String value)
        {
            client.Headers.Add(name, value);
        }

        /// <summary>
        ///     Adds headers to the request
        /// </summary>
        /// <param name="type">This is the name of the header</param>
        /// <param name="value">This is the value of the header</param>
        public void AddHeader(HttpResponseHeader name, String value)
        {
            client.Headers.Add(name, value);
        }

        /// <summary>
        ///     Adds headers to the request that are uncommon
        /// </summary>
        /// <param name="name">This is the name of the header</param>
        /// <param name="value">this is the value of the header</param>
        public void AddHeader(String name, String value)
        {
            client.Headers.Add(name, value);
        }

        /// <summary>
        ///     Adds to the query String
        /// </summary>
        /// <param name="name">param name</param>
        /// <param name="value">param value</param>
        public void AddQueryString(String name, String value)
        {
            client.QueryString.Add(name, value);
        }

        public String DownloadHtml(String FullUrl)
        {
            try
            {
                //download
                client.Proxy.Credentials = (System.Net.NetworkCredential)System.Net.CredentialCache.DefaultCredentials;
                //Byte[] data = client.DownloadData(FullUrl);
                Byte[] data = client.UploadData(FullUrl, "POST", new Byte[] { });
                return Encoding.UTF8.GetString(data);
                //return client.DownloadString(FullUrl);
            } catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
