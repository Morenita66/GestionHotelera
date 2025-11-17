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
    public class ConexionHabitacion
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();

        // Leemos todas
        public List<Habitacion> Leer()
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();


            SqlDataReader lector;

            conexion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Habitacion";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Habitacion aux = new Habitacion();
                aux.IdHabitacion= lector.GetInt32(0);
                aux.Tipo = lector.GetString(1);
                aux.PrecioPorNoche= lector.GetDecimal(2);
                aux.Estado = lector.GetString(3);

                listaHabitacion.Add(aux);

            }
            conexion.Close();
            return listaHabitacion;
        }
        
        public void Agregar(Habitacion nuevo)
        {

            conexion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "INSERT INTO Habitacion (tipo,precioPorNoche,estado) values (@tipo,@precioPorNoche,@estado)";

            comando.Parameters.AddWithValue("@tipo", nuevo.Tipo);
            comando.Parameters.AddWithValue("@precioPorNoche", nuevo.PrecioPorNoche);
            comando.Parameters.AddWithValue("@estado", nuevo.Estado);

            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.Close();
        }

        public List<Habitacion> Buscar(int busca)
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();

            conexion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "select * from Habitacion Where idHabitacion =" + busca + "";
        

            comando.Parameters.AddWithValue("@id",busca);

            comando.Connection = conexion;

            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Habitacion aux = new Habitacion();
                aux.IdHabitacion = lector.GetInt32(0);
                aux.Tipo = lector.GetString(1);
                aux.PrecioPorNoche = lector.GetDecimal(2);
                aux.Estado = lector.GetString(3);

                listaHabitacion.Add(aux);
            }
            conexion.Close();
            return listaHabitacion;
        }
        public void Modificar(Habitacion habitacionModificar)
        {

            conexion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update Habitacion set IdHabitacion=@idHabitacion,Tipo=@tipo,PrecioPorNoche=@precioPorNoche,Estado=@estado Where Id=" + habitacionModificar.IdHabitacion;
            comando.Parameters.AddWithValue("@idHabitacion", habitacionModificar.IdHabitacion);
            comando.Parameters.AddWithValue("@tipo", habitacionModificar.Tipo);
            comando.Parameters.AddWithValue("@precioPorNoche", habitacionModificar.PrecioPorNoche);
            comando.Parameters.AddWithValue("@estado", habitacionModificar.Estado);


            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.Close();

        }

        public void Eliminar(Habitacion eliminar)
        {

            conexion.ConnectionString = "server=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM Habitacion WHERE idHabitacion = " + eliminar.IdHabitacion;
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
