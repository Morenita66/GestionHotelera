using _4_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _3_DAL
{
    public class ConexionReserva
    {
        // Usar la cadena de configuración
        public string Cadena => Configuracion.Cadena;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(Cadena);
        }

        public List<Reserva> Leer()
        {
            var listaReservas = new List<Reserva>();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = @"
                    SELECT r.idReserva, r.idCliente, r.idRecepcionista, r.precioTotal, r.estado,
                           c.nombre + ' ' + c.apellido as nombreCliente,
                           rec.nombre + ' ' + rec.apellido as nombreRecepcionista
                    FROM Reserva r
                    INNER JOIN Cliente c ON r.idCliente = c.idCliente
                    INNER JOIN Recepcionista rec ON r.idRecepcionista = rec.idRecepcionista";

                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            listaReservas.Add(new Reserva
                            {
                                IdReserva = lector.IsDBNull(0) ? 0 : Convert.ToInt32(lector.GetValue(0)),
                                IdCliente = lector.IsDBNull(1) ? 0 : Convert.ToInt32(lector.GetValue(1)),
                                IdRecepcionista = lector.IsDBNull(2) ? 0 : Convert.ToInt32(lector.GetValue(2)),
                                PrecioTotal = lector.IsDBNull(3) ? 0 : Convert.ToDecimal(lector.GetValue(3)),
                                Estado = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                                NombreCliente = lector.IsDBNull(5) ? string.Empty : lector.GetString(5),
                                NombreRecepcionista = lector.IsDBNull(6) ? string.Empty : lector.GetString(6)
                            });
                        }
                    }
                }
            }
            return listaReservas;
        }

        public void Agregar(Reserva nueva)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = @"
                    INSERT INTO Reserva (idCliente, idRecepcionista, precioTotal, estado)
                    VALUES (@idCliente, @idRecepcionista, @precioTotal, @estado)";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idCliente", nueva.IdCliente);
                    comando.Parameters.AddWithValue("@idRecepcionista", nueva.IdRecepcionista);
                    comando.Parameters.AddWithValue("@precioTotal", nueva.PrecioTotal);
                    comando.Parameters.AddWithValue("@estado", nueva.Estado);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Modificar(Reserva modificada)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = @"
                    UPDATE Reserva 
                    SET idCliente = @idCliente,
                        idRecepcionista = @idRecepcionista,
                        precioTotal = @precioTotal,
                        estado = @estado
                    WHERE idReserva = @idReserva";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@idReserva", modificada.IdReserva);
                    comando.Parameters.AddWithValue("@idCliente", modificada.IdCliente);
                    comando.Parameters.AddWithValue("@idRecepcionista", modificada.IdRecepcionista);
                    comando.Parameters.AddWithValue("@precioTotal", modificada.PrecioTotal);
                    comando.Parameters.AddWithValue("@estado", modificada.Estado);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPorId(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = "DELETE FROM Reserva WHERE idReserva = @id";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Reserva> Buscar(string busca)
        {
            var listaReservas = new List<Reserva>();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = @"
                    SELECT r.idReserva, r.idCliente, r.idRecepcionista, r.precioTotal, r.estado,
                           c.nombre + ' ' + c.apellido as nombreCliente,
                           rec.nombre + ' ' + rec.apellido as nombreRecepcionista
                    FROM Reserva r
                    INNER JOIN Cliente c ON r.idCliente = c.idCliente
                    INNER JOIN Recepcionista rec ON r.idRecepcionista = rec.idRecepcionista
                    WHERE c.nombre LIKE @patron OR c.apellido LIKE @patron OR c.dni LIKE @patron";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@patron", "%" + (busca ?? string.Empty) + "%");

                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            listaReservas.Add(new Reserva
                            {
                                IdReserva = lector.IsDBNull(0) ? 0 : Convert.ToInt32(lector.GetValue(0)),
                                IdCliente = lector.IsDBNull(1) ? 0 : Convert.ToInt32(lector.GetValue(1)),
                                IdRecepcionista = lector.IsDBNull(2) ? 0 : Convert.ToInt32(lector.GetValue(2)),
                                PrecioTotal = lector.IsDBNull(3) ? 0 : Convert.ToDecimal(lector.GetValue(3)),
                                Estado = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                                NombreCliente = lector.IsDBNull(5) ? string.Empty : lector.GetString(5),
                                NombreRecepcionista = lector.IsDBNull(6) ? string.Empty : lector.GetString(6)
                            });
                        }
                    }
                }
            }

            return listaReservas;
        }

        public Reserva ObtenerPorId(int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = @"
                    SELECT r.idReserva, r.idCliente, r.idRecepcionista, r.precioTotal, r.estado,
                           c.nombre + ' ' + c.apellido as nombreCliente,
                           rec.nombre + ' ' + rec.apellido as nombreRecepcionista
                    FROM Reserva r
                    INNER JOIN Cliente c ON r.idCliente = c.idCliente
                    INNER JOIN Recepcionista rec ON r.idRecepcionista = rec.idRecepcionista
                    WHERE r.idReserva = @id";

                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Reserva
                            {
                                IdReserva = lector.IsDBNull(0) ? 0 : Convert.ToInt32(lector.GetValue(0)),
                                IdCliente = lector.IsDBNull(1) ? 0 : Convert.ToInt32(lector.GetValue(1)),
                                IdRecepcionista = lector.IsDBNull(2) ? 0 : Convert.ToInt32(lector.GetValue(2)),
                                PrecioTotal = lector.IsDBNull(3) ? 0 : Convert.ToDecimal(lector.GetValue(3)),
                                Estado = lector.IsDBNull(4) ? string.Empty : lector.GetString(4),
                                NombreCliente = lector.IsDBNull(5) ? string.Empty : lector.GetString(5),
                                NombreRecepcionista = lector.IsDBNull(6) ? string.Empty : lector.GetString(6)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}