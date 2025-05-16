using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SistemaGestion.Exportadores
{
    public class ExportadorSQLite : IDisposable
    {
        // Definición del enum
        public enum FormatoExportacion
        {
            CSV,
            TXT,
            XML,
            JSON
        }

        private readonly string _cadenaConexion;
        private SQLiteConnection _conexion;
        private IExportacion _exportadorActual;

        // Propiedad pública añadida para resolver el error CS1061
        public string ConnectionString => _cadenaConexion;

        public ExportadorSQLite(string rutaBD)
        {
            if (string.IsNullOrWhiteSpace(rutaBD))
                throw new ArgumentException("La ruta de la base de datos no puede estar vacía");

            _cadenaConexion = $"Data Source={rutaBD};Version=3;";

            if (!File.Exists(rutaBD))
                throw new FileNotFoundException("Archivo de base de datos no encontrado", rutaBD);
        }

        public void ExportarDatos(string consulta, string rutaArchivo, FormatoExportacion formato)
        {
            EstablecerExportador(formato);

            try
            {
                using (_conexion = new SQLiteConnection(_cadenaConexion))
                {
                    _conexion.Open();

                    using (var comando = new SQLiteCommand(consulta, _conexion))
                    using (var lector = comando.ExecuteReader())
                    {
                        _exportadorActual.Exportar(lector, rutaArchivo, consulta);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al exportar datos: {ex.Message}", ex);
            }
        }

        private void EstablecerExportador(FormatoExportacion formato)
        {
            switch (formato)
            {
                case FormatoExportacion.CSV:
                    _exportadorActual = new ExportadorCSV();
                    break;
                case FormatoExportacion.TXT:
                    _exportadorActual = new ExportadorTXT();
                    break;
                case FormatoExportacion.XML:
                    _exportadorActual = new ExportadorXML();
                    break;
                case FormatoExportacion.JSON:
                    _exportadorActual = new ExportadorJSON();
                    break;
                default:
                    throw new ArgumentException("Formato de exportación no soportado");
            }
        }

        public void Dispose()
        {
            _conexion?.Dispose();
        }
    }
}