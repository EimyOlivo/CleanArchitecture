using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        void crearUser(int id, string nombre, string apellido, string direccion, string estado);
        List<int> buscarUser();
    }
}
