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
            pnl_titulo = new System.Windows.Forms.Panel();
            lblTotalRegistros = new System.Windows.Forms.Label();
            titulo = new System.Windows.Forms.Label();
            pnl_opciones = new System.Windows.Forms.Panel();
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            pnl_registros = new System.Windows.Forms.Panel();
            btnUltimo = new System.Windows.Forms.Button();
            btnSiguiente = new System.Windows.Forms.Button();
            btnAnterior = new System.Windows.Forms.Button();
            btnPrimero = new System.Windows.Forms.Button();
            lblPosicion = new System.Windows.Forms.Label();
            datos_producto = new System.Windows.Forms.GroupBox();
            stock_producto = new System.Windows.Forms.Label();
            txtStock = new System.Windows.Forms.TextBox();
            precio_producto = new System.Windows.Forms.Label();
            txtPrecio = new System.Windows.Forms.TextBox();
            descripcion_producto = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            nombre_producto = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            codigo_producto = new System.Windows.Forms.Label();
            txtCodigo = new System.Windows.Forms.TextBox();
            Id_producto = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            pnl_titulo.SuspendLayout();
            pnl_opciones.SuspendLayout();
            pnl_registros.SuspendLayout();
            datos_producto.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_titulo
            // 
            pnl_titulo.BackColor = System.Drawing.SystemColors.ControlLight;
            pnl_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_titulo.Controls.Add(lblTotalRegistros);
            pnl_titulo.Controls.Add(titulo);
            pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_titulo.Location = new System.Drawing.Point(0, 0);
            pnl_titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnl_titulo.Name = "pnl_titulo";
            pnl_titulo.Size = new System.Drawing.Size(1045, 91);
            pnl_titulo.TabIndex = 0;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalRegistros.Location = new System.Drawing.Point(17, 54);
            lblTotalRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new System.Drawing.Size(136, 20);
            lblTotalRegistros.TabIndex = 1;
            lblTotalRegistros.Text = "Total: 0 registros";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            titulo.Location = new System.Drawing.Point(16, 14);
            titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titulo.Name = "titulo";
            titulo.Size = new System.Drawing.Size(265, 29);
            titulo.TabIndex = 0;
            titulo.Text = "Gestión de Productos";
            // 
            // pnl_opciones
            // 
            pnl_opciones.BackColor = System.Drawing.SystemColors.Control;
            pnl_opciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_opciones.Controls.Add(btnCancelar);
            pnl_opciones.Controls.Add(btnEliminar);
            pnl_opciones.Controls.Add(btnGuardar);
            pnl_opciones.Controls.Add(btnNuevo);
            pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            pnl_opciones.Location = new System.Drawing.Point(912, 91);
            pnl_opciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnl_opciones.Name = "pnl_opciones";
            pnl_opciones.Size = new System.Drawing.Size(133, 618);
            pnl_opciones.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(15, 198);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 51);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(15, 138);
            btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(100, 51);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(15, 78);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 51);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(15, 18);
            btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(100, 51);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // pnl_registros
            // 
            pnl_registros.BackColor = System.Drawing.SystemColors.Control;
            pnl_registros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_registros.Controls.Add(btnUltimo);
            pnl_registros.Controls.Add(btnSiguiente);
            pnl_registros.Controls.Add(btnAnterior);
            pnl_registros.Controls.Add(btnPrimero);
            pnl_registros.Controls.Add(lblPosicion);
            pnl_registros.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_registros.Location = new System.Drawing.Point(0, 636);
            pnl_registros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnl_registros.Name = "pnl_registros";
            pnl_registros.Size = new System.Drawing.Size(912, 73);
            pnl_registros.TabIndex = 2;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnUltimo.Location = new System.Drawing.Point(802, 15);
            btnUltimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new System.Drawing.Size(80, 43);
            btnUltimo.TabIndex = 4;
            btnUltimo.Text = ">>";
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSiguiente.Location = new System.Drawing.Point(714, 15);
            btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new System.Drawing.Size(80, 43);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAnterior.Location = new System.Drawing.Point(626, 15);
            btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new System.Drawing.Size(80, 43);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPrimero.Location = new System.Drawing.Point(538, 15);
            btnPrimero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new System.Drawing.Size(80, 43);
            btnPrimero.TabIndex = 1;
            btnPrimero.Text = "<<";
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // lblPosicion
            // 
            lblPosicion.AutoSize = true;
            lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPosicion.Location = new System.Drawing.Point(17, 25);
            lblPosicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new System.Drawing.Size(108, 20);
            lblPosicion.TabIndex = 0;
            lblPosicion.Text = "Sin registros.";
            // 
            // datos_producto
            // 
            datos_producto.Controls.Add(stock_producto);
            datos_producto.Controls.Add(txtStock);
            datos_producto.Controls.Add(precio_producto);
            datos_producto.Controls.Add(txtPrecio);
            datos_producto.Controls.Add(descripcion_producto);
            datos_producto.Controls.Add(txtDescripcion);
            datos_producto.Controls.Add(nombre_producto);
            datos_producto.Controls.Add(txtNombre);
            datos_producto.Controls.Add(codigo_producto);
            datos_producto.Controls.Add(txtCodigo);
            datos_producto.Controls.Add(Id_producto);
            datos_producto.Controls.Add(txtId);
            datos_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            datos_producto.Location = new System.Drawing.Point(0, 91);
            datos_producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            datos_producto.Name = "datos_producto";
            datos_producto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            datos_producto.Size = new System.Drawing.Size(912, 545);
            datos_producto.TabIndex = 3;
            datos_producto.TabStop = false;
            datos_producto.Text = "Datos del Producto";
            // 
            // stock_producto
            // 
            stock_producto.AutoSize = true;
            stock_producto.Location = new System.Drawing.Point(233, 288);
            stock_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stock_producto.Name = "stock_producto";
            stock_producto.Size = new System.Drawing.Size(45, 20);
            stock_producto.TabIndex = 11;
            stock_producto.Text = "Unidades";
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(233, 312);
            txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new System.Drawing.Size(207, 27);
            txtStock.TabIndex = 10;
            // 
            // precio_producto
            // 
            precio_producto.AutoSize = true;
            precio_producto.Location = new System.Drawing.Point(17, 288);
            precio_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precio_producto.Name = "precio_producto";
            precio_producto.Size = new System.Drawing.Size(50, 20);
            precio_producto.TabIndex = 9;
            precio_producto.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(17, 312);
            txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(207, 27);
            txtPrecio.TabIndex = 8;
            // 
            // descripcion_producto
            // 
            descripcion_producto.AutoSize = true;
            descripcion_producto.Location = new System.Drawing.Point(17, 212);
            descripcion_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcion_producto.Name = "descripcion_producto";
            descripcion_producto.Size = new System.Drawing.Size(87, 20);
            descripcion_producto.TabIndex = 7;
            descripcion_producto.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(17, 237);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(863, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // nombre_producto
            // 
            nombre_producto.AutoSize = true;
            nombre_producto.Location = new System.Drawing.Point(233, 137);
            nombre_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombre_producto.Name = "nombre_producto";
            nombre_producto.Size = new System.Drawing.Size(64, 20);
            nombre_producto.TabIndex = 5;
            nombre_producto.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(233, 162);
            txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(647, 27);
            txtNombre.TabIndex = 4;
            // 
            // codigo_producto
            // 
            codigo_producto.AutoSize = true;
            codigo_producto.Location = new System.Drawing.Point(17, 137);
            codigo_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_producto.Name = "codigo_producto";
            codigo_producto.Size = new System.Drawing.Size(58, 20);
            codigo_producto.TabIndex = 3;
            codigo_producto.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(17, 162);
            txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(207, 27);
            txtCodigo.TabIndex = 2;
            // 
            // Id_producto
            // 
            Id_producto.AutoSize = true;
            Id_producto.Location = new System.Drawing.Point(17, 40);
            Id_producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Id_producto.Name = "Id_producto";
            Id_producto.Size = new System.Drawing.Size(22, 20);
            Id_producto.TabIndex = 1;
            Id_producto.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(17, 65);
            txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(132, 27);
            txtId.TabIndex = 0;
            // 
            // Frm_Producto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1045, 709);
            Controls.Add(datos_producto);
            Controls.Add(pnl_registros);
            Controls.Add(pnl_opciones);
            Controls.Add(pnl_titulo);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Frm_Producto";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gestión de Productos";
            pnl_titulo.ResumeLayout(false);
            pnl_titulo.PerformLayout();
            pnl_opciones.ResumeLayout(false);
            pnl_registros.ResumeLayout(false);
            pnl_registros.PerformLayout();
            datos_producto.ResumeLayout(false);
            datos_producto.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label titulo;
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
        private System.Windows.Forms.GroupBox datos_producto;
        private System.Windows.Forms.Label stock_producto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label precio_producto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label descripcion_producto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label nombre_producto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label codigo_producto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label Id_producto;
        private System.Windows.Forms.TextBox txtId;
    }
}
