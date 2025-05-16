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
    public partial class Frm_Cliente : Form
    {
        private Usuario _usuarioActual;
        private int _clienteActualIndex = -1;
        private DataTable _clientesDataTable;
        private bool _modoEdicion = false;
        private bool _modoNuevo = false;

        public Frm_Cliente(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            ConfigurarEventos();
            CargarClientes();
            ConfigurarInterfaz();
        }

        private void ConfigurarEventos()
        {
            // Eventos de botones CRUD
            btnNuevo.Click += BtnNuevo_Click;
            btnGuardar.Click += BtnGuardar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            // Eventos de navegación
            btnPrimero.Click += BtnPrimero_Click;
            btnAnterior.Click += BtnAnterior_Click;
            btnSiguiente.Click += BtnSiguiente_Click;
            btnUltimo.Click += BtnUltimo_Click;

            this.FormClosing += Frm_Cliente_FormClosing;
        }

        private void ConfigurarInterfaz()
        {
            habilitarEdicionCampos(false);
            ActualizarBotonesNavegacion();
        }

        private void CargarClientes()
        {
            string consulta = "SELECT id, nombre, apellido, documento, telefono, email, direccion FROM clientes ORDER BY id";
            _clientesDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta);

            if (_clientesDataTable.Rows.Count > 0)
            {
                _clienteActualIndex = 0;
                MostrarClienteActual();
            }
            else
            {
                LimpiarCampos();
                lblTotalRegistros.Text = "Total: 0 registros";
            }
        }

        private void MostrarClienteActual()
        {
            if (_clienteActualIndex >= 0 && _clienteActualIndex < _clientesDataTable.Rows.Count)
            {
                DataRow row = _clientesDataTable.Rows[_clienteActualIndex];
                
                txtId.Text = row["id"].ToString();
                txtNombre.Text = row["nombre"].ToString();
                txtApellido.Text = row["apellido"].ToString();
                txtDocumento.Text = row["documento"].ToString();
                txtTelefono.Text = row["telefono"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtDireccion.Text = row["direccion"].ToString();

                lblPosicion.Text = $"Registro {_clienteActualIndex + 1} de {_clientesDataTable.Rows.Count}";
                lblTotalRegistros.Text = $"Total: {_clientesDataTable.Rows.Count} registros";
                
                ActualizarBotonesNavegacion();
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            lblPosicion.Text = "Sin registros";
        }

        private void habilitarEdicionCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtApellido.ReadOnly = !habilitar;
            txtDocumento.ReadOnly = !habilitar;
            txtTelefono.ReadOnly = !habilitar;
            txtEmail.ReadOnly = !habilitar;
            txtDireccion.ReadOnly = !habilitar;

            // Botones CRUD
            btnNuevo.Enabled = !habilitar;
            btnGuardar.Enabled = habilitar;
            btnEliminar.Enabled = !habilitar && _clientesDataTable.Rows.Count > 0;
            btnCancelar.Enabled = habilitar;

            // Botones de navegación
            btnPrimero.Enabled = !habilitar && _clientesDataTable.Rows.Count > 1;
            btnAnterior.Enabled = !habilitar && _clienteActualIndex > 0;
            btnSiguiente.Enabled = !habilitar && _clienteActualIndex < _clientesDataTable.Rows.Count - 1;
            btnUltimo.Enabled = !habilitar && _clientesDataTable.Rows.Count > 1;
        }

        private void ActualizarBotonesNavegacion()
        {
            bool tieneRegistros = _clientesDataTable.Rows.Count > 0;
            bool noEsElPrimero = _clienteActualIndex > 0;
            bool noEsElUltimo = _clienteActualIndex < _clientesDataTable.Rows.Count - 1;
            bool hayMasDeUno = _clientesDataTable.Rows.Count > 1;

            btnPrimero.Enabled = tieneRegistros && noEsElPrimero && !_modoEdicion;
            btnAnterior.Enabled = tieneRegistros && noEsElPrimero && !_modoEdicion;
            btnSiguiente.Enabled = tieneRegistros && noEsElUltimo && !_modoEdicion;
            btnUltimo.Enabled = tieneRegistros && noEsElUltimo && !_modoEdicion;
            btnEliminar.Enabled = tieneRegistros && !_modoEdicion;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Los campos Nombre, Apellido y Documento son obligatorios.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validacion.ValidarEmail(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El formato del email no es válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar si el documento ya existe (cuando es nuevo o se cambió el documento)
            int idActual = 0;
            if (!_modoNuevo)
            {
                idActual = Convert.ToInt32(_clientesDataTable.Rows[_clienteActualIndex]["id"]);
            }

            string consulta = "SELECT COUNT(*) FROM clientes WHERE documento = @documento AND id <> @id";
            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@documento", txtDocumento.Text.Trim()),
                new SQLiteParameter("@id", idActual)
            };

            int count = Convert.ToInt32(Frm_BasedeDatos.Instance.EjecutarEscalar(consulta, parametros));
            if (count > 0)
            {
                MessageBox.Show("El número de documento ya existe en la base de datos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #region Eventos de Botones CRUD

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _modoEdicion = true;
            _modoNuevo = true;
            LimpiarCampos();
            habilitarEdicionCampos(true);
            txtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (_modoNuevo)
            {
                GuardarNuevoCliente();
            }
            else
            {
                ActualizarClienteActual();
            }

            _modoEdicion = false;
            _modoNuevo = false;
            habilitarEdicionCampos(false);
            CargarClientes();
        }

        private void GuardarNuevoCliente()
        {
            string consulta = @"
                INSERT INTO clientes (nombre, apellido, documento, telefono, email, direccion)
                VALUES (@nombre, @apellido, @documento, @telefono, @email, @direccion)
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@nombre", txtNombre.Text.Trim()),
                new SQLiteParameter("@apellido", txtApellido.Text.Trim()),
                new SQLiteParameter("@documento", txtDocumento.Text.Trim()),
                new SQLiteParameter("@telefono", txtTelefono.Text.Trim()),
                new SQLiteParameter("@email", txtEmail.Text.Trim()),
                new SQLiteParameter("@direccion", txtDireccion.Text.Trim())
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Cliente creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarClienteActual()
        {
            int idCliente = Convert.ToInt32(_clientesDataTable.Rows[_clienteActualIndex]["id"]);
            
            string consulta = @"
                UPDATE clientes 
                SET nombre = @nombre, apellido = @apellido, documento = @documento, 
                    telefono = @telefono, email = @email, direccion = @direccion
                WHERE id = @id
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@nombre", txtNombre.Text.Trim()),
                new SQLiteParameter("@apellido", txtApellido.Text.Trim()),
                new SQLiteParameter("@documento", txtDocumento.Text.Trim()),
                new SQLiteParameter("@telefono", txtTelefono.Text.Trim()),
                new SQLiteParameter("@email", txtEmail.Text.Trim()),
                new SQLiteParameter("@direccion", txtDireccion.Text.Trim()),
                new SQLiteParameter("@id", idCliente)
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Cliente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_clienteActualIndex < 0 || _clienteActualIndex >= _clientesDataTable.Rows.Count)
                return;

            if (MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idCliente = Convert.ToInt32(_clientesDataTable.Rows[_clienteActualIndex]["id"]);
                
                string consulta = "DELETE FROM clientes WHERE id = @id";
                var parametro = new SQLiteParameter("@id", idCliente);

                if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametro))
                {
                    MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            _modoNuevo = false;
            habilitarEdicionCampos(false);
            
            if (_clientesDataTable.Rows.Count > 0)
            {
                MostrarClienteActual();
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
            if (_clientesDataTable.Rows.Count > 0)
            {
                _clienteActualIndex = 0;
                MostrarClienteActual();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_clienteActualIndex > 0)
            {
                _clienteActualIndex--;
                MostrarClienteActual();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_clienteActualIndex < _clientesDataTable.Rows.Count - 1)
            {
                _clienteActualIndex++;
                MostrarClienteActual();
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (_clientesDataTable.Rows.Count > 0)
            {
                _clienteActualIndex = _clientesDataTable.Rows.Count - 1;
                MostrarClienteActual();
            }
        }

        #endregion

        private void Frm_Cliente_FormClosing(object sender, FormClosingEventArgs e)
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

                if (focusedControl is TextBox && _modoEdicion)
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
