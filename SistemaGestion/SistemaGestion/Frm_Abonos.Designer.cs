namespace SistemaGestion.Formularios
{
    partial class Frm_Abonos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lblTotalAbonos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.gbDetalleAbono = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            this.dgvAbonos = new System.Windows.Forms.DataGridView();
            this.lblClienteSeleccion = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.pnl_titulo.SuspendLayout();
            this.pnl_opciones.SuspendLayout();
            this.pnl_contenido.SuspendLayout();
            this.gbDetalleAbono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_titulo.Controls.Add(this.lblTotalAbonos);
            this.pnl_titulo.Controls.Add(this.lblTitulo);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(984, 60);
            this.pnl_titulo.TabIndex = 0;
            // 
            // lblTotalAbonos
            // 
            this.lblTotalAbonos.AutoSize = true;
            this.lblTotalAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAbonos.Location = new System.Drawing.Point(17, 34);
            this.lblTotalAbonos.Name = "lblTotalAbonos";
            this.lblTotalAbonos.Size = new System.Drawing.Size(124, 16);
            this.lblTotalAbonos.TabIndex = 1;
            this.lblTotalAbonos.Text = "Total abonado: $0.00";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Pagos/Abonos";
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_opciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_opciones.Controls.Add(this.btnCancelar);
            this.pnl_opciones.Controls.Add(this.btnEliminar);
            this.pnl_opciones.Controls.Add(this.btnGuardar);
            this.pnl_opciones.Controls.Add(this.btnNuevo);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_opciones.Location = new System.Drawing.Point(884, 60);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(100, 501);
            this.pnl_opciones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 41);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 41);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 41);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.Controls.Add(this.gbDetalleAbono);
            this.pnl_contenido.Controls.Add(this.lblInfoCliente);
            this.pnl_contenido.Controls.Add(this.dgvAbonos);
            this.pnl_contenido.Controls.Add(this.lblClienteSeleccion);
            this.pnl_contenido.Controls.Add(this.cmbClientes);
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(0, 60);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(884, 501);
            this.pnl_contenido.TabIndex = 2;
            // 
            // gbDetalleAbono
            // 
            this.gbDetalleAbono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleAbono.Controls.Add(this.lblObservaciones);
            this.gbDetalleAbono.Controls.Add(this.txtObservaciones);
            this.gbDetalleAbono.Controls.Add(this.lblMonto);
            this.gbDetalleAbono.Controls.Add(this.txtMonto);
            this.gbDetalleAbono.Controls.Add(this.lblFecha);
            this.gbDetalleAbono.Controls.Add(this.dtpFecha);
            this.gbDetalleAbono.Controls.Add(this.lblProducto);
            this.gbDetalleAbono.Controls.Add(this.cmbProductos);
            this.gbDetalleAbono.Location = new System.Drawing.Point(12, 363);
            this.gbDetalleAbono.Name = "gbDetalleAbono";
            this.gbDetalleAbono.Size = new System.Drawing.Size(859, 126);
            this.gbDetalleAbono.TabIndex = 4;
            this.gbDetalleAbono.TabStop = false;
            this.gbDetalleAbono.Text = "Detalle del Abono";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 76);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 7;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(104, 73);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(731, 47);
            this.txtObservaciones.TabIndex = 6;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(395, 31);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(438, 28);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(558, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(601, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(113, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(20, 31);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(76, 28);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(298, 21);
            this.cmbProductos.TabIndex = 0;
            // 
            // lblInfoCliente
            // 
            this.lblInfoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCliente.Location = new System.Drawing.Point(12, 41);
            this.lblInfoCliente.Name = "lblInfoCliente";
            this.lblInfoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.lblInfoCliente.Size = new System.Drawing.Size(859, 26);
            this.lblInfoCliente.TabIndex = 3;
            this.lblInfoCliente.Text = "Seleccione un cliente para ver sus datos";
            // 
            // dgvAbonos
            // 
            this.dgvAbonos.AllowUserToAddRows = false;
            this.dgvAbonos.AllowUserToDeleteRows = false;
            this.dgvAbonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonos.Location = new System.Drawing.Point(12, 79);
            this.dgvAbonos.Name = "dgvAbonos";
            this.dgvAbonos.ReadOnly = true;
            this.dgvAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonos.Size = new System.Drawing.Size(859, 274);
            this.dgvAbonos.TabIndex = 2;
            // 
            // lblClienteSeleccion
            // 
            this.lblClienteSeleccion.AutoSize = true;
            this.lblClienteSeleccion.Location = new System.Drawing.Point(13, 14);
            this.lblClienteSeleccion.Name = "lblClienteSeleccion";
            this.lblClienteSeleccion.Size = new System.Drawing.Size(105, 13);
            this.lblClienteSeleccion.TabIndex = 1;
            this.lblClienteSeleccion.Text = "Seleccione un cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(124, 11);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(298, 21);
            this.cmbClientes.TabIndex = 0;
            // 
            // Frm_Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_contenido);
            this.Controls.Add(this.pnl_opciones);
            this.Controls.Add(this.pnl_titulo);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Frm_Abonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Pagos y Abonos";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.pnl_opciones.ResumeLayout(false);
            this.pnl_contenido.ResumeLayout(false);
            this.pnl_contenido.PerformLayout();
            this.gbDetalleAbono.ResumeLayout(false);
            this.gbDetalleAbono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnl_contenido;
        private System.Windows.Forms.Label lblClienteSeleccion;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DataGridView dgvAbonos;
        private System.Windows.Forms.Label lblInfoCliente;
        private System.Windows.Forms.GroupBox gbDetalleAbono;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTotalAbonos;
    }
}
