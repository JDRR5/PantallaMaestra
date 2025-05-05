using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;
using SistemaGestion.BaseDatos;
using SistemaGestion.Formularios;
using SistemaGestion.Modelos;

namespace SistemaGestion.Estados
{
    public class Frm_ValidarCredenciales : IEstado
    {
        // Delegado para actualizar el contador de intentos en el formulario
        public delegate void ActualizarIntentosRestantesHandler(int intentos);
        
        // Evento para notificar al formulario que hubo un cambio de intentos
        public event ActualizarIntentosRestantesHandler OnIntentosRestantesActualizados;
        
        // El número máximo de intentos se lee del app.config (por defecto 3)
        private int maxIntentos = 3;
        private int intentosRestantes = 3;

        public Frm_ValidarCredenciales()
        {
            // Intentar leer el valor de maxIntentos desde la configuración
            try
            {
                string maxIntentosConfig = ConfigurationManager.AppSettings["MaxLoginAttempts"];
                if (!string.IsNullOrEmpty(maxIntentosConfig) && int.TryParse(maxIntentosConfig, out int configValue))
                {
                    maxIntentos = configValue;
                }
            }
            catch (Exception)
            {
                // Si hay algún error, mantener el valor por defecto
                maxIntentos = 3;
            }
            
            // Inicializar los intentos restantes
            intentosRestantes = maxIntentos;
        }

        public string GetTitulo()
        {
            return "Inicio de Sesión";
        }

        public string GetBotonIniciarTexto()
        {
            return "Iniciar Sesión";
        }

        public string GetBotonRegistrarTexto()
        {
            return "Registrarse";
        }
        
        public int GetIntentosRestantes()
        {
            return intentosRestantes;
        }
        
        public int GetMaxIntentos()
        {
            return maxIntentos;
        }
        
        public void ReiniciarIntentos()
        {
            intentosRestantes = maxIntentos;
            // Notificar al formulario del cambio
            OnIntentosRestantesActualizados?.Invoke(intentosRestantes);
        }

        public void ProcesarSolicitud(Frm_ProcesarSolicitud context, string username, string password, int? idRol)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCredenciales(username, password, out Usuario usuario))
            {
                // Credenciales válidas, restaurar intentos para la próxima vez
                ReiniciarIntentos();
                
                context.UsuarioActual = usuario;
                context.GetFormularioRegistro().Hide();
                
                Frm_Principal formPrincipal = new Frm_Principal(usuario);
                formPrincipal.FormClosed += (s, args) => context.GetFormularioRegistro().MostrarFormulario();
                formPrincipal.Show();
            }
            else
            {
                intentosRestantes--;
                
                // Notificar al formulario del cambio en los intentos restantes
                OnIntentosRestantesActualizados?.Invoke(intentosRestantes);
                
                if (intentosRestantes > 0)
                {
                    MessageBox.Show($"Credenciales incorrectas. Intentos restantes: {intentosRestantes}", 
                        "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos. La aplicación se cerrará.", 
                        "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private bool ValidarCredenciales(string username, string password, out Usuario usuario)
        {
            usuario = null;
            
            try
            {
                string consulta = @"
                    SELECT u.id, u.username, u.id_rol, r.nombre as rol_nombre 
                    FROM usuarios u
                    JOIN roles r ON u.id_rol = r.id
                    WHERE u.username = @username AND u.password = @password
                ";

                var parametros = new SQLiteParameter[]
                {
                    new SQLiteParameter("@username", username),
                    new SQLiteParameter("@password", password)
                };

                DataTable resultado = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta, parametros);

                if (resultado.Rows.Count > 0)
                {
                    DataRow row = resultado.Rows[0];
                    usuario = new Usuario
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Username = row["username"].ToString(),
                        IdRol = Convert.ToInt32(row["id_rol"]),
                        NombreRol = row["rol_nombre"].ToString()
                    };
                    return true;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar credenciales: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
