using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    class UserRepository : IUserRepository
    {
        public List<int> buscarUser()
        {
            throw new NotImplementedException();
        }

        public void crearUser(int id, string nombre, string apellido, string direccion, string estado)
        {
            throw new NotImplementedException();
        }
    }
}
