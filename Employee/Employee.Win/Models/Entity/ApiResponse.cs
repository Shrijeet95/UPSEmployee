using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win.Models.Entity
{
    public class ApiResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string ErrorMessage { get; set; }
        public string Response  { get; set; }
    }
}
