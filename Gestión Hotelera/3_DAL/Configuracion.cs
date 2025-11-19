using System;
using System.Configuration;

namespace _3_DAL
{
    public static class Configuracion
    {
        // CONFIGURACIÓN SANTIAGO   
        // Valores por defecto
        private static string _server = "localhost";
        private static string _database = "HotelDB";
        private static string _connectionString = string.Empty;

        static Configuracion()
        {
            CargarConfiguracion();
        }

        public static string Server
        {
            get => _server;
            set
            {
                _server = value;
                ActualizarCadenaConexion();
            }
        }

        public static string Database
        {
            get => _database;
            set
            {
                _database = value;
                ActualizarCadenaConexion();
            }
        }

        public static string Cadena
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    ActualizarCadenaConexion();
                }
                return _connectionString;
            }
        }

        private static void ActualizarCadenaConexion()
        {
            _connectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
        }
        //"data source=(localdb)\\MSSQLLocalDB; initial catalog=HotelDB; integrated security=sspi;";
        public static void CargarConfiguracion()
        {
            try
            {
                // Intenta leer de un archivo de configuración
                string configPath = "conexion.config";
                if (System.IO.File.Exists(configPath))
                {
                    string[] lines = System.IO.File.ReadAllLines(configPath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            if (key.Equals("Server", StringComparison.OrdinalIgnoreCase))
                                Server = value;
                            else if (key.Equals("Database", StringComparison.OrdinalIgnoreCase))
                                Database = value;
                        }
                    }
                }
            }
            catch
            {
                // Si hay error al leer la configuración, usar valores por defecto
                Server = "localhost";
                Database = "HotelDB";
            }
        }
    }
}