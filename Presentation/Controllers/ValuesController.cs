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
    public class ValuesController : ApiController
    {
        ICategoryApplication categoryApplication = new CategoryApplication();

        // GET api/values
        public IEnumerable<Category> Get()
        {
            var categorias = categoryApplication.buscarCategoria();
            return categorias;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
