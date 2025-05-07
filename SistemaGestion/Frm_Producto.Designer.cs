namespace SistemaGestion.Formularios
{
    partial class Frm_Producto
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
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnl_registros = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.grp_datosProducto = new System.Windows.Forms.GroupBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Id_producto = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnl_titulo.SuspendLayout();
            this.pnl_opciones.SuspendLayout();
            this.pnl_registros.SuspendLayout();
            this.grp_datosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_titulo.Controls.Add(this.lblTotalRegistros);
            this.pnl_titulo.Controls.Add(this.lbl_titulo);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1045, 73);
            this.pnl_titulo.TabIndex = 0;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(17, 43);
            this.lblTotalRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(136, 20);
            this.lblTotalRegistros.TabIndex = 1;
            this.lblTotalRegistros.Text = "Total: 0 registros";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(16, 11);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(265, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestión de Productos";
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
            this.pnl_opciones.Location = new System.Drawing.Point(912, 73);
            this.pnl_opciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(133, 494);
            this.pnl_opciones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 158);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(15, 110);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 41);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 62);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(15, 14);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 41);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // pnl_registros
            // 
            this.pnl_registros.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_registros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_registros.Controls.Add(this.btnUltimo);
            this.pnl_registros.Controls.Add(this.btnSiguiente);
            this.pnl_registros.Controls.Add(this.btnAnterior);
            this.pnl_registros.Controls.Add(this.btnPrimero);
            this.pnl_registros.Controls.Add(this.lblPosicion);
            this.pnl_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_registros.Location = new System.Drawing.Point(0, 508);
            this.pnl_registros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_registros.Name = "pnl_registros";
            this.pnl_registros.Size = new System.Drawing.Size(912, 59);
            this.pnl_registros.TabIndex = 2;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUltimo.Location = new System.Drawing.Point(802, 12);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(80, 34);
            this.btnUltimo.TabIndex = 4;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Location = new System.Drawing.Point(714, 12);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(80, 34);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Location = new System.Drawing.Point(626, 12);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(80, 34);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrimero.Location = new System.Drawing.Point(538, 12);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(80, 34);
            this.btnPrimero.TabIndex = 1;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(17, 20);
            this.lblPosicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(108, 20);
            this.lblPosicion.TabIndex = 0;
            this.lblPosicion.Text = "Sin registros.";
            // 
            // grp_datosProducto
            // 
            this.grp_datosProducto.Controls.Add(this.lbl_stock);
            this.grp_datosProducto.Controls.Add(this.txtStock);
            this.grp_datosProducto.Controls.Add(this.lbl_precio);
            this.grp_datosProducto.Controls.Add(this.txtPrecio);
            this.grp_datosProducto.Controls.Add(this.lbl_descripcion);
            this.grp_datosProducto.Controls.Add(this.txtDescripcion);
            this.grp_datosProducto.Controls.Add(this.lbl_nombre);
            this.grp_datosProducto.Controls.Add(this.txtNombre);
            this.grp_datosProducto.Controls.Add(this.lbl_codigo);
            this.grp_datosProducto.Controls.Add(this.txtCodigo);
            this.grp_datosProducto.Controls.Add(this.Id_producto);
            this.grp_datosProducto.Controls.Add(this.txtId);
            this.grp_datosProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_datosProducto.Location = new System.Drawing.Point(0, 73);
            this.grp_datosProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_datosProducto.Name = "grp_datosProducto";
            this.grp_datosProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_datosProducto.Size = new System.Drawing.Size(912, 435);
            this.grp_datosProducto.TabIndex = 3;
            this.grp_datosProducto.TabStop = false;
            this.grp_datosProducto.Text = "Datos del Producto";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(233, 230);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(66, 16);
            this.lbl_stock.TabIndex = 11;
            this.lbl_stock.Text = "Unidades";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(233, 250);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(207, 22);
            this.txtStock.TabIndex = 10;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(17, 230);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(46, 16);
            this.lbl_precio.TabIndex = 9;
            this.lbl_precio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(17, 250);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(207, 22);
            this.txtPrecio.TabIndex = 8;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(17, 170);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(79, 16);
            this.lbl_descripcion.TabIndex = 7;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(17, 190);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(863, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(233, 110);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_nombre.TabIndex = 5;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 130);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(647, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(17, 110);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(51, 16);
            this.lbl_codigo.TabIndex = 3;
            this.lbl_codigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 130);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(207, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // Id_producto
            // 
            this.Id_producto.AutoSize = true;
            this.Id_producto.Location = new System.Drawing.Point(17, 32);
            this.Id_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.Size = new System.Drawing.Size(18, 16);
            this.Id_producto.TabIndex = 1;
            this.Id_producto.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(17, 52);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 0;
            // 
            // Frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.grp_datosProducto);
            this.Controls.Add(this.pnl_registros);
            this.Controls.Add(this.pnl_opciones);
            this.Controls.Add(this.pnl_titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Productos";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.pnl_opciones.ResumeLayout(false);
            this.pnl_registros.ResumeLayout(false);
            this.pnl_registros.PerformLayout();
            this.grp_datosProducto.ResumeLayout(false);
            this.grp_datosProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnl_registros;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.GroupBox grp_datosProducto;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label Id_producto;
        private System.Windows.Forms.TextBox txtId;
    }
}
