using System.Data;

namespace SistemaGestion.Exportadores
{
    public interface IExportacion
    {
        void Exportar(IDataReader reader, string filePath, string query);
    }
}