using management.api.response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.request
{
    class RestApi
    {
        String uri = "https://doan.khanhnhat.xyz";
        void getStaff(String subID)
        {
            String route = "/api/staff.php/";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            request.AddQueryParameter("subID", subID);
            RestResponse response = client.Execute(request);
            var staff = JsonConvert.DeserializeObject<StaffResponse>(response.Content);

        }
        void getCareer()
        {
            String route = "/api/career.php";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            RestResponse response = client.Execute(request);
            var career = JsonConvert.DeserializeObject<CareerResponse>(response.Content);
        }
        void getSub()
        {
            String route = "/api/subjects.php";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            RestResponse response = client.Execute(request);
            var sub = JsonConvert.DeserializeObject<SubResponse>(response.Content);
        }

        //add data

        void addStaff(String name,String year, String posititon, String subID, String city, String district, String salary)
        {
            String route = "/api/add_staff.php";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Post);
            request.AddBody(new
            {
                name = name,
                year = year,
                posititon = posititon,
                subID = subID,
                city = city,
                district = district,
                salary = salary
            });
            RestResponse response = client.Execute(request);
            
        }
        void removeStaff(String id)
        {
            
            String route = "/api/remove_staff.php";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Get);
            request.AddQueryParameter("id", id);
            RestResponse response = client.Execute(request);
        }
        void updateStaff(String id,String name, String year, String posititon, String subID, String city, String district, String salary)
        {
            String route = "/api/update_staff.php";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Post);
            request.AddBody(new
            {
                id = id,
                name = name,
                year = year,
                posititon = posititon,
                subID = subID,
                city = city,
                district = district,
                salary = salary
            });
            RestResponse response = client.Execute(request);

        }
        void updateAccount(String userID, String username, String password)
        {
            String route = "/api/update_account.php";
            var client = new RestClient(uri);
            var request = new RestRequest(route, Method.Post);
            request.AddBody(new
            {
                userID = userID,
                username = username,
                password = password,
               
            });
            RestResponse response = client.Execute(request);
        }
    }
}
