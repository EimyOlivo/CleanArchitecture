using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        void crearUser(User user);
        List<User> buscarUser();
    }
}
