using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Employee.Win.Models.Entity;
using Newtonsoft.Json;
namespace Employee.Win.Services.Base
{
    internal class BaseService : IBaseService
    {
        private ApiResponse ApiResponse;

        private HttpClient httpClient;



        public async Task<ApiResponse> ConsumeAPI(ApiRequest apiRequest)
        {
            httpClient = new HttpClient();
            try
            {
                var httpRequestMessage = new HttpRequestMessage();

                //url
                httpRequestMessage.RequestUri = new Uri(apiRequest.Url);

                //request
                if (!string.IsNullOrEmpty(apiRequest.RequestBody))
                {
                    httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.RequestBody), encoding: Encoding.UTF8);
                }
                //add header
                if (apiRequest.Headers != null && apiRequest.Headers.Count > 0)
                {
                    foreach (var item in apiRequest.Headers)
                    {
                        httpRequestMessage.Headers.Add(item.Key, item.Value);
                    }
                }

                //httpVerb
                switch (apiRequest.ApiType)
                {
                    case ApiType.POST:
                        httpRequestMessage.Method = HttpMethod.Post;
                        break;
                    case ApiType.PUT:
                        httpRequestMessage.Method = HttpMethod.Put;
                        break;
                    case ApiType.DELETE:
                        httpRequestMessage.Method = HttpMethod.Delete;
                        break;
                    default:
                        httpRequestMessage.Method = HttpMethod.Get;
                        break;
                }


                var httpResponse = httpClient.Send(httpRequestMessage);
                if (httpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ApiResponse = new ApiResponse
                    {
                        IsSuccess = true,
                        Response = await httpResponse.Content.ReadAsStringAsync()
                    };
                }
                else
                {
                    ApiResponse = new ApiResponse
                    {
                        IsSuccess = false,
                        ErrorMessage=httpResponse.Content.ReadAsStringAsync().Result
                    };
                }
            }
            catch (Exception ex)
            {

                ApiResponse = new ApiResponse
                {
                    IsSuccess = false,
                    ErrorMessage = ex.Message
                };
            }
            return ApiResponse;
        }
    }
}
