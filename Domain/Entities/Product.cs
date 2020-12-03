using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int precio { get; set; }
        public int Id_Categoria { get; set; }
        public string Estado { get; set; }

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
