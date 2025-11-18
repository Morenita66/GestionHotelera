namespace _4_MODEL
{
    public class Reserva
    {
        private int _idReserva;
        private int _idCliente;
        private int _idRecepcionista;
        private decimal _precioTotal;
        private string _estado;
        private string _nombreCliente;
        private string _nombreRecepcionista;

        public int IdReserva { get => _idReserva; set => _idReserva = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdRecepcionista { get => _idRecepcionista; set => _idRecepcionista = value; }
        public decimal PrecioTotal { get => _precioTotal; set => _precioTotal = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string NombreRecepcionista { get => _nombreRecepcionista; set => _nombreRecepcionista = value; }

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