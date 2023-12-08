using Employee.Win.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Win.Services.Base
{
    public interface IBaseService
    {
        Task<ApiResponse> ConsumeAPI(ApiRequest apiRequest);
    }
}
