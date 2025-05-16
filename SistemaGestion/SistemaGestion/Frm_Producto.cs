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
    public partial class Frm_Producto : Form
    {
        private Usuario _usuarioActual;
        private int _productoActualIndex = -1;
        private DataTable _productosDataTable;
        private bool _modoEdicion = false;
        private bool _modoNuevo = false;

        public Frm_Producto(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario;
            ConfigurarEventos();
            CargarProductos();
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

            this.FormClosing += Frm_Producto_FormClosing;
            this.Load += Frm_Producto_Load;
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            AnimacionUI.EfectoFadeIn(this);
        }

        private void ConfigurarInterfaz()
        {
            habilitarEdicionCampos(false);
            ActualizarBotonesNavegacion();
        }

        private void CargarProductos()
        {
            string consulta = "SELECT id, codigo, nombre, descripcion, precio, stock FROM productos ORDER BY id";
            _productosDataTable = Frm_BasedeDatos.Instance.EjecutarConsulta(consulta);

            if (_productosDataTable.Rows.Count > 0)
            {
                _productoActualIndex = 0;
                MostrarProductoActual();
            }
            else
            {
                LimpiarCampos();
                lblTotalRegistros.Text = "Total: 0 registros";
            }
        }

        private void MostrarProductoActual()
        {
            if (_productoActualIndex >= 0 && _productoActualIndex < _productosDataTable.Rows.Count)
            {
                DataRow row = _productosDataTable.Rows[_productoActualIndex];
                
                txtId.Text = row["id"].ToString();
                txtCodigo.Text = row["codigo"].ToString();
                txtNombre.Text = row["nombre"].ToString();
                txtDescripcion.Text = row["descripcion"].ToString();
                txtPrecio.Text = row["precio"].ToString();
                txtStock.Text = row["stock"].ToString();

                lblPosicion.Text = $"Registro {_productoActualIndex + 1} de {_productosDataTable.Rows.Count}";
                lblTotalRegistros.Text = $"Total: {_productosDataTable.Rows.Count} registros";
                
                ActualizarBotonesNavegacion();
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            lblPosicion.Text = "Sin registros";
        }

        private void habilitarEdicionCampos(bool habilitar)
        {
            txtCodigo.ReadOnly = !habilitar;
            txtNombre.ReadOnly = !habilitar;
            txtDescripcion.ReadOnly = !habilitar;
            txtPrecio.ReadOnly = !habilitar;
            txtStock.ReadOnly = !habilitar;

            // Botones CRUD
            btnNuevo.Enabled = !habilitar;
            btnGuardar.Enabled = habilitar;
            btnEliminar.Enabled = !habilitar && _productosDataTable.Rows.Count > 0;
            btnCancelar.Enabled = habilitar;

            // Botones de navegación
            btnPrimero.Enabled = !habilitar && _productosDataTable.Rows.Count > 1;
            btnAnterior.Enabled = !habilitar && _productoActualIndex > 0;
            btnSiguiente.Enabled = !habilitar && _productoActualIndex < _productosDataTable.Rows.Count - 1;
            btnUltimo.Enabled = !habilitar && _productosDataTable.Rows.Count > 1;
        }

        private void ActualizarBotonesNavegacion()
        {
            bool tieneRegistros = _productosDataTable.Rows.Count > 0;
            bool noEsElPrimero = _productoActualIndex > 0;
            bool noEsElUltimo = _productoActualIndex < _productosDataTable.Rows.Count - 1;
            bool hayMasDeUno = _productosDataTable.Rows.Count > 1;

            btnPrimero.Enabled = tieneRegistros && noEsElPrimero && !_modoEdicion;
            btnAnterior.Enabled = tieneRegistros && noEsElPrimero && !_modoEdicion;
            btnSiguiente.Enabled = tieneRegistros && noEsElUltimo && !_modoEdicion;
            btnUltimo.Enabled = tieneRegistros && noEsElUltimo && !_modoEdicion;
            btnEliminar.Enabled = tieneRegistros && !_modoEdicion;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Los campos Código, Nombre, Precio y Stock son obligatorios.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validacion.EsNumeroDecimalPositivo(txtPrecio.Text))
            {
                MessageBox.Show("El precio debe ser un número decimal positivo.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Validacion.EsEnteroPositivo(txtStock.Text))
            {
                MessageBox.Show("El stock debe ser un número entero positivo.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar si el código ya existe (cuando es nuevo o se cambió el código)
            int idActual = 0;
            if (!_modoNuevo)
            {
                idActual = Convert.ToInt32(_productosDataTable.Rows[_productoActualIndex]["id"]);
            }

            string consulta = "SELECT COUNT(*) FROM productos WHERE codigo = @codigo AND id <> @id";
            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@codigo", txtCodigo.Text.Trim()),
                new SQLiteParameter("@id", idActual)
            };

            int count = Convert.ToInt32(Frm_BasedeDatos.Instance.EjecutarEscalar(consulta, parametros));
            if (count > 0)
            {
                MessageBox.Show("El código ya existe en la base de datos.",
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
            txtCodigo.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (_modoNuevo)
            {
                GuardarNuevoProducto();
            }
            else
            {
                ActualizarProductoActual();
            }

            _modoEdicion = false;
            _modoNuevo = false;
            habilitarEdicionCampos(false);
            CargarProductos();
        }

        private void GuardarNuevoProducto()
        {
            string consulta = @"
                INSERT INTO productos (codigo, nombre, descripcion, precio, stock)
                VALUES (@codigo, @nombre, @descripcion, @precio, @stock)
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@codigo", txtCodigo.Text.Trim()),
                new SQLiteParameter("@nombre", txtNombre.Text.Trim()),
                new SQLiteParameter("@descripcion", txtDescripcion.Text.Trim()),
                new SQLiteParameter("@precio", Convert.ToDecimal(txtPrecio.Text.Trim())),
                new SQLiteParameter("@stock", Convert.ToInt32(txtStock.Text.Trim()))
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Producto creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al crear el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProductoActual()
        {
            int idProducto = Convert.ToInt32(_productosDataTable.Rows[_productoActualIndex]["id"]);
            
            string consulta = @"
                UPDATE productos 
                SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion, 
                    precio = @precio, stock = @stock
                WHERE id = @id
            ";

            var parametros = new SQLiteParameter[]
            {
                new SQLiteParameter("@codigo", txtCodigo.Text.Trim()),
                new SQLiteParameter("@nombre", txtNombre.Text.Trim()),
                new SQLiteParameter("@descripcion", txtDescripcion.Text.Trim()),
                new SQLiteParameter("@precio", Convert.ToDecimal(txtPrecio.Text.Trim())),
                new SQLiteParameter("@stock", Convert.ToInt32(txtStock.Text.Trim())),
                new SQLiteParameter("@id", idProducto)
            };

            if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametros))
            {
                MessageBox.Show("Producto actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_productoActualIndex < 0 || _productoActualIndex >= _productosDataTable.Rows.Count)
                return;

            if (MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idProducto = Convert.ToInt32(_productosDataTable.Rows[_productoActualIndex]["id"]);
                
                string consulta = "DELETE FROM productos WHERE id = @id";
                var parametro = new SQLiteParameter("@id", idProducto);

                if (Frm_BasedeDatos.Instance.EjecutarComando(consulta, parametro))
                {
                    MessageBox.Show("Producto eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            _modoNuevo = false;
            habilitarEdicionCampos(false);
            
            if (_productosDataTable.Rows.Count > 0)
            {
                MostrarProductoActual();
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
            if (_productosDataTable.Rows.Count > 0)
            {
                _productoActualIndex = 0;
                MostrarProductoActual();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_productoActualIndex > 0)
            {
                _productoActualIndex--;
                MostrarProductoActual();
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_productoActualIndex < _productosDataTable.Rows.Count - 1)
            {
                _productoActualIndex++;
                MostrarProductoActual();
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (_productosDataTable.Rows.Count > 0)
            {
                _productoActualIndex = _productosDataTable.Rows.Count - 1;
                MostrarProductoActual();
            }
        }

        #endregion

        private void Frm_Producto_FormClosing(object sender, FormClosingEventArgs e)
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
