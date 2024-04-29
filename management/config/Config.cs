using management.api.response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.config
{
    class Config
    {
        //Lay du lieu tu api va tra ve response
        String uri = "https://doan.khanhnhat.top";

        public Config() { }
        public RestResponse callApiGet(String param, String value, String nameTable)
        {
            /*String route = "/api/staff.php/";*/

            String route = "/api/" + nameTable + ".php";

            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            if (!(param == ""))
            {
                request.AddQueryParameter(param, value);
            }

            return client.Execute(request);

            /*            switch (nameTable)
            {
                case "staff":
                    var staff = JsonConvert.DeserializeObject<StaffResponse>(response.Content);
                    return staff.staff;
                    break;
                case "career":
                    var career = JsonConvert.DeserializeObject<CareerResponse>(response.Content);
                    return career.career;
                    break;
                case "subjects":
                    var sub = JsonConvert.DeserializeObject<SubResponse>(response.Content);
                    return sub.subject;
                    break;
                default:
                    return "string";
                    break;
            }*/
        }
    }
}
