using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    class ProductRepository : IProductoRepository
    {
        public List<int> buscarProductos()
        {
            throw new NotImplementedException();
        }

        public void crearProducto(int id, string nombre, int precio, int id_candidato, string estado)
        {
            throw new NotImplementedException();
        }
    }
}
