using Domain.Interfaces.Application;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Services;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.User
{
    public class UserApplication : IUserApplication
    {
        IUserService userService;

        public UserApplication()
        {
            this.userService = new UserServices(new UserRepository());
        }

        public List<Domain.Entities.User> buscarUser()
        {
            return userService.buscarUser();
        }

        public void crearUser(Domain.Entities.User user)
        {
            userService.crearUser(user);
        }
    }
}
