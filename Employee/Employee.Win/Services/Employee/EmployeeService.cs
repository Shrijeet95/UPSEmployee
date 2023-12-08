using AutoMapper;
using Employee.Win.Forms;
using Employee.Win.Models.Entity;
using Employee.Win.Models.ViewModel;
using Employee.Win.Services.Base;
using Employee.Win.Services.Employee.Interface;
using Employee.Win.Utility;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee.Win.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeConfig employeeConfig;
        private readonly IBaseService baseService;
        private readonly IMapper mapper;

        public EmployeeService(IOptions<EmployeeConfig> employeeConfig, IBaseService baseService, IMapper mapper)
        {
            this.employeeConfig = employeeConfig.Value;
            this.baseService = baseService;
            this.mapper = mapper;
        }
        public async Task<int> DelEmployee(int id)
        {
            string url = $"{employeeConfig.BaseUrl}{employeeConfig.DeleteEmployeeById}";
            var apiResponse = await baseService.ConsumeAPI(new ApiRequest
            {
                ApiType = ApiType.DELETE,
                Url = string.Format(url, id),
                Headers = employeeConfig.Headers
            });
            if (apiResponse.IsSuccess == true)
            {
                var response = JsonConvert.DeserializeObject<List<EmployeeEntity>>(apiResponse.Response);
                return 1;
            }
            else
            {
                throw new Exception(apiResponse.ErrorMessage);
            }
            return 0;
        }

        public async Task<List<EmployeeView>> GetEmployees()
        {
            var apiResponse = await baseService.ConsumeAPI(new ApiRequest
            {
                ApiType = ApiType.GET,
                Url = $"{employeeConfig.BaseUrl}{employeeConfig.AllEmployee}",
                Headers = employeeConfig.Headers
            });
            if (apiResponse.IsSuccess == true)
            {
                var response = JsonConvert.DeserializeObject<List<EmployeeEntity>>(apiResponse.Response);
                return mapper.Map<List<EmployeeView>>(response);
            }
            else
            {
                throw new Exception(apiResponse.ErrorMessage);
            }
            return null;
        }

        public async Task<List<EmployeeView>> GetEmployeesById(int id)
        {
            string url = $"{employeeConfig.BaseUrl}{employeeConfig.EmployeeById}";
            var apiResponse = await baseService.ConsumeAPI(new ApiRequest
            {
                ApiType = ApiType.GET,
                Url = string.Format(url,id.ToString()),
                Headers = employeeConfig.Headers
            });
            if (apiResponse.IsSuccess == true)
            {
                var response = JsonConvert.DeserializeObject<List<EmployeeEntity>>(apiResponse.Response);
                return mapper.Map<List<EmployeeView>>(response);
            }
            else
            {
                throw new Exception(apiResponse.ErrorMessage);
            }
            return null;
        }

        public async Task<List<EmployeeView>> GetEmployeesByName(string empoyeeName)
        {
            string url = $"{employeeConfig.BaseUrl}{employeeConfig.EmployeeByName}";
            var apiResponse = await baseService.ConsumeAPI(new ApiRequest
            {
                ApiType = ApiType.GET,
                Url = string.Format(url, empoyeeName),
                Headers = employeeConfig.Headers
            });
            if (apiResponse.IsSuccess == true)
            {
                var response = JsonConvert.DeserializeObject<List<EmployeeEntity>>(apiResponse.Response);
                return mapper.Map<List<EmployeeView>>(response);
            }
            else
            {
                throw new Exception(apiResponse.ErrorMessage);
            }
            return null;
        }

        public async Task<int> PutEmployee(EmployeeView employee)
        {
            var employeeEntity = mapper.Map<EmployeeEntity>(employee);
            string url = $"{employeeConfig.BaseUrl}{employeeConfig.PutEmployeeById}";
            var apiResponse = await baseService.ConsumeAPI(new ApiRequest
            {
                ApiType = ApiType.PUT,
                Url = string.Format(url,employee.id),
                Headers = employeeConfig.Headers,
                RequestBody = JsonConvert.SerializeObject(employeeEntity)
            });
            if (apiResponse.IsSuccess == true)
            {
                return 1;
            }
            else
            {
                throw new Exception(apiResponse.ErrorMessage);
            }
            return 0;

        }

        public async Task<int> SetEmployee(EmployeeView employee)
        {
            var employeeEntity = mapper.Map<EmployeeEntity>(employee);
            string url = $"{employeeConfig.BaseUrl}{employeeConfig.SetEmployee}";
            var apiResponse = await baseService.ConsumeAPI(new ApiRequest
            {
                ApiType = ApiType.POST,
                Url = url,
                Headers = employeeConfig.Headers,
                RequestBody = JsonConvert.SerializeObject(employeeEntity)
            });
            if (apiResponse.IsSuccess == true)
            {
                return 1;
            }
            else
            {
                throw new Exception(apiResponse.ErrorMessage);
            }
            return 0;
        }
    }
}
