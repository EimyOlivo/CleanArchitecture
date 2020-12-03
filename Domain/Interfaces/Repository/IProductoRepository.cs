using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IProductoRepository
    {
        void CrearProducto(Product producto);
        List<Product> BuscarProductos();
    }
}
