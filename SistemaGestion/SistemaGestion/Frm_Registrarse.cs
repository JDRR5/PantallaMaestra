using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;
using SistemaGestion.BaseDatos;
using SistemaGestion.Estados;
using SistemaGestion.Helpers;

namespace SistemaGestion.Formularios
{
    /// <summary>
    /// Formulario para el registro e inicio de sesión de usuarios
    /// </summary>
    public partial class Frm_Registrarse : Form
    {
        /// <summary>
        /// Contexto de estado para el patrón State
        /// </summary>
        private Frm_ProcesarSolicitud context;
        
        /// <summary>
        /// Indica si el formulario está en modo registro o inicio de sesión
        /// </summary>
        private bool modoRegistro = false;
        
        /// <summary>
        /// Número máximo de intentos para iniciar sesión
        /// </summary>
        private int maxIntentos = 3;
        
        /// <summary>
        /// Número actual de intentos restantes
        /// </summary>
        private int intentosRestantes = 3;
        
        // Posiciones originales de los controles
        private Point btnIniciarOriginalPos;
        private Point btnRegistrarOriginalPos;
        private Point btnCancelarOriginalPos;
        private int alturaOriginalFormulario;

        /// <summary>
        /// Constructor de Frm_Registrarse
        /// </summary>
        public Frm_Registrarse()
        {
            try 
            {
                InitializeComponent();
                alturaOriginalFormulario = this.Height;

                // Cargar el número máximo de intentos desde la configuración
                string maxIntentosConfig = ConfigurationManager.AppSettings["MaxLoginAttempts"];
                if (!string.IsNullOrEmpty(maxIntentosConfig) && int.TryParse(maxIntentosConfig, out int configValue))
                {
                    maxIntentos = configValue;
                }
                intentosRestantes = maxIntentos;
                
                // Actualiza el texto del contador de intentos
                ActualizarContadorIntentos();

                // Inicializa el contexto del patrón State
                context = new Frm_ProcesarSolicitud(this);
                
                // Guarda las posiciones originales de los botones
                btnIniciarOriginalPos = btnIniciar.Location;
                btnRegistrarOriginalPos = btnRegistrar.Location;
                btnCancelarOriginalPos = btnCancelar.Location;
                
                // Asigna los manejadores de eventos
                btnIniciar.Click += BtnIniciar_Click;     
                btnRegistrar.Click += BtnRegistrar_Click; 
                btnCancelar.Click += BtnCancelar_Click;   

                // Carga los roles disponibles
                CargarRoles();

                // Actualiza la interfaz según el estado actual
                ActualizarInterfazDesdeContext();
                
                // Aplica efecto de animación al cargar el formulario
                AnimacionUI.EfectoFadeIn(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Actualiza el texto del contador de intentos
        /// </summary>
        private void ActualizarContadorIntentos()
        {
            lblIntentosRestantes.Text = $"Intentos restantes: {intentosRestantes}";
            
            // Cambia el color según la cantidad de intentos
            if (intentosRestantes == 1)
            {
                lblIntentosRestantes.ForeColor = Color.Red;
                lblIntentosRestantes.Font = new Font(lblIntentosRestantes.Font, FontStyle.Bold);
            }
            else if (intentosRestantes == 2)
            {
                lblIntentosRestantes.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblIntentosRestantes.ForeColor = Color.Maroon;
                lblIntentosRestantes.Font = new Font(lblIntentosRestantes.Font, FontStyle.Regular);
            }
        }
        
        /// <summary>
        /// Actualiza el texto del contador de intentos con un valor específico
        /// </summary>
        /// <param name="nuevoValor">Nuevo valor de intentos restantes</param>
        public void ActualizarContadorIntentos(int nuevoValor)
        {
            intentosRestantes = nuevoValor;
            ActualizarContadorIntentos();
        }

        /// <summary>
        /// Carga los roles disponibles en el combo box desde la base de datos
        /// </summary>
        private void CargarRoles()
        {
            using (var conexion = Frm_BasedeDatos.Instance.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new SQLiteCommand("SELECT id, nombre FROM roles ORDER BY id", conexion))
                    {
                        var dt = new DataTable();
                        var adapter = new SQLiteDataAdapter(cmd);
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            cmbRol.DisplayMember = "nombre";
                            cmbRol.ValueMember = "id";
                            cmbRol.DataSource = dt;
                            cmbRol.SelectedIndex = -1; 
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron roles en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Crear los roles por defecto si la tabla no existe
                    try
                    {
                        CrearRolesPorDefecto();
                        CargarRoles(); // Intentar cargar de nuevo
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show($"No se pudieron crear los roles por defecto: {ex2.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Crea roles predeterminados en caso de que no existan
        /// </summary>
        private void CrearRolesPorDefecto()
        {
            string crearTablaRoles = @"
                CREATE TABLE IF NOT EXISTS roles (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nombre TEXT NOT NULL UNIQUE
                )";

            string crearTablaUsuarios = @"
                CREATE TABLE IF NOT EXISTS usuarios (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL UNIQUE,
                    password TEXT NOT NULL,
                    id_rol INTEGER NOT NULL,
                    FOREIGN KEY (id_rol) REFERENCES roles(id)
                )";

            string insertarRoles = @"
                INSERT OR IGNORE INTO roles (id, nombre) VALUES (1, 'Administrador');
                INSERT OR IGNORE INTO roles (id, nombre) VALUES (2, 'Vendedor');
                INSERT OR IGNORE INTO roles (id, nombre) VALUES (3, 'Almacenista');
            ";

            string crearUsuariosDefecto = @"
                INSERT OR IGNORE INTO usuarios (username, password, id_rol) 
                VALUES ('admin', 'admin123', 1);
                INSERT OR IGNORE INTO usuarios (username, password, id_rol) 
                VALUES ('vendedor', 'vendedor123', 2);
                INSERT OR IGNORE INTO usuarios (username, password, id_rol) 
                VALUES ('almacenista', 'almacen123', 3)
            ";

            using (var conexion = Frm_BasedeDatos.Instance.CrearConexion())
            {
                conexion.Open();
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        ExecuteNonQuery(conexion, crearTablaRoles);
                        ExecuteNonQuery(conexion, crearTablaUsuarios);
                        ExecuteNonQuery(conexion, insertarRoles);
                        ExecuteNonQuery(conexion, crearUsuariosDefecto);
                        
                        transaccion.Commit();
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Método auxiliar para ejecutar comandos SQL no-query
        /// </summary>
        private void ExecuteNonQuery(SQLiteConnection conexion, string sql)
        {
            using (var cmd = new SQLiteCommand(sql, conexion))
            {
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza la interfaz del formulario basándose en el estado actual
        /// </summary>
        public void ActualizarInterfazDesdeContext()
        {
            try
            {
                string tituloActual = context.GetTitulo();
                modoRegistro = (tituloActual == "Registro de Usuario");
                
                lblTitulo.Text = tituloActual;
                
                btnIniciar.Text = context.GetBotonIniciarTexto();
                btnRegistrar.Text = context.GetBotonRegistrarTexto();
                btnCancelar.Text = modoRegistro ? "Cancelar" : "Salir";
                
                lblRol.Visible = modoRegistro;
                cmbRol.Visible = modoRegistro;
                
                // Asegurar que el label de intentos sea visible en modo Login
                lblIntentosRestantes.Visible = !modoRegistro;
                
                SuspendLayout();

                if (modoRegistro)
                {
                    this.Height = alturaOriginalFormulario + 120;
                    
                    int buttonY = cmbRol.Bottom + 20;
                    
                    // Los botones deben estar alineados verticalmente para evitar superposiciones
                    btnIniciar.Location = new Point(btnIniciarOriginalPos.X, buttonY);
                    btnRegistrar.Location = new Point(btnRegistrarOriginalPos.X, buttonY); 
                    btnCancelar.Location = new Point(btnCancelarOriginalPos.X, buttonY);
                }
                else
                {
                    this.Height = alturaOriginalFormulario;
                    
                    btnIniciar.Location = btnIniciarOriginalPos;
                    btnRegistrar.Location = btnRegistrarOriginalPos;
                    btnCancelar.Location = btnCancelarOriginalPos;
                    
                    // Asegurarse que los intentos estén actualizados
                    ActualizarContadorIntentos();
                }
                
                btnIniciar.Visible = true;
                btnRegistrar.Visible = true;
                btnCancelar.Visible = true;

                ResumeLayout(true);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la interfaz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Manejador del evento Click del botón Iniciar
        /// </summary>
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            ProcesarAccionPrincipal();
        }
        
        /// <summary>
        /// Manejador del evento Click del botón Registrar
        /// </summary>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            CambiarModo();
        }
        
        /// <summary>
        /// Manejador del evento Click del botón Cancelar/Salir
        /// </summary>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (modoRegistro)
            {
                CambiarModo(); // Volver al modo de inicio de sesión
            }
            else
            {
                if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Procesa la acción principal según el modo actual (Iniciar sesión o Registrar)
        /// </summary>
        private void ProcesarAccionPrincipal()
        {
            try
            {
                string username = txtUsuario.Text.Trim();
                string password = txtContraseña.Text.Trim();
                int? idRol = null;

                if (modoRegistro)
                {
                    if (cmbRol.SelectedIndex == -1 || cmbRol.SelectedValue == null)
                    {
                        MessageBox.Show("Debe seleccionar un rol para registrarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    idRol = Convert.ToInt32(cmbRol.SelectedValue);
                }
                context.ProcesarSolicitud(username, password, idRol);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la acción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cambia entre el modo de inicio de sesión y registro
        /// </summary>
        private void CambiarModo()
        {
            try
            {
                if (!modoRegistro)
                {
                    // Cambiar a modo registro
                    context.CambiarEstado(new Frm_EstadoRegistro());
                    
                    // Ocultar temporalmente el indicador de intentos
                    lblIntentosRestantes.Visible = false;
                }
                else
                {
                    // Volver a modo inicio de sesión
                    context.CambiarEstado(new Frm_ValidarCredenciales());
                    
                    // Mostrar el indicador de intentos
                    lblIntentosRestantes.Visible = true;
                    
                    // Reiniciar el contador de intentos
                    intentosRestantes = maxIntentos;
                    ActualizarContadorIntentos();
                }
                
                // No se limpian los campos al cambiar de modo para mantener los datos
                // Solo resetear el rol si estamos cambiando de registro a login
                if (modoRegistro && cmbRol.Visible)
                    cmbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar de modo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sobrecarga del método ProcessCmdKey para permitir navegación con tecla Enter
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                var focusedControl = this.ActiveControl;

                if (focusedControl is TextBox)
                {
                    this.SelectNextControl(focusedControl, true, true, true, true);
                    return true;
                }
                else if (focusedControl is Button || focusedControl == cmbRol)
                {
                    ProcesarAccionPrincipal();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Muestra el formulario y lo inicializa en modo de inicio de sesión
        /// </summary>
        public void MostrarFormulario()
        {
            try
            {
                txtUsuario.Clear();
                txtContraseña.Clear();
                context.CambiarEstado(new Frm_ValidarCredenciales());
                
                this.Show();
                AnimacionUI.EfectoFadeIn(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}