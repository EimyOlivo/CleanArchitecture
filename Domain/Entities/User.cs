using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class User
    {
        int Id;
        string Nombre;
        string Apellido;
        string Direccion;
        string Estado;

        public User(int id,string nombre,string apellido, string direccion, string estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Estado = estado;
        }

    }
}
