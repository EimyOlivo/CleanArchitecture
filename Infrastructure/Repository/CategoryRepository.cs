using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces.Repository;
using System.Data.SqlClient;
using Domain.Entities;
using Infrastructure.Repository.Commons;

namespace Infrastructure.Repository
{

    public class CategoryRepository : ICategoryRepository
    {
        ConnectionDB conexion;
        public CategoryRepository()
        {
            conexion = new ConnectionDB();
            
        }
        public List<Category> buscarCategoria()
        {   
            var con = conexion.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id, Nombre, Estado from Category", con);
            var resultado = cmd.ExecuteReader();
            List<Category> categories = new List<Category>(); 
            while (resultado.Read())
            {
                categories.Add(new Category((int)resultado["Id"], resultado["Nombre"].ToString(), resultado["Estado"].ToString()));
            }
            con.Close();

            return categories;

        }

        public void crearCategoria(Category category)

        {
            throw new NotImplementedException();
        }
    }
}
