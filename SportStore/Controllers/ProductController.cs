using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository prop)
        {
            repository = prop;
        }

        public ViewResult List() => View(repository.Products);
    }
}