using Application.User;
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
    public class UserController : ApiController
    {
        IUserApplication userApplication = new UserApplication();
        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            var user = userApplication.buscarUser();
            return user;
        }

        // POST api/values
        public void Post([FromBody] User user)
        {
            userApplication.crearUser(user);
        }
    }
}