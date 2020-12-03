using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Application
{
    public interface IProductApplication
    {
        void CrearProducto(Product producto);
        List<Product> BuscarProductos();
    }
}
