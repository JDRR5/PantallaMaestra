using System.Data;
using System.IO;
using System.Text;

namespace SistemaGestion.Exportadores
{
    public class ExportadorTXT : IExportacion
    {
        public void Exportar(IDataReader lector, string rutaArchivo, string consulta)
        {
            using (var escritor = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
            {
                // Calcular anchos de columnas
                int[] anchos = new int[lector.FieldCount];
                string[] encabezados = new string[lector.FieldCount];

                for (int i = 0; i < lector.FieldCount; i++)
                {
                    encabezados[i] = lector.GetName(i);
                    anchos[i] = encabezados[i].Length;
                }

                // Almacenar datos y calcular anchos máximos
                var todosDatos = new System.Collections.Generic.List<string[]>();
                while (lector.Read())
                {
                    var fila = new string[lector.FieldCount];
                    for (int i = 0; i < lector.FieldCount; i++)
                    {
                        fila[i] = lector.IsDBNull(i) ? "NULO" : lector[i].ToString();
                        if (fila[i].Length > anchos[i])
                            anchos[i] = fila[i].Length;
                    }
                    todosDatos.Add(fila);
                }

                // Escribir encabezados
                for (int i = 0; i < lector.FieldCount; i++)
                {
                    escritor.Write(encabezados[i].PadRight(anchos[i] + 2));
                }
                escritor.WriteLine();

                // Escribir separador
                for (int i = 0; i < lector.FieldCount; i++)
                {
                    escritor.Write(new string('-', anchos[i]).PadRight(anchos[i] + 2));
                }
                escritor.WriteLine();

                // Escribir datos
                foreach (var fila in todosDatos)
                {
                    for (int i = 0; i < fila.Length; i++)
                    {
                        escritor.Write(fila[i].PadRight(anchos[i] + 2));
                    }
                    escritor.WriteLine();
                }
            }
        }
    }
}