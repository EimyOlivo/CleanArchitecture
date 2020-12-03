using Application.Categories;
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
   
    public class CategoryController : ApiController
    {
        ICategoryApplication categoryApplication = new CategoryApplication();
        // GET api/<controller>
        public IEnumerable<Category> Get()
        {
            var categorias = categoryApplication.buscarCategoria();
            return categorias;
        }

        // POST api/values
        public void Post([FromBody] Category categoria)
        {
            categoryApplication.crearCategoria(categoria);
        }
    }
}