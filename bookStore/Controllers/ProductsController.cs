using bookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookStore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(ProductModel product)
        {
            var viewModel = new ProductsStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,


            };
        }
    }
}
