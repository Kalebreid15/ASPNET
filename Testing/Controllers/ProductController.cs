using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;
using Testing; // Make sure this includes IProductRepository and related models

namespace Testing.Controllers
{
    public class ProductController(IProductRepository repo) : Controller
    {
        private readonly IProductRepository repo = repo;


        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProductById(id);

            return View(product);
        }
    }
}