using AutoMapper;
using Employee.Win.Models.Entity;
using Employee.Win.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeEntity, EmployeeView>().ReverseMap();
        }
    }
}
