using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MODEL
{
     public class Reserva
    {

        private int idReserva;
        private int idCliente;
        private int idRecepcionista;
        private decimal precioTotal;
        private string estado;
        private string nombreCliente;
        private string nombreRecepcionista;

        public int IdReserva { get => idReserva; set => idReserva = value; }

        public int IdCliente
        {
            get => idCliente;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID de cliente debe ser mayor a 0.");
                idCliente = value;
            }
        }

        public int IdRecepcionista
        {
            get => idRecepcionista;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID de recepcionista debe ser mayor a 0.");
                idRecepcionista = value;
            }
        }

        public decimal PrecioTotal
        {
            get => precioTotal;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio total no puede ser negativo.");
                precioTotal = value;
            }
        }

        public string Estado
        {
            get => estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El estado no puede estar vacio.");
                estado = value.Trim();
            }
        }

        public string NombreCliente
        {
            get => nombreCliente;
            set => nombreCliente = value?.Trim();
        }

        public string NombreRecepcionista
        {
            get => nombreRecepcionista;
            set => nombreRecepcionista = value?.Trim();
        }


        // Constructor por defecto
        public Reserva() { }

        // Constructor con parámetros
        public Reserva(int idReserva, int idCliente, int idRecepcionista, decimal precioTotal, string estado, string nombreCliente, string nombreRecepcionista)
        {
            IdReserva = idReserva;
            IdCliente = idCliente;
            IdRecepcionista = idRecepcionista;
            PrecioTotal = precioTotal;
            Estado = estado;
            NombreCliente = nombreCliente;
            NombreRecepcionista = nombreRecepcionista;
        }
    }
}
