using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Service
{
    public interface IProductService
    {
        void CrearProducto(Product producto);
        List<Product> BuscarProductos();
    }
}
