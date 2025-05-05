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
    public partial class Frm_Abonos : Form
    {
        private Usuario _usuarioActual;
        private DataTable _clientesDataTable;
        private DataTable _productosDataTable;
        private DataTable _abonosDataTable;
        private int _clienteSeleccionadoId = -1;

        public Frm_Abonos(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            ConfigurarEventos();
            ConfigurarInterfaz();
            CargarClientes();
        }

        private void ConfigurarEventos()
        {
            // Eventos de botones
            btnGuardar.Click += BtnGuardar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnNuevo.Click += BtnNuevo_Click;
            btnCancelar.Click += BtnCancelar_Click;

            // Eventos de listas y combos
            cmbClientes.SelectedIndexChanged += CmbClientes_SelectedIndexChanged;
            cmbProductos.SelectedIndexChanged += CmbProductos_SelectedIndexChanged;

            this.Load += Frm_Abonos_Load;
            this.FormClosing += Frm_Abonos_FormClosing;
        }

        private void Frm_Abonos_Load(object sender, EventArgs e)
        {
            AnimacionUI.EfectoFadeIn(this);
        }

        private void ConfigurarInterfaz()
        {
            // Configurar las columnas del grid
            dgvAbonos.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id";
            colId.HeaderText = "ID";
            colId.Width = 50;
            dgvAbonos.Columns.Add(colId);

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.DataPropertyName = "fecha";
            colFecha.HeaderText = "Fecha";
            colFecha.Width = 100;
            dgvAbonos.Columns.Add(colFecha);

            DataGridViewTextBoxColumn colProducto = new DataGridViewTextBoxColumn();
            colProducto.DataPropertyName = "producto_nombre";
            colProducto.HeaderText = "Producto";
            colProducto.Width = 150;
            dgvAbonos.Columns.Add(colProducto);

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.DataPropertyName = "monto";
            colMonto.HeaderText = "Monto";
            colMonto.Width = 100;
            colMonto.DefaultCellStyle.Format = "C2";
            dgvAbonos.Columns.Add(colMonto);

            DataGridViewTextBoxColumn colObservaciones = new DataGridViewTextBoxColumn();
            colObservaciones.DataPropertyName = "observaciones";
            colObservaciones.HeaderText = "Observaciones";
            colObservaciones.Width = 200;
            dgvAbonos.Columns.Add(colObservaciones);

            // Inicializar el formulario
            HabilitarControles(false);
        }

        private void CargarClientes()
        {
            string consulta = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM clientes ORDER BY nombre";
            _clientesDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta);

            cmbClientes.DataSource = null;
            if (_clientesDataTable.Rows.Count > 0)
            {
                cmbClientes.DisplayMember = "nombre_completo";
                cmbClientes.ValueMember = "id";
                cmbClientes.DataSource = _clientesDataTable;
                cmbClientes.SelectedIndex = -1;
            }
        }

        private void CargarProductos()
        {
            string consulta = "SELECT id, nombre, precio FROM productos ORDER BY nombre";
            _productosDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta);

            cmbProductos.DataSource = null;
            if (_productosDataTable.Rows.Count > 0)
            {
                cmbProductos.DisplayMember = "nombre";
                cmbProductos.ValueMember = "id";
                cmbProductos.DataSource = _productosDataTable;
                cmbProductos.SelectedIndex = -1;
            }
        }

        private void CargarAbonos(int clienteId)
        {
            string consulta = @"
                SELECT a.id, a.fecha, p.nombre AS producto_nombre, a.monto, a.observaciones
                FROM abonos a
                JOIN productos p ON a.id_producto = p.id
                WHERE a.id_cliente = @clienteId
                ORDER BY a.fecha DESC
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@clienteId", clienteId)
            };

            _abonosDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta, parametros);
            dgvAbonos.DataSource = _abonosDataTable;

            // Actualizar el total
            ActualizarTotalAbonos();
        }

        private void ActualizarTotalAbonos()
        {
            decimal total = 0;
            
            if (_abonosDataTable != null && _abonosDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in _abonosDataTable.Rows)
                {
                    if (row["monto"] != DBNull.Value)
                    {
                        total += Convert.ToDecimal(row["monto"]);
                    }
                }
            }
            
            lblTotalAbonos.Text = $"Total abonado: {total:C2}";
        }

        private void HabilitarControles(bool habilitar)
        {
            dtpFecha.Enabled = habilitar;
            cmbProductos.Enabled = habilitar;
            txtMonto.ReadOnly = !habilitar;
            txtObservaciones.ReadOnly = !habilitar;
            
            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
            btnNuevo.Enabled = !habilitar && _clienteSeleccionadoId > 0;
            btnEliminar.Enabled = !habilitar && dgvAbonos.SelectedRows.Count > 0;
            
            cmbClientes.Enabled = !habilitar;
            dgvAbonos.Enabled = !habilitar;
        }

        private void LimpiarControlesDetalle()
        {
            dtpFecha.Value = DateTime.Now;
            cmbProductos.SelectedIndex = -1;
            txtMonto.Text = "0.00";
            txtObservaciones.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            if (cmbProductos.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Validación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (!Validacion.EsNumeroDecimalPositivo(txtMonto.Text))
            {
                MessageBox.Show("El monto debe ser un número decimal positivo.", 
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        #region Eventos de Controles

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue != null)
            {
                _clienteSeleccionadoId = Convert.ToInt32(cmbClientes.SelectedValue);
                CargarProductos();
                CargarAbonos(_clienteSeleccionadoId);
                btnNuevo.Enabled = true;
                
                // Mostrar información del cliente
                MostrarInfoCliente(_clienteSeleccionadoId);
            }
            else
            {
                _clienteSeleccionadoId = -1;
                dgvAbonos.DataSource = null;
                btnNuevo.Enabled = false;
                lblInfoCliente.Text = "Seleccione un cliente para ver sus datos";
            }
        }

        private void MostrarInfoCliente(int clienteId)
        {
            string consulta = @"
                SELECT nombre, apellido, documento, telefono, email
                FROM clientes
                WHERE id = @clienteId
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@clienteId", clienteId)
            };

            DataTable dtCliente = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta, parametros);
            
            if (dtCliente.Rows.Count > 0)
            {
                DataRow cliente = dtCliente.Rows[0];
                string infoCliente = $"Cliente: {cliente["nombre"]} {cliente["apellido"]} | " +
                                    $"Doc: {cliente["documento"]} | " +
                                    $"Tel: {cliente["telefono"]} | " +
                                    $"Email: {cliente["email"]}";
                
                lblInfoCliente.Text = infoCliente;
            }
        }

        private void CmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedValue != null && _productosDataTable != null)
            {
                foreach (DataRow row in _productosDataTable.Rows)
                {
                    if (Convert.ToInt32(row["id"]) == Convert.ToInt32(cmbProductos.SelectedValue))
                    {
                        decimal precio = Convert.ToDecimal(row["precio"]);
                        txtMonto.Text = precio.ToString("0.00");
                        break;
                    }
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControlesDetalle();
            HabilitarControles(true);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int idProducto = Convert.ToInt32(cmbProductos.SelectedValue);
            decimal monto = Convert.ToDecimal(txtMonto.Text);
            string observaciones = txtObservaciones.Text.Trim();
            DateTime fecha = dtpFecha.Value;

            string consulta = @"
                INSERT INTO abonos (id_cliente, id_producto, fecha, monto, observaciones)
                VALUES (@idCliente, @idProducto, @fecha, @monto, @observaciones)
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@idCliente", _clienteSeleccionadoId),
                new SQLiteParameter("@idProducto", idProducto),
                new SQLiteParameter("@fecha", fecha.ToString("yyyy-MM-dd")),
                new SQLiteParameter("@monto", monto),
                new SQLiteParameter("@observaciones", observaciones)
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Abono registrado correctamente.", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                HabilitarControles(false);
                CargarAbonos(_clienteSeleccionadoId);
            }
            else
            {
                MessageBox.Show("Error al registrar el abono.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAbonos.SelectedRows.Count == 0) return;

            int idAbono = Convert.ToInt32(dgvAbonos.SelectedRows[0].Cells["id"].Value);
            
            if (MessageBox.Show("¿Está seguro que desea eliminar este abono?", 
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            string consulta = "DELETE FROM abonos WHERE id = @idAbono";
            
            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@idAbono", idAbono)
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Abono eliminado correctamente.", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                CargarAbonos(_clienteSeleccionadoId);
            }
            else
            {
                MessageBox.Show("Error al eliminar el abono.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
        }

        private void Frm_Abonos_FormClosing(object sender, FormClosingEventArgs e)
        {
            // No hacemos nada especial al cerrar
        }

        #endregion
    }
}
