using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Service
{
    public interface IUserService
    {
        void crearUser(User user);
        List<User> buscarUser();
    }
}
