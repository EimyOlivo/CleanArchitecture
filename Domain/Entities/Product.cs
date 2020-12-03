using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Product
    {
        int Id;
        string Nombre;
        int precio;
        int Id_Categoria;
        string Estado;

        public Product(int id, string nombre, int precio, int id_categoria, string estado)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.precio = precio;
            this.Id_Categoria = id_categoria;
            this.Estado = estado;
        }
    }
}
