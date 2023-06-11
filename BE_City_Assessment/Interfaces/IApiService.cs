using BE_City_Asessment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BE_City_Asessment.Interfaces
{
    public interface IApiService
    {
        Task<List<ProductModel>> GetProducts();
    }
}
