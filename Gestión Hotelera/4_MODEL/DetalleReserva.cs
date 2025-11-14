using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MODEL
{
    public class DetalleReserva
    {
        private int _idDetalleReserva;
        private int _idReserva;
        private int _idHabitacion;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private decimal _precioPorNoche;
        private string _tipoHabitacion = string.Empty;

        public int IdDetalleReserva { get => _idDetalleReserva; set => _idDetalleReserva = value; }
        public int IdReserva { get => _idReserva; set => _idReserva = value; }
        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
        public decimal PrecioPorNoche { get => _precioPorNoche; set => _precioPorNoche = value; }
        public string TipoHabitacion { get => _tipoHabitacion; set => _tipoHabitacion = value; }

        public DetalleReserva() { }

        public DetalleReserva(int idDetalleReserva, int idReserva, int idHabitacion,
                              DateTime fechaInicio, DateTime fechaFin,
                              decimal precioPorNoche, string tipoHabitacion)
        {
            IdDetalleReserva = idDetalleReserva;
            IdReserva = idReserva;
            IdHabitacion = idHabitacion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            PrecioPorNoche = precioPorNoche;
            TipoHabitacion = tipoHabitacion;
        }
    }
}

