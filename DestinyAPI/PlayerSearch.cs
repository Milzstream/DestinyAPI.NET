using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DestinyAPI
{
    public sealed class PlayerSearch
    {
        //Const Variables
        private readonly String _html_method = "GET";
        private readonly String _API_ACTION = "/SearchDestinyPlayer/{membershipType}/{displayName}/";

        //Variables
        private WebAPI api;

        /// <summary>
        ///     Init PlayerSearch Object
        /// </summary>
        /// <param name="api_key">The API Key supplied by Bungie</param>
        public PlayerSearch(String api_key)
        {
            api = new WebAPI(api_key);
        }

        public List<DestinyPlayer> FindPlayers(PLATFORM platform, String name)
        {
            //Variables
            String url = CreateAPIURL(platform, name);
            String json = String.Empty;
            JsonPlayerSearchObj jsonObj = null;

            //Get JSON
            json = api.ExecuteMethod(url, _html_method);

            //Deserialize
             jsonObj = new JavaScriptSerializer().Deserialize<JsonPlayerSearchObj>(json);

            return jsonObj.Response.ToList();
        }

        private String CreateAPIURL(PLATFORM platform, String name)
        {
            //variables
            String url = _API_ACTION;

            url = url.Replace("{membershipType}", platform.ToString());
            url = url.Replace("{displayName}", name);

            return url;
        }

        private class JsonPlayerSearchObj : JsonObject
        {
            public DestinyPlayer[] Response { get; set; }
        }
    }
}
