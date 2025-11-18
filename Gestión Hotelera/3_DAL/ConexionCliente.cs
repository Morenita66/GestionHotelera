using _4_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _3_DAL
{
    public class ConexionCliente
    {
        // Usar la cadena de configuración
        public string Cadena => Configuracion.Cadena;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(Cadena);
        }

        public List<Cliente> Leer()
        {
            var listaClientes = new List<Cliente>();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = "SELECT idCliente, nombre, apellido, email, telefono, dni, edad, idDomicilio FROM Cliente";

                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var cliente = new Cliente
                            {
                                IdCliente = lector.IsDBNull(0) ? 0 : Convert.ToInt32(lector.GetValue(0)),
                                Nombre = lector.IsDBNull(1) ? string.Empty : lector.GetString(1),
                                Apellido = lector.IsDBNull(2) ? string.Empty : lector.GetString(2),
                                Email = lector.IsDBNull(3) ? string.Empty : lector.GetString(3),
                                Telefono = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                                Dni = lector.IsDBNull(5) ? string.Empty : lector.GetString(5),
                                Edad = lector.IsDBNull(6) ? 0 : Convert.ToInt32(lector.GetValue(6)),
                                IdDomicilio = lector.IsDBNull(7) ? 0 : Convert.ToInt32(lector.GetValue(7))
                            };
                            listaClientes.Add(cliente);
                        }
                    }
                }
            }
            return listaClientes;
        }

        public void Agregar(Cliente nuevo)
        {
            using (var conexion = GetConnection())
            using (var comando = new SqlCommand(
                @"INSERT INTO Cliente (nombre, apellido, email, telefono, dni, edad, idDomicilio)
                VALUES (@nombre, @apellido, @email, @telefono, @dni, @edad, @idDomicilio)", conexion))
            {
                comando.CommandType = System.Data.CommandType.Text;

                comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                comando.Parameters.AddWithValue("@email", nuevo.Email ?? string.Empty);
                comando.Parameters.AddWithValue("@telefono", nuevo.Telefono ?? string.Empty);
                comando.Parameters.AddWithValue("@dni", nuevo.Dni);
                comando.Parameters.AddWithValue("@edad", nuevo.Edad);
                comando.Parameters.AddWithValue("@idDomicilio", nuevo.IdDomicilio);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Cliente> Buscar(string busca)
        {
            var listaClientes = new List<Cliente>();

            using (var conexion = GetConnection())
            using (var comando = new SqlCommand("SELECT idCliente, nombre, apellido, email, telefono, dni, edad, idDomicilio FROM Cliente WHERE nombre LIKE @busca OR apellido LIKE @busca OR dni LIKE @busca", conexion))
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@busca", "%" + busca + "%");

                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var cliente = new Cliente
                        {
                            IdCliente = lector.IsDBNull(0) ? 0 : Convert.ToInt32(lector.GetValue(0)),
                            Nombre = lector.IsDBNull(1) ? string.Empty : lector.GetString(1),
                            Apellido = lector.IsDBNull(2) ? string.Empty : lector.GetString(2),
                            Email = lector.IsDBNull(3) ? string.Empty : lector.GetString(3),
                            Telefono = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                            Dni = lector.IsDBNull(5) ? string.Empty : lector.GetString(5),
                            Edad = lector.IsDBNull(6) ? 0 : Convert.ToInt32(lector.GetValue(6)),
                            IdDomicilio = lector.IsDBNull(7) ? 0 : Convert.ToInt32(lector.GetValue(7))
                        };
                        listaClientes.Add(cliente);
                    }
                }
            }
            return listaClientes;
        }

        public void Modificar(Cliente modificado)
        {
            using (var conexion = GetConnection())
            using (var comando = new SqlCommand(
                @"UPDATE Cliente SET nombre = @nombre, apellido = @apellido, email = @email, 
                  telefono = @telefono, dni = @dni, edad = @edad, idDomicilio = @idDomicilio 
                  WHERE idCliente = @idCliente", conexion))
            {
                comando.CommandType = System.Data.CommandType.Text;

                comando.Parameters.AddWithValue("@idCliente", modificado.IdCliente);
                comando.Parameters.AddWithValue("@nombre", modificado.Nombre);
                comando.Parameters.AddWithValue("@apellido", modificado.Apellido);
                comando.Parameters.AddWithValue("@email", modificado.Email ?? string.Empty);
                comando.Parameters.AddWithValue("@telefono", modificado.Telefono ?? string.Empty);
                comando.Parameters.AddWithValue("@dni", modificado.Dni);
                comando.Parameters.AddWithValue("@edad", modificado.Edad);
                comando.Parameters.AddWithValue("@idDomicilio", modificado.IdDomicilio);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void eliminar(Cliente eliminar)
        {
            using (var conexion = GetConnection())
            using (var comando = new SqlCommand("DELETE FROM Cliente WHERE idCliente = @idCliente", conexion))
            {
                comando.Parameters.AddWithValue("@idCliente", eliminar.IdCliente);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}