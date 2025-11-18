using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MODEL
{
    public class Cliente
    {
        // Atributos privados
        private int _idCliente;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _telefono;
        private string _dni;
        private int _edad;
        private int _idDomicilio;

        // Propiedades públicas con validación
        public int IdCliente
        {
            get => _idCliente;
            set => _idCliente = value;
        }

        public string Nombre
        {
            get => _nombre ?? string.Empty;
            set => _nombre = value?.Trim();
        }

        public string Apellido
        {
            get => _apellido ?? string.Empty;
            set => _apellido = value?.Trim();
        }

        public string Email
        {
            get => _email ?? string.Empty;
            set => _email = value?.Trim();
        }

        public string Telefono
        {
            get => _telefono ?? string.Empty;
            set => _telefono = value?.Trim();
        }

        public string Dni
        {
            get => _dni ?? string.Empty;
            set => _dni = value?.Trim();
        }

        public int Edad
        {
            get => _edad;
            set
            {
                if (value < 0 || value > 150)
                    throw new ArgumentException("La edad debe estar entre 0 y 150 años.");
                _edad = value;
            }
        }

        public int IdDomicilio
        {
            get => _idDomicilio;
            set => _idDomicilio = value;
        }

        // Constructores
        public Cliente()
        {
            _nombre = string.Empty;
            _apellido = string.Empty;
            _email = string.Empty;
            _telefono = string.Empty;
            _dni = string.Empty;
        }

        public Cliente(int idCliente, string nombre, string apellido, string email, string telefono, string dni, int edad, int idDomicilio)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Dni = dni;
            Edad = edad;
            IdDomicilio = idDomicilio;
        }

        // Método ToString sobrescrito
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - DNI: {Dni}";
        }

        // Propiedad calculada para el nombre completo
        public string NombreCompleto => $"{Nombre} {Apellido}".Trim();

        // Método para validar el cliente
        public bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Apellido) &&
                   !string.IsNullOrWhiteSpace(Dni) &&
                   Edad >= 0 && Edad <= 150;
        }

        // Método para obtener información completa
        public string InformacionCompleta()
        {
            return $"Cliente: {NombreCompleto}\n" +
                   $"DNI: {Dni}\n" +
                   $"Edad: {Edad}\n" +
                   $"Email: {Email}\n" +
                   $"Teléfono: {Telefono}";
        }
    }
}