using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using SistemaGestion.BaseDatos;
using SistemaGestion.Modelos;
using SistemaGestion.Helpers;

namespace SistemaGestion.Formularios
{
    public partial class Frm_Roles : Form
    {
        private Usuario _usuarioActual;
        private int _usuarioActualIndex = -1;
        private DataTable _usuariosDataTable;
        private DataTable _rolesDataTable;
        private bool _modoEdicion = false;

        public Frm_Roles(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            ConfigurarEventos();
            CargarRoles();
            CargarUsuarios();
            ConfigurarInterfaz();
        }

        private void ConfigurarEventos()
        {
            // Eventos de botones CRUD
            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            // Eventos de navegación
            btnPrimero.Click += BtnPrimero_Click;
            btnAnterior.Click += BtnAnterior_Click;
            btnSiguiente.Click += BtnSiguiente_Click;
            btnUltimo.Click += BtnUltimo_Click;

            this.FormClosing += Frm_Roles_FormClosing;
            this.Load += Frm_Roles_Load;
        }

        private void Frm_Roles_Load(object sender, EventArgs e)
        {
            AnimacionUI.EfectoFadeIn(this);
        }

        private void ConfigurarInterfaz()
        {
            habilitarEdicionCampos(false);
            ActualizarBotonesNavegacion();
        }

        private void CargarRoles()
        {
            string consulta = "SELECT id, nombre FROM roles ORDER BY id";
            _rolesDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta);

            cmbRol.DataSource = null;
            if (_rolesDataTable.Rows.Count > 0)
            {
                cmbRol.DisplayMember = "nombre";
                cmbRol.ValueMember = "id";
                cmbRol.DataSource = _rolesDataTable;
                cmbRol.SelectedIndex = -1;
            }
        }

        private void CargarUsuarios()
        {
            string consulta = @"
                SELECT u.id, u.username, u.id_rol, r.nombre as rol_nombre
                FROM usuarios u
                JOIN roles r ON u.id_rol = r.id
                ORDER BY u.id
            ";
            _usuariosDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta);

            if (_usuariosDataTable.Rows.Count > 0)
            {
                _usuarioActualIndex = 0;
                MostrarUsuarioActual();
            }
            else
            {
                LimpiarCampos();
                lblTotalRegistros.Text = "Total: 0 registros";
            }
        }

        private void MostrarUsuarioActual()
        {
            if (_usuarioActualIndex >= 0 && _usuarioActualIndex < _usuariosDataTable.Rows.Count)
            {
                DataRow row = _usuariosDataTable.Rows[_usuarioActualIndex];
                
                txtId.Text = row["id"].ToString();
                txtUsuario.Text = row["username"].ToString();
                
                int idRol = Convert.ToInt32(row["id_rol"]);
                string rolNombre = row["rol_nombre"].ToString();
                
                lblRolActual.Text = $"Rol actual: {rolNombre}";
                
                // Buscar el índice del rol en el combobox
                for (int i = 0; i < cmbRol.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)cmbRol.Items[i];
                    if (Convert.ToInt32(drv["id"]) == idRol)
                    {
                        cmbRol.SelectedIndex = i;
                        break;
                    }
                }

                lblPosicion.Text = $"Registro {_usuarioActualIndex + 1} de {_usuariosDataTable.Rows.Count}";
                lblTotalRegistros.Text = $"Total: {_usuariosDataTable.Rows.Count} registros";
                
                // Verificar permisos para edición
                VerificarPermisosEdicion();
                
                ActualizarBotonesNavegacion();
            }
        }

        private void VerificarPermisosEdicion()
        {
            // No se puede cambiar el rol si:
            // 1. El usuario es administrador y no es el usuario actual
            // 2. El usuario actual es administrador

            bool esAdmin = false;
            bool esUsuarioActual = false;

            if (_usuarioActualIndex >= 0 && _usuarioActualIndex < _usuariosDataTable.Rows.Count)
            {
                DataRow row = _usuariosDataTable.Rows[_usuarioActualIndex];
                int idRol = Convert.ToInt32(row["id_rol"]);
                int idUsuario = Convert.ToInt32(row["id"]);
                
                esAdmin = (idRol == 1); // Rol 1 es Administrador
                esUsuarioActual = (idUsuario == _usuarioActual.Id);
            }

            // El administrador no puede cambiar roles de otros administradores ni su propio rol
            bool puedeEditar = !esAdmin;

            btnGuardar.Enabled = puedeEditar;
            btnCancelar.Enabled = _modoEdicion;
            
            // Información para el usuario
            if (esAdmin)
            {
                if (esUsuarioActual)
                {
                    lblInfoEdicion.Text = "No puedes cambiar tu propio rol de administrador.";
                }
                else
                {
                    lblInfoEdicion.Text = "No puedes cambiar el rol de otro administrador.";
                }
                lblInfoEdicion.ForeColor = Color.Red;
            }
            else
            {
                lblInfoEdicion.Text = "Selecciona un nuevo rol y haz clic en Guardar para cambiar.";
                lblInfoEdicion.ForeColor = SystemColors.ControlText;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            lblRolActual.Text = "Rol actual: N/A";
            cmbRol.SelectedIndex = -1;
            lblPosicion.Text = "Sin registros";
        }

        private void habilitarEdicionCampos(bool habilitar)
        {
            _modoEdicion = habilitar;
            cmbRol.Enabled = habilitar;

            btnGuardar.Enabled = habilitar && btnGuardar.Enabled;
            btnCancelar.Enabled = habilitar;

            // Botones de navegación
            btnPrimero.Enabled = !habilitar && _usuariosDataTable.Rows.Count > 1;
            btnAnterior.Enabled = !habilitar && _usuarioActualIndex > 0;
            btnSiguiente.Enabled = !habilitar && _usuarioActualIndex < _usuariosDataTable.Rows.Count - 1;
            btnUltimo.Enabled = !habilitar && _usuariosDataTable.Rows.Count > 1;
        }

        private void ActualizarBotonesNavegacion()
        {
            bool tieneRegistros = _usuariosDataTable.Rows.Count > 0;
            bool noEsElPrimero = _usuarioActualIndex > 0;
            bool noEsElUltimo = _usuarioActualIndex < _usuariosDataTable.Rows.Count - 1;
            bool hayMasDeUno = _usuariosDataTable.Rows.Count > 1;

            btnPrimero.Enabled = tieneRegistros && noEsElPrimero && !_modoEdicion;
            btnAnterior.Enabled = tieneRegistros && noEsElPrimero && !_modoEdicion;
            btnSiguiente.Enabled = tieneRegistros && noEsElUltimo && !_modoEdicion;
            btnUltimo.Enabled = tieneRegistros && noEsElUltimo && !_modoEdicion;
        }

        private bool ValidarCampos()
        {
            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        #region Eventos de Botones CRUD

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (VerificarCambioPermitido())
            {
                ActualizarRolUsuario();
                habilitarEdicionCampos(false);
                CargarUsuarios();
            }
        }

        private bool VerificarCambioPermitido()
        {
            if (_usuarioActualIndex < 0 || _usuarioActualIndex >= _usuariosDataTable.Rows.Count)
                return false;

            DataRow row = _usuariosDataTable.Rows[_usuarioActualIndex];
            int idUsuario = Convert.ToInt32(row["id"]);
            int idRolActual = Convert.ToInt32(row["id_rol"]);
            int idRolNuevo = Convert.ToInt32(cmbRol.SelectedValue);

            // El usuario no puede cambiar su propio rol
            if (idUsuario == _usuarioActual.Id)
            {
                MessageBox.Show("No puedes cambiar tu propio rol.", "Operación no permitida", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // El administrador no puede cambiar roles de otros administradores
            if (idRolActual == 1) // 1 = Administrador
            {
                MessageBox.Show("No puedes cambiar el rol de un administrador.", "Operación no permitida", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Confirmar el cambio de rol
            string nombreRolNuevo = ((DataRowView)cmbRol.SelectedItem)["nombre"].ToString();
            return MessageBox.Show($"¿Está seguro que desea cambiar el rol del usuario a {nombreRolNuevo}?", 
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void ActualizarRolUsuario()
        {
            int idUsuario = Convert.ToInt32(_usuariosDataTable.Rows[_usuarioActualIndex]["id"]);
            int idRol = Convert.ToInt32(cmbRol.SelectedValue);
            
            string consulta = "UPDATE usuarios SET id_rol = @idRol WHERE id = @idUsuario";
            
            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@idRol", idRol),
                new SQLiteParameter("@idUsuario", idUsuario)
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Rol actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            habilitarEdicionCampos(false);
            
            if (_usuariosDataTable.Rows.Count > 0)
            {
                MostrarUsuarioActual();
            }
            else
            {
                LimpiarCampos();
            }
        }

        #endregion

        #region Eventos de Navegación

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            if (_usuariosDataTable.Rows.Count > 0)
            {
                _usuarioActualIndex = 0;
                MostrarUsuarioActual();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_usuarioActualIndex > 0)
            {
                _usuarioActualIndex--;
                MostrarUsuarioActual();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_usuarioActualIndex < _usuariosDataTable.Rows.Count - 1)
            {
                _usuarioActualIndex++;
                MostrarUsuarioActual();
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (_usuariosDataTable.Rows.Count > 0)
            {
                _usuarioActualIndex = _usuariosDataTable.Rows.Count - 1;
                MostrarUsuarioActual();
            }
        }

        #endregion

        private void Frm_Roles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_modoEdicion)
            {
                if (MessageBox.Show("Hay cambios sin guardar. ¿Está seguro que desea salir?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                var focusedControl = this.ActiveControl;

                if (focusedControl is ComboBox && _modoEdicion)
                {
                    this.SelectNextControl(focusedControl, true, true, true, true);
                    return true;
                }
                else if (focusedControl is Button)
                {
                    ((Button)focusedControl).PerformClick();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
