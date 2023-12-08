using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win.Models.Entity
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string RequestBody { get; set;}
        public string Url { get; set; }
        public Dictionary<string, string> Headers { get; set; }

    }
}
