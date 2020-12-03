using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface IProductoRepository
    {
        void crearProducto(int id, string nombre, int precio, int id_candidato, string estado);
        List<int> buscarProductos();
    }
}
