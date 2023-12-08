using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win.Utility
{
    public class EmployeeConfig
    {
        public string BaseUrl { get; set; }
        public string AllEmployee { get; set; }
        public string EmployeeByName { get; set; }
        public string EmployeeById { get; set; }
        public string PutEmployeeById { get; set; }
        public string DeleteEmployeeById { get; set; }
        public string SetEmployee { get; set; }
        public Dictionary<string,string> Headers { get; set; }
    }
}
