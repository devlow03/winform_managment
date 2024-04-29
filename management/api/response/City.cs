using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.api.response
{
    public class City
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CityResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public List<District> results { get; set; }
    }
}
