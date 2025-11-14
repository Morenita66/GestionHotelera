using _4_MODEL;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _3_DAL
{
    public class ConexionReserva
    {
        public const string Cadena = "Server=SANTI;Initial Catalog=HotelDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public List<Reserva> Leer()
        {
            var listaReservas = new List<Reserva>();

            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(@"SELECT r.idReserva, r.idCliente, r.idRecepcionista, r.precioTotal, r.estado,c.nombre + ' ' + c.apellido as nombreCliente, rec.nombre + ' ' + rec.apellido as nombreRecepcionista FROM Reserva r INNER JOIN Cliente c ON r.idCliente = c.idCliente INNER JOIN Recepcionista rec ON r.idRecepcionista = rec.idRecepcionista", conexion))
            {
                comando.CommandType = CommandType.Text;
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var aux = new Reserva
                        {
                            IdReserva = lector.GetInt32(0),
                            IdCliente = lector.GetInt32(1),
                            IdRecepcionista = lector.GetInt32(2),
                            PrecioTotal = lector.GetDecimal(3),
                            Estado = lector.GetString(4),
                            NombreCliente = lector.GetString(5),
                            NombreRecepcionista = lector.GetString(6)
                        };
                        listaReservas.Add(aux);
                    }
                }
            }
            return listaReservas;
        }

        public void Agregar(Reserva nueva)
        {
            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(
                @"INSERT INTO Reserva (idCliente, idRecepcionista, precioTotal, estado) VALUES (@idCliente, @idRecepcionista, @precioTotal, @estado)", conexion))
            {
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@idCliente", nueva.IdCliente);
                comando.Parameters.AddWithValue("@idRecepcionista", nueva.IdRecepcionista);
                comando.Parameters.AddWithValue("@precioTotal", nueva.PrecioTotal);
                comando.Parameters.AddWithValue("@estado", nueva.Estado);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Modificar(Reserva modificada)
        {
            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(
                @"UPDATE Reserva
              SET idCliente = @idCliente,
                  idRecepcionista = @idRecepcionista,
                  precioTotal = @precioTotal,
                  estado = @estado
              WHERE idReserva = @idReserva", conexion))
            {
                comando.CommandType = CommandType.Text;

                comando.Parameters.AddWithValue("@idReserva", modificada.IdReserva);
                comando.Parameters.AddWithValue("@idCliente", modificada.IdCliente);
                comando.Parameters.AddWithValue("@idRecepcionista", modificada.IdRecepcionista);
                comando.Parameters.AddWithValue("@precioTotal", modificada.PrecioTotal);
                comando.Parameters.AddWithValue("@estado", modificada.Estado);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Reserva> Buscar(string busca)
        {
            var listaReservas = new List<Reserva>();

            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(@"
                SELECT r.idReserva, r.idCliente, r.idRecepcionista, r.precioTotal, r.estado,
                       c.nombre + ' ' + c.apellido as nombreCliente,
                       rec.nombre + ' ' + rec.apellido as nombreRecepcionista
                FROM Reserva r
                INNER JOIN Cliente c ON r.idCliente = c.idCliente
                INNER JOIN Recepcionista rec ON r.idRecepcionista = rec.idRecepcionista
                WHERE c.nombre LIKE @patron OR c.apellido LIKE @patron OR c.dni LIKE @patron", conexion))
            {
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@patron", "%" + (busca ?? string.Empty) + "%");

                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var aux = new Reserva
                        {
                            IdReserva = lector.GetInt32(0),
                            IdCliente = lector.GetInt32(1),
                            IdRecepcionista = lector.GetInt32(2),
                            PrecioTotal = lector.GetDecimal(3),
                            Estado = lector.GetString(4),
                            NombreCliente = lector.GetString(5),
                            NombreRecepcionista = lector.GetString(6)
                        };
                        listaReservas.Add(aux);
                    }
                }
            }

            return listaReservas;
        }

        public void EliminarPorId(int id)
        {
            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(
                @"DELETE FROM Reserva WHERE idReserva = @id", conexion))
            {
                comando.Parameters.AddWithValue("@id", id);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public Reserva ObtenerPorId(int id)
        {
            using (var conexion = new SqlConnection(Cadena))
            using (var comando = new SqlCommand(@"
                SELECT r.idReserva, r.idCliente, r.idRecepcionista, r.precioTotal, r.estado,
                       c.nombre + ' ' + c.apellido as nombreCliente,
                       rec.nombre + ' ' + rec.apellido as nombreRecepcionista
                FROM Reserva r
                INNER JOIN Cliente c ON r.idCliente = c.idCliente
                INNER JOIN Recepcionista rec ON r.idRecepcionista = rec.idRecepcionista
                WHERE r.idReserva = @id", conexion))
            {
                comando.Parameters.AddWithValue("@id", id);
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        return new Reserva
                        {
                            IdReserva = lector.GetInt32(0),
                            IdCliente = lector.GetInt32(1),
                            IdRecepcionista = lector.GetInt32(2),
                            PrecioTotal = lector.GetDecimal(3),
                            Estado = lector.GetString(4),
                            NombreCliente = lector.GetString(5),
                            NombreRecepcionista = lector.GetString(6)
                        };
                    }
                }
            }
            return null;
        }
    }
}