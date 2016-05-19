using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DestinyAPI
{
    internal class WebAPI
    {
        //Public Sealed Variables
        public readonly String API_URL = "http://www.bungie.net/Platform/Destiny";
        private String _api_key;

        internal WebAPI(String api_key)
        {
            _api_key = api_key;
        }

        /// <summary>
        ///     Returns a JSON String (May need to be formatted for Object
        /// </summary>
        /// <param name="api_method">This is the API Method call</param>
        /// <param name="html_action">GET/POST</param>
        /// <returns></returns>
        public String ExecuteMethod(String api_method, String html_action)
        {
            //Variables
            String jsonReturn = String.Empty;

            WebRequest request = WebRequest.Create(API_URL + api_method);
            request.Method = html_action;
            request.Headers.Add("X-API-Key", _api_key);
            request.Headers.Add("Cookie", "bungledid=B6BGVMQFOKdJsTAWEnsW/ko5xn4glmfRCAAA; bungled=2796665744958383183");
            request.ContentType = "application/json";
            request.Proxy.Credentials = (System.Net.NetworkCredential)System.Net.CredentialCache.DefaultCredentials;
            request.ContentLength = 0;

            try
            {
                using (WebResponse res = request.GetResponse())
                using (Stream resSteam = res.GetResponseStream())
                using (StreamReader sr = new StreamReader(resSteam))
                    jsonReturn = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                jsonReturn = ex.Message;
            }

            return jsonReturn;
        }

    }
}
