using Application.Product;
using Domain.Entities;
using Domain.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class ProductController : ApiController
    {
        IProductApplication productApplication = new ProductApplication();
        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            var producto = productApplication.BuscarProductos();
            return producto;
        }

        // POST api/values
        public void Post([FromBody] Product producto)
        {
            productApplication.CrearProducto(producto);
        }
    }
}