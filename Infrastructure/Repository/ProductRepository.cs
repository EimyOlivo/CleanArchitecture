using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Domain.Interfaces.Repository;
using Infrastructure.Repository.Commons;
using Domain.Entities;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductoRepository
    {
        ConnectionDB conexion;

        public ProductRepository()
        {
            conexion = new ConnectionDB();

        }

        public List<Product> BuscarProductos()
        {
            var con = conexion.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id, Nombre, Precio, Id_Categoria, Estado from Product", con);
            var resultado = cmd.ExecuteReader();
            List<Product> producto = new List<Product>();
            while (resultado.Read())
            {
                producto.Add(new Product((int)resultado["Id"], resultado["Nombre"].ToString(), (int)resultado["Precio"], (int)resultado["Id_Categoria"], resultado["Estado"].ToString()));
            }
            con.Close();

            return producto;
        }

        public void CrearProducto(Product producto)
        {
            var con = conexion.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Product values ('" + producto.Id + "', '" + producto.Nombre + "', '" + producto.precio + "', '"+producto.Id_Categoria+"', '"+producto.Estado+"')", con);
            var resultado = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
