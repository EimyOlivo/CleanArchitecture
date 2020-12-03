using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

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
