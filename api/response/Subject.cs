using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.response
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SubResponse
    {
        public List<Subject> subject { get; set; }
    }

    public class Subject
    {
        public string subID { get; set; }
        public string nameSub { get; set; }
    }


}
