using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class UserServices : IUserService
    {
        IUserRepository userRepository;

        public UserServices(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> buscarUser()
        {
            return userRepository.buscarUser();
        }

        public void crearUser(User user)
        {
            userRepository.crearUser(user);
        }
    }
}
