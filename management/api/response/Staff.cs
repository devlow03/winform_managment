using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.response
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class StaffResponse
    {
        public List<Staff> staff { get; set; }
    }

    public class Staff
    {
        public string id { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string position { get; set; }
        public string subID { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string salary { get; set; }
        public string hidden { get; set; }
        public string nameSub { get; set; }
    }


}
