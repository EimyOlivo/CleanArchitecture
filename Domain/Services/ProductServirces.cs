using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ProductServirces : IProductService
    {
        IProductoRepository productRepository;

        public ProductServirces(IProductoRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public List<Product> BuscarProductos()
        {
            return productRepository.BuscarProductos();
        }

        public void CrearProducto(Product producto)
        {
            productRepository.CrearProducto(producto);
        }
    }
}
