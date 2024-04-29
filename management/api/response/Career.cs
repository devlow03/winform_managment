using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.response
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Career
    {
        public string code { get; set; }
        public string nameCareer { get; set; }
        public string subID { get; set; }
    }

    public class CareerResponse
    {
        public List<Career> career { get; set; }
    }


}
