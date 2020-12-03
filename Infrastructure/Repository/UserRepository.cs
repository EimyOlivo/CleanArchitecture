using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Repository.Commons;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        ConnectionDB conexion;
        public UserRepository()
        {
            conexion = new ConnectionDB();

        }
        public List<User> buscarUser()
        {
            var con = conexion.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id, Nombre, Apellido, Direccion, Estado from \"User\"", con);
            var resultado = cmd.ExecuteReader();
            List<User> user = new List<User>();
            while (resultado.Read())
            {
                user.Add(new User((int)resultado["Id"], resultado["Nombre"].ToString(), resultado["Apellido"].ToString(), resultado["Direccion"].ToString(), resultado["Estado"].ToString()));
            }
            con.Close();

            return user;
        }

        public void crearUser(User user)
        {
            var con = conexion.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into \"User\" values ('" + user.Id + "', '" + user.Nombre + "', '" + user.Apellido + "', '"+user.Direccion+"', '"+user.Estado+"')", con);
            var resultado = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
