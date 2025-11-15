using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MODEL
{
    internal class Habitaciones
    {
        // Estas variables solo pueden ser usadas dentro de esta clase:
        private int habitacion;
        private string tipo;
        private double precioPorNoche;
        private string estado;

        // Las propiedades permiten acceder o modificar los atributos privados:
        public int Habitacion { get => habitacion; set => habitacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double PrecioPorNoche { get => precioPorNoche; set => precioPorNoche = value; }
        public string Estado { get => estado; set => estado = value; }
        /// Constructor vacío. Permite crear un objeto sin valores iniciales:
        public Habitaciones() { }
        /// Constructor que permite crear una habitación con todos sus datos completos:
        public Habitaciones(int habitaciones,string tipo, double precioPorNoche, string estado)
        {
            Habitacion = habitaciones;
            Tipo = tipo;
            PrecioPorNoche = precioPorNoche;
            Estado = estado;

        }
    }
}
