using ASPNetProdAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ASPNetProdAPI.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
      {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hamburger", Category = "Groceries", Price = 2.99M },
            new Product { Id = 4, Name = "Manwich", Category = "Groceries", Price = 1.99M },
            new Product { Id = 5, Name = "Tuna", Category = "Groceries", Price = .79M }
      };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
