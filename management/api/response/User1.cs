using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.response
{
    public class User1Response
    {
        public List<User1> user { get; set; }
    }

    public class User1
    {
        public string userID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string img_url { get; set; }
    }
}
