using BE_City_Asessment.Interfaces;
using BE_City_Asessment.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_City_Assessment.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IApiService _service;
        public ProductsController(IApiService service)
        {
            _service = service;
        }

        public async Task<IActionResult> GetProducts()
        {
            List<ProductModel> model = await _service.GetProducts();
            return View(model);
        }
        public async Task<string> GetProductsInJson()
        {
            List<ProductModel> model = await _service.GetProducts();
            var jsonString = JsonConvert.SerializeObject(model);


            return jsonString;
        }
    }
}
