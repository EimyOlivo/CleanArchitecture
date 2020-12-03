using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Category
    {
        int Id { get; set; }
        string Categoria { get; set; }
        string Estado { get; set; }

        public Category() { 
        }

        public Category(int Id, string categoria,string estado)
        {
            this.Id = Id;
            this.Categoria = categoria;
            this.Estado = estado;
        }
    }
}
