using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Entities
{

    public class Category
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Estado { get; set; }

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
