using System;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;

namespace SistemaGestion.Exportadores
{
    public class ExportadorXML : IExportacion
    {
        public void Exportar(IDataReader lector, string rutaArchivo, string consulta)
        {
            var configuracion = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                Encoding = Encoding.UTF8,
                NewLineOnAttributes = false
            };

            using (var escritor = XmlWriter.Create(rutaArchivo, configuracion))
            {
                escritor.WriteStartDocument();
                escritor.WriteStartElement("DatosExportados");

                // Metadatos
                escritor.WriteStartElement("Metadatos");
                escritor.WriteElementString("FechaExportacion", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
                escritor.WriteElementString("Origen", "SQLite");
                escritor.WriteElementString("Consulta", consulta);
                escritor.WriteEndElement();

                // Estructura
                escritor.WriteStartElement("Estructura");
                for (int i = 0; i < lector.FieldCount; i++)
                {
                    escritor.WriteStartElement("Campo");
                    escritor.WriteAttributeString("Nombre", lector.GetName(i));
                    escritor.WriteAttributeString("Tipo", lector.GetFieldType(i).Name);
                    escritor.WriteAttributeString("Posicion", i.ToString());
                    escritor.WriteEndElement();
                }
                escritor.WriteEndElement();

                // Datos
                escritor.WriteStartElement("Registros");
                while (lector.Read())
                {
                    escritor.WriteStartElement("Registro");
                    for (int i = 0; i < lector.FieldCount; i++)
                    {
                        escritor.WriteStartElement(lector.GetName(i));
                        escritor.WriteValue(lector.IsDBNull(i) ? "NULO" : lector[i].ToString());
                        escritor.WriteEndElement();
                    }
                    escritor.WriteEndElement();
                }
                escritor.WriteEndElement();

                escritor.WriteEndElement();
                escritor.WriteEndDocument();
            }
        }
    }
}