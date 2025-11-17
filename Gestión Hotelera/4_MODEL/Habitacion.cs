using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MODEL
{
    public class Habitacion
    {
        // Estas variables solo pueden ser usadas dentro de esta clase:
        private int idHabitacion;
        private string tipo;
        private decimal precioPorNoche;
        private string estado;

        // Las propiedades permiten acceder o modificar los atributos privados:
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }  
        public decimal PrecioPorNoche { get => precioPorNoche; set => precioPorNoche = value; }
        public string Estado { get => estado; set => estado = value; }
      



        /// Constructor vacío. Permite crear un objeto sin valores iniciales:
        public Habitacion() { }
        /// Constructor que permite crear una habitación con todos sus datos completos:
        public Habitacion(int idHabitacion,string tipo, decimal precioPorNoche, string estado)
        {

            IdHabitacion = idHabitacion;
            Tipo = tipo;
            PrecioPorNoche = precioPorNoche;
            Estado = estado;

        }
    }
}
