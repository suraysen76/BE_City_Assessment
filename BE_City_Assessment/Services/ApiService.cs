using BE_City_Asessment.Interfaces;
using BE_City_Asessment.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace BE_City_Asessment.Services
{

    public class ApiService : IApiService
    {
        private readonly IConfiguration _config;

        public ApiService(IConfiguration config) {
            _config = config;
        }
        public async Task<List<ProductModel>> GetProducts()
        {
            
            List<ProductModel> productList = null;
            string primaryUrl = _config["ApiService:BaseURL"]+ "/products";
            


            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("api-key", _config["ApiService:API_Key"]);
                using (var response = await httpClient.GetAsync(primaryUrl))
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    productList = JsonConvert.DeserializeObject<List<ProductModel>>(jsonString);
                }
            }
            var sortedList = productList.OrderBy(p => p.Name).ToList();
            return sortedList;

        }

        
    }
}
