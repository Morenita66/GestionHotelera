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
        SqlConnection conexionHabitacion = new SqlConnection();
        SqlCommand comando = new SqlCommand();

        // Leemos todas
        public List<Habitacion> Leer()
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();


            SqlDataReader lector;

            conexionHabitacion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Habitacion";
            comando.Connection = conexionHabitacion;
            conexionHabitacion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Habitacion aux = new Habitacion();
                aux.IdHabitacion= lector.GetInt32(0);
                aux.Tipo = lector.GetString(1);
                aux.PrecioPorNoche= lector.GetInt32(2);
                aux.Estado = lector.GetString(3);

                listaHabitacion.Add(aux);

            }
            conexionHabitacion.Close();
            return listaHabitacion;
        }
        
        public void Agregar(Habitacion nuevo)
        {

            conexionHabitacion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "insert into Habitacion values (@idHabitacion,@tipo,@precioPorNoche,@estado)";

            comando.Parameters.AddWithValue("@idHabitacion", nuevo.IdHabitacion);
            comando.Parameters.AddWithValue("@tipo", nuevo.Tipo);
            comando.Parameters.AddWithValue("@precioPorNoche", nuevo.PrecioPorNoche);
            comando.Parameters.AddWithValue("@estado", nuevo.Estado);

            comando.Connection = conexionHabitacion;

            conexionHabitacion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexionHabitacion.Close();


        }

        public List<Habitacion> Buscar(string busca)
        {
            List<Habitacion> listaHabitacion = new List<Habitacion>();

            conexionHabitacion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "select * from Habitacion Where nombre like'" + busca + "'";
            comando.Connection = conexionHabitacion;
            conexionHabitacion.Open();

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Habitacion aux = new Habitacion();
                aux.IdHabitacion = lector.GetInt32(0);
                aux.Tipo = lector.GetString(1);
                aux.PrecioPorNoche = lector.GetInt32(2);
                aux.Estado = lector.GetString(3);

                listaHabitacion.Add(aux);

            }
            conexionHabitacion.Close();
            return listaHabitacion;
        }
        public void Modificar(Habitacion habitacionModificar)
        {

            conexionHabitacion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update Habitacion set IdHabitacion=@idHabitacion,Tipo=@tipo,PrecioPorNoche=@precioPorNoche,Estado=@estado Where Id=" + habitacionModificar.IdHabitacion;
            comando.Parameters.AddWithValue("@idHabitacion", habitacionModificar.IdHabitacion);
            comando.Parameters.AddWithValue("@tipo", habitacionModificar.Tipo);
            comando.Parameters.AddWithValue("@precioPorNoche", habitacionModificar.PrecioPorNoche);
            comando.Parameters.AddWithValue("@estado", habitacionModificar.Estado);


            comando.Connection = conexionHabitacion;

            conexionHabitacion.Open();
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexionHabitacion.Close();

        }

        public void Eliminar(Habitacion eliminar)
        {

            conexionHabitacion.ConnectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "delete from Habitacion where idHabitacion=@idHabitacion";
            comando.Parameters.AddWithValue("@idHabitacion", eliminar.IdHabitacion);

            comando.Connection = conexionHabitacion;

            conexionHabitacion.Open();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexionHabitacion.Close();
        }
    }
}
