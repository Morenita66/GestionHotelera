using _4_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _3_DAL
{
    public class ConexionCliente
    {
        // CÓDIGO DE SANTIGO DE CONEXIÓN CLIENTE
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

        /* CÓDIGO ORIGINAL DE AMANDA EN CLASE CONEXIÓN CLIENTE
         * internal class Conexion
    {
        //generamos objetos para poder establecer una conexion y poder ejecutar los comandos
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
       

       //creamos el metodo leer
        public List<Clientee> Leer() //Creamos una lista 
        {
            

            List<Clientee> listacliente = new List<Clientee>();
            SqlDataReader lector;
            try
            {
                //configuramos la conexion
                conexion.ConnectionString = "server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
                comando.Connection = conexion;//configuramos el comando 
                comando.CommandType =System.Data.CommandType.Text;//aca le decimos que en el comando.commandType convierta lo q esta en el sql como codigo
                comando.CommandText = "SELECT * FROM Cliente";//le consulta a la base de datos

                conexion.Open();//abrimos la conexion
                lector= comando.ExecuteReader();//ejecuta el select y obtiene los datos

                {
                    while (lector.Read())
                    {
                        listacliente.Add(new Clientee
                        {
                            IdCliente = (int)lector["idCliente"], 
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Email = lector["email"].ToString(),
                            Telefono = lector["telefono"].ToString(),
                            Dni = lector["dni"].ToString(),
                            Edad = (int)lector["edad"],
                            IdDomicilio = (int)lector["idDomicilio"]
                        });
                    }
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();//si queda abierta se cierra la conexion
            }
            return listacliente;
        }
        //creamos el metodo agregar para agregar un nuevo cliente
        public void Agregar(Clientee nuevo) 
        {
           conexion.ConnectionString="server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
           comando.CommandType= System.Data.CommandType.Text;

            //Aca vamos a configurar el comando 
            comando.CommandText=@"INSERT INTO Cliente (nombre, apellido, email, telefono, dni, edad, idDomicilio)
            VALUES (@nombre, @apellido, @email, @telefono, @dni, @edad, @idDomicilio)";
            //Agregamos los valores a los parametros 
            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@apellido",nuevo.Apellido);
            comando.Parameters.AddWithValue("@email", nuevo.Email);
            comando.Parameters.AddWithValue("@telefono", nuevo.Telefono);
            comando.Parameters.AddWithValue("@dni", nuevo.Dni);
            comando.Parameters.AddWithValue("@edad", nuevo.Edad);
            comando.Parameters.AddWithValue("@idDomicilio", nuevo.IdDomicilio);

            comando.Connection=conexion;
            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear(); //Limpiamos todos los parámetros usados
            conexion.Close();

        }
        public List<Clientee> Buscar(string busca) 
        {
            
            List<Clientee> listacliente = new List<Clientee>();

            conexion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "select * from Cliente Where nombre like'" + busca + "'";
            comando.Connection = conexion;
            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
               ;
                Clientee cliente = new Clientee();
                cliente.IdCliente=lector.GetInt32(0);
                cliente.Nombre=lector.GetString(1);
                cliente.Apellido=lector.GetString(2);
                cliente.Email=lector.GetString(3);
                cliente.Telefono=lector.GetString(4);
                cliente.Dni=lector.GetString(5);
                cliente.Edad=lector.GetInt32(6);
                cliente.IdDomicilio=lector.GetInt32(7);

                listacliente.Add(cliente);

            }
            conexion.Close();
            return listacliente;

        }
        
      
        public void Modificar(Clientee modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try{ 

            conexion.ConnectionString="server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType= System.Data.CommandType.Text;

            comando.CommandText="UPDATE Cliente set  Nombre=@nombre,Apellido=@apellido,Email = @email,Telefono = @telefono,Dni = @dni,Edad = @edad,IdDomicilio = @idDomicilio  WHERE idCliente ="+modificado.IdCliente;
           
            comando.Parameters.AddWithValue("@nombre", modificado.Nombre);
            comando.Parameters.AddWithValue("@apellido", modificado.Apellido);
            comando.Parameters.AddWithValue("email", modificado.Email);
            comando.Parameters.AddWithValue("@telefono", modificado.Telefono);
            comando.Parameters.AddWithValue("@dni", modificado.Dni);
            comando.Parameters.AddWithValue("@edad", modificado.Edad);
            comando.Parameters.AddWithValue("@idDomicilio", modificado.IdDomicilio);

            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();                 //Limpia todos los parámetros usados
            conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
        internal void eliminar(Clientee eliminar)
          {


            conexion.ConnectionString="server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Cliente WHERE idCliente = " + eliminar.IdCliente;
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }

    }
       
} */
    }
}