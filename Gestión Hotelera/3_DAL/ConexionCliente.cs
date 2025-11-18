using _4_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DAL
{
    public class ConexionCliente
    {
        //generamos objetos para poder establecer una conexion
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();


        //Leemos todos
        public List<Cliente> Leer() 
        {


            List<Cliente> listacliente = new List<Cliente>();
            SqlDataReader lector;
            try
            {

                conexion.ConnectionString = "server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
                comando.Connection = conexion;
                comando.CommandType =System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM Cliente";

                conexion.Open();
                lector= comando.ExecuteReader();

                {
                    while (lector.Read())
                    {
                        
                        
                           Cliente cliente = new Cliente();
                        cliente.IdCliente = (int)lector["idCliente"];
                        cliente.Nombre = lector["nombre"].ToString();
                        cliente.Apellido = lector["apellido"].ToString();
                        cliente.Email = lector["email"].ToString();
                        cliente.Telefono = lector["telefono"].ToString();
                        cliente.Dni = lector["dni"].ToString();
                        cliente.Edad = (int)lector["edad"];
                        cliente.IdDomicilio = (int)lector["idDomicilio"];

                        listacliente.Add(cliente);
                        
                    }
                    conexion.Close();
                    return listacliente;
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
            return listacliente;
        }

        public void Agregar(Cliente nuevo)
        {
            conexion.ConnectionString="server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType= System.Data.CommandType.Text;

            //Aca vamos a configurar el comando 
            comando.CommandText=@"INSERT INTO Cliente (nombre, apellido, email, telefono, dni, edad, idDomicilio)
            VALUES (@nombre, @apellido, @email, @telefono, @dni, @edad, @idDomicilio)";
            //Agregamos los valores a los parametros 
            comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
            comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
            comando.Parameters.AddWithValue("@email", nuevo.Email);
            comando.Parameters.AddWithValue("@telefono", nuevo.Telefono);
            comando.Parameters.AddWithValue("@dni", nuevo.Dni);
            comando.Parameters.AddWithValue("@edad", nuevo.Edad);
            comando.Parameters.AddWithValue("@idDomicilio", nuevo.IdDomicilio);

            comando.Connection=conexion;
            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear(); //Limpia todos los parámetros usados
            conexion.Close();

        }
        public List<Cliente> Buscar(string busca)
        {

            List<Cliente> listacliente = new List<Cliente>();

            conexion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "select * from Cliente Where nombre like'" + busca + "'";
            comando.Connection = conexion;
            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                ;
                Cliente cliente = new Cliente();
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


        public void Modificar(Cliente modificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {

                conexion.ConnectionString="server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
                comando.CommandType= System.Data.CommandType.Text;

                comando.CommandText="UPDATE Cliente set IdCliente=@idCliente, Nombre=@nombre,Apellido=@apellido,Email = @email,Telefono = @telefono,Dni = @dni,Edad = @edad,IdDomicilio = @idDomicilio  WHERE idCliente = @idCliente\";"+modificado.IdCliente;
                comando.Parameters.AddWithValue("idCliente", modificado.IdCliente);
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
       public void eliminar(Cliente eliminar)
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
}