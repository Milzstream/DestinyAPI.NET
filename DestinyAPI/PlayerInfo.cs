using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DestinyAPI
{
    public sealed class PlayerInfo
    {
        //Const Variables
        private readonly String _html_method = "GET";
        private readonly String _API_ACTION = "/{membershipType}/Account/{destinyMembershipId}/Summary/";

        //Variables
        private WebAPI api;

        /// <summary>
        ///     Init PlayerInfo Object
        /// </summary>
        /// <param name="api_key">The API Key supplied by Bungie</param>
        public PlayerInfo(String api_key)
        {
            api = new WebAPI(api_key);
        }

        public DestinyPlayer GetPlayerInfo(PLATFORM platform, String membershipId)
        {
            //Variables
            String url = CreateAPIURL(platform, membershipId);
            String json = String.Empty;
            JsonPlayerInfoObj jsonObj = null;

            //Get JSON
            json = api.ExecuteMethod(url, _html_method);

            //Deserialize
            jsonObj = new JavaScriptSerializer().Deserialize<JsonPlayerInfoObj>(json);

            return jsonObj.Response.data;
        }

        private String CreateAPIURL(PLATFORM platform, String membershipId)
        {
            //variables
            String url = _API_ACTION;

            url = url.Replace("{membershipType}", platform.ToString());
            url = url.Replace("{destinyMembershipId}", membershipId);

            return url;
        }

        private class JsonPlayerInfoObj : JsonObject
        {
            public JsonDestinyPlayerInfo Response { get; set; }
        }

        private class JsonDestinyPlayerInfo
        {
            public DestinyPlayer data { get; set; }
        }
    }
}
