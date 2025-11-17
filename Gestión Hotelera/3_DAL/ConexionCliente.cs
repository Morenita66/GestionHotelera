using _4_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _3_DAL
{
    public class ConexionCliente
    {
        public const string Cadena = "Server=SANTI;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public void Agregar(Cliente nuevo)
        {
            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(
                @"INSERT INTO Cliente (nombre, apellido, email, telefono, dni, edad)
              VALUES (@nombre, @apellido, @email, @telefono, @dni, @edad)", conexion))
            {
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                comando.Parameters.AddWithValue("@email", nuevo.Email ?? string.Empty);
                comando.Parameters.AddWithValue("@telefono", nuevo.Telefono ?? string.Empty);
                comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                comando.Parameters.AddWithValue("@edad", nuevo.Edad);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Cliente> Leer()
        {
            var listaClientes = new List<Cliente>();
            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(@"
                SELECT idCliente, nombre, apellido, email, telefono, dni, edad
                FROM Cliente", conexion))
            {
                comando.CommandType = CommandType.Text;
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var aux = new Cliente
                        {
                            IdCliente = lector.GetInt32(0),
                            Nombre = lector.GetString(1),
                            Apellido = lector.GetString(2),
                            Email = lector.IsDBNull(3) ? string.Empty : lector.GetString(3),
                            Telefono = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                            Dni = lector.GetString(5),
                            Edad = lector.IsDBNull(6) ? 0 : lector.GetInt32(6)
                        };
                        listaClientes.Add(aux);
                    }
                }
            }
            return listaClientes;
        }
    }
}