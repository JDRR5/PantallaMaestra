using System;

namespace SistemaGestion.Estados
{
    public interface IEstado
    {
        string GetTitulo();
        string GetBotonIniciarTexto();
        string GetBotonRegistrarTexto();
        void ProcesarSolicitud(Frm_ProcesarSolicitud context, string username, string password, int? idRol);
    }
}
