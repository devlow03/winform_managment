using management.api.response;
using management.config;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace management.api.request
{
    class RestApi
    {
        public List<Staff> getStaff(String subID)
        {
            Config config = new Config();
            String nameTable = "staff";
            RestResponse response = config.callApiGet("subID", subID, nameTable);
            var staff = JsonConvert.DeserializeObject<StaffResponse>(response.Content);
            return staff.staff;
        }
        public List<Career> getCareer()
        {
            Config config = new Config();
            String nameTable = "career";
            RestResponse response = config.callApiGet("", "", nameTable);
            var career = JsonConvert.DeserializeObject<CareerResponse>(response.Content);
            return career.career;
        }

       

        public object getSub()
        {
            Config config = new Config();
            String nameTable = "subjects";
            RestResponse response = config.callApiGet("", "", nameTable);
            var sub = JsonConvert.DeserializeObject<SubResponse>(response.Content);
            return sub.subject;
        }
        public List<User1> getUser(string userID)
        {
            Config config = new Config();
            String nameTable = "user";
            RestResponse response = config.callApiGet("userID", userID, nameTable);
            var user = JsonConvert.DeserializeObject<User1Response>(response.Content);
            return user.user;
        }

        //add data
      
        String uri = "https://doan.khanhnhat.top";
        public object removeStaff(String id)
        {
            String route = "/api/remove_staff.php";
            var client = new RestClient(uri);
           
                var request = new RestRequest(route, Method.Get);
                request.AddQueryParameter("id", id);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string text = "Xóa nhân sự thành công";
                    return text;
                }
                else
                {
                    string text = "Xóa nhân sự thất bại";
                    return text;
                }
            
          


            //Trả về chuỗi "Đã xóa" trong Config
        }
        public object addStaff(String name,String year, String posititon, String subID, String city, String district, String salary)
        {
            String route = "/api/add_staff.php";
            var client = new RestClient(uri);
            var body = new

            {
                name = name,
                year = year,
                position = posititon,
                subID = subID,
                city = city,
                district = district,
                salary = salary
            };
            if(name!=""&&year!="" && salary != "")
            {
                var request = new RestRequest(route, Method.Post);
                request.AddObject(body);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string text = "Thêm nhân sự thành công";
                    return text;
                }
                else
                {
                    string text = "Thêm nhân sự thất bại";
                    return text;
                }
            }
            else
            {
                string text = "Các trường không được để trống";
                return text;
            }
            
            
        }
       
        public object updateStaff(String id,String name, String year, String position, String subID, String city, String district, String salary)
        {
            String route = "/api/update_staff.php";
            var client = new RestClient(uri);
            var body = new

            {
                id = id,
                name = name,
                year = year,
                position = position,
                subID = subID,
                city = city,
                district = district,
                salary = salary
            };
            if (name != "" && year != "" && salary != "")
            {
                var request = new RestRequest(route, Method.Post);
                request.AddObject(body);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string text = "Cập nhật nhân sự thành công";
                    return text;
                }
                else
                {
                    string text = "Cập nhật thất bại";
                    return text;
                }
            }
            else
            {
                string text ="Các trường không được để trống";
                return text;
            }


        }
        
        public object updateAccount(String userID, String name, String username, String password)
        {
            String route = "/api/update_account.php";
            var client = new RestClient(uri);
            var body = new
            {
                userID = userID,
                name = name,
                username = username,
                password = password,
            };
            if (name != "" && username != "" && password != "")
            {
                var request = new RestRequest(route, Method.Post);
                request.AddObject(body);
                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    frmDashboard dsb = new frmDashboard();
                    dsb.Refresh();
                    string text = "Cập nhật tài khoản thành công, hệ thống sẽ khởi động lại";
                   
                    return text;
                }
                else
                {
                    string text = "Cập nhật tài khoản thất bại";
                    return text;
                }
            }
            else
            {
                string text = "Các trường không được để trống";
                return text;
            }


        }

    }
}
