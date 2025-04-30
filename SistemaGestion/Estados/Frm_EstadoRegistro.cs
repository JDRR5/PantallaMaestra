using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using SistemaGestion.BaseDatos;

namespace SistemaGestion.Estados
{
    public class Frm_EstadoRegistro : IEstado
    {
        public string GetTitulo()
        {
            return "Registro de Usuario";
        }

        public string GetBotonIniciarTexto()
        {
            return "Crear Usuario";
        }

        public string GetBotonRegistrarTexto()
        {
            return "Volver a Inicio";
        }

        public void ProcesarSolicitud(Frm_ProcesarSolicitud context, string username, string password, int? idRol)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || !idRol.HasValue)
            {
                MessageBox.Show("Por favor, complete todos los campos incluido el rol.", 
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", 
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UsuarioExiste(username))
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", 
                    "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RegistrarUsuario(username, password, idRol.Value))
            {
                MessageBox.Show("Usuario registrado correctamente. Ahora puede iniciar sesión.", 
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                context.CambiarEstado(new Frm_ValidarCredenciales());
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario. Por favor, inténtelo de nuevo.", 
                    "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioExiste(string username)
        {
            try
            {
                string consulta = "SELECT COUNT(*) FROM usuarios WHERE username = @username";
                var parametro = new SQLiteParameter("@username", username);
                
                object resultado = Frm_BasedeDatos.Instance.EjecutarEscalar(consulta, parametro);
                
                return Convert.ToInt32(resultado) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar usuario: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Asumir que existe para evitar registro duplicado en caso de error
            }
        }

        private bool RegistrarUsuario(string username, string password, int idRol)
        {
            try
            {
                string comando = "INSERT INTO usuarios (username, password, id_rol) VALUES (@username, @password, @idRol)";
                
                var parametros = new SQLiteParameter[]
                {
                    new SQLiteParameter("@username", username),
                    new SQLiteParameter("@password", password),
                    new SQLiteParameter("@idRol", idRol)
                };
                
                return Frm_BasedeDatos.Instance.EjecutarComando(comando, parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
