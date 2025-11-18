using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MODEL
{
    public class Cliente
    {
        //Ponemos los atributos que va a tener nuestro cliente
        private int _idCliente;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _telefono;
        private string _dni;
        private int _edad;
        private int _idDomicilio;
        //Aca van a estar las propiedades
        public int IdCliente { get => _idCliente; set => _idCliente=value; }
        public string Nombre { get => _nombre; set => _nombre=value; }
        public string Apellido { get => _apellido; set => _apellido=value; }
        public string Email { get => _email; set => _email=value; }
        public string Telefono { get => _telefono; set => _telefono=value; }
        public string Dni { get => _dni; set => _dni=value; }
        public int Edad { get => _edad; set => _edad=value; }
        public int IdDomicilio { get => _idDomicilio; set => _idDomicilio=value; }

        //Vamos a generar el constructor 
        public Cliente() { }

        //Vamos a generar el constructor por parametros
        public Cliente(int idCliente, string nombre, string apellido, string email, string telefono, string dni, int edad, int idDomicilio)
        {
            IdCliente=idCliente;
            _nombre=nombre;
            _apellido=apellido;
            _email=email;
            _telefono=telefono;
            _dni=dni;
            _edad=edad;
            _idDomicilio=idDomicilio;

        }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - DNI: {Dni}";
        }
    }
}
