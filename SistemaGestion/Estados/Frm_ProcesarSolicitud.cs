using System;
using System.Windows.Forms;
using SistemaGestion.Formularios;
using SistemaGestion.Modelos;

namespace SistemaGestion.Estados
{
    public class Frm_ProcesarSolicitud
    {
        private IEstado _estadoActual;
        private Frm_ValidarCredenciales _estadoValidarCredenciales;
        private readonly Frm_Registrarse _formularioRegistro;
        public Usuario UsuarioActual { get; set; }

        public Frm_ProcesarSolicitud(Frm_Registrarse formularioRegistro)
        {
            _formularioRegistro = formularioRegistro;
            
            // Crear instancia del estado de validación
            _estadoValidarCredenciales = new Frm_ValidarCredenciales();
            
            // Suscribirse al evento de cambio de intentos
            _estadoValidarCredenciales.OnIntentosRestantesActualizados += ActualizarContadorIntentos;
            
            // Establecer estado inicial
            _estadoActual = _estadoValidarCredenciales;
            
            // Inicializar el contador de intentos
            ActualizarContadorIntentos(_estadoValidarCredenciales.GetIntentosRestantes());
        }
        
        /// <summary>
        /// Actualiza el contador de intentos en el formulario
        /// </summary>
        private void ActualizarContadorIntentos(int intentosRestantes)
        {
            try
            {
                // Invocamos el método en el hilo de la UI si es necesario
                if (_formularioRegistro.InvokeRequired)
                {
                    _formularioRegistro.Invoke(new Action<int>(ActualizarContadorIntentos), intentosRestantes);
                    return;
                }
                
                // Actualizamos el contador en el formulario
                _formularioRegistro.ActualizarContadorIntentos(intentosRestantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar contador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarEstado(IEstado nuevoEstado)
        {
            // Si estamos cambiando desde el estado de validación, desuscribirse del evento
            if (_estadoActual is Frm_ValidarCredenciales validarCredenciales)
            {
                validarCredenciales.OnIntentosRestantesActualizados -= ActualizarContadorIntentos;
            }
            
            _estadoActual = nuevoEstado;
            
            // Si estamos cambiando al estado de validación, suscribirse al evento
            if (_estadoActual is Frm_ValidarCredenciales nuevoValidarCredenciales)
            {
                _estadoValidarCredenciales = nuevoValidarCredenciales;
                _estadoValidarCredenciales.OnIntentosRestantesActualizados += ActualizarContadorIntentos;
                
                // Actualizar contador con el valor inicial
                ActualizarContadorIntentos(_estadoValidarCredenciales.GetIntentosRestantes());
            }
            
            _formularioRegistro.ActualizarInterfazDesdeContext();
        }

        public void ProcesarSolicitud(string username, string password, int? idRol)
        {
            _estadoActual.ProcesarSolicitud(this, username, password, idRol);
        }

        public string GetTitulo()
        {
            return _estadoActual.GetTitulo();
        }

        public string GetBotonIniciarTexto()
        {
            return _estadoActual.GetBotonIniciarTexto();
        }

        public string GetBotonRegistrarTexto()
        {
            return _estadoActual.GetBotonRegistrarTexto();
        }

        public Frm_Registrarse GetFormularioRegistro()
        {
            return _formularioRegistro;
        }
    }
}
