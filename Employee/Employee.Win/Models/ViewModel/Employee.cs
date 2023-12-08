using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win.Models.ViewModel
{
    public class EmployeeView
    {
        [DisplayName("Emp ID")]
        public int id { get; set; }
        [DisplayName("Emp Name")]
        public string name { get; set; }
        [DisplayName("Emp Email Address")]
        public string email { get; set; }
        [DisplayName("Emp Gender")]
        public string gender { get; set; }
        [DisplayName("Emp Status")]
        public string status { get; set; }
    }
}
