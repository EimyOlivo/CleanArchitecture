using Domain.Interfaces.Application;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Services;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Product
{
    public class ProductApplication : IProductApplication
    {
        IProductService productService;

        public ProductApplication()
        {
            this.productService = new ProductServirces(new ProductRepository());
        }
        public List<Domain.Entities.Product> BuscarProductos()
        {
            return productService.BuscarProductos();
        }

        public void CrearProducto(Domain.Entities.Product producto)
        {
            productService.CrearProducto(producto);
        }
    }
}
