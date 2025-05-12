using System;
using System.Data;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace SistemaGestion.Exportadores
{
    public class ExportadorJSON : IExportacion
    {
        public void Exportar(IDataReader lector, string rutaArchivo, string consulta)
        {
            var tablaDatos = new DataTable();
            tablaDatos.Load(lector);

            var configuracion = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "yyyy-MM-ddTHH:mm:ss"
            };

            var datosJSON = new
            {
                Metadatos = new
                {
                    FechaExportacion = DateTime.Now.ToString("o"),
                    Origen = "SQLite",
                    Consulta = consulta,
                    TotalRegistros = tablaDatos.Rows.Count
                },
                Datos = tablaDatos
            };

            File.WriteAllText(rutaArchivo, JsonConvert.SerializeObject(datosJSON, configuracion), Encoding.UTF8);
        }
    }
}