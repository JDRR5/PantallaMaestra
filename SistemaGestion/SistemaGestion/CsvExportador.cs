using System.Data;
using System.IO;
using System.Text;

namespace SistemaGestion.Exportadores
{
    public class ExportadorCSV : IExportacion
    {
        public void Exportar(IDataReader reader, string filePath, string query)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Escribir encabezados
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    writer.Write(EscapeCSV(reader.GetName(i)));
                    if (i < reader.FieldCount - 1) writer.Write(",");
                }
                writer.WriteLine();

                // Escribir datos
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        writer.Write(EscapeCSV(reader.IsDBNull(i) ? string.Empty : reader[i].ToString()));
                        if (i < reader.FieldCount - 1) writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }

        private string EscapeCSV(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
                return $"\"{value.Replace("\"", "\"\"")}\"";

            return value;
        }
    }
}