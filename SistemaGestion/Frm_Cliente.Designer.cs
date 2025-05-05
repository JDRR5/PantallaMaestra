namespace SistemaGestion.Formularios
{
    partial class Frm_Cliente
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
            gestion = new System.Windows.Forms.Panel();
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
            datos_cliente = new System.Windows.Forms.GroupBox();
            id_cliente = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            direccion = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            email = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            telefono = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            documento = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            apellido = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            nombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            gestion.SuspendLayout();
            pnl_opciones.SuspendLayout();
            pnl_registros.SuspendLayout();
            datos_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // gestion
            // 
            gestion.BackColor = System.Drawing.SystemColors.ControlLight;
            gestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gestion.Controls.Add(lblTotalRegistros);
            gestion.Controls.Add(titulo);
            gestion.Dock = System.Windows.Forms.DockStyle.Top;
            gestion.Location = new System.Drawing.Point(0, 0);
            gestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gestion.Name = "gestion";
            gestion.Size = new System.Drawing.Size(1045, 91);
            gestion.TabIndex = 0;
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
            titulo.Size = new System.Drawing.Size(243, 29);
            titulo.TabIndex = 0;
            titulo.Text = "Gestión de Clientes";
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
            // datos_cliente
            // 
            datos_cliente.Controls.Add(id_cliente);
            datos_cliente.Controls.Add(txtId);
            datos_cliente.Controls.Add(direccion);
            datos_cliente.Controls.Add(txtDireccion);
            datos_cliente.Controls.Add(email);
            datos_cliente.Controls.Add(txtEmail);
            datos_cliente.Controls.Add(telefono);
            datos_cliente.Controls.Add(txtTelefono);
            datos_cliente.Controls.Add(documento);
            datos_cliente.Controls.Add(txtDocumento);
            datos_cliente.Controls.Add(apellido);
            datos_cliente.Controls.Add(txtApellido);
            datos_cliente.Controls.Add(nombre);
            datos_cliente.Controls.Add(txtNombre);
            datos_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            datos_cliente.Location = new System.Drawing.Point(0, 91);
            datos_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            datos_cliente.Name = "datos_cliente";
            datos_cliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            datos_cliente.Size = new System.Drawing.Size(912, 545);
            datos_cliente.TabIndex = 3;
            datos_cliente.TabStop = false;
            datos_cliente.Text = "Datos del Cliente";
            // 
            // id_cliente
            // 
            id_cliente.AutoSize = true;
            id_cliente.Location = new System.Drawing.Point(17, 40);
            id_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_cliente.Name = "id_cliente";
            id_cliente.Size = new System.Drawing.Size(22, 20);
            id_cliente.TabIndex = 13;
            id_cliente.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(17, 65);
            txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(132, 27);
            txtId.TabIndex = 12;
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Location = new System.Drawing.Point(17, 438);
            direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccion.Name = "direccion";
            direccion.Size = new System.Drawing.Size(72, 20);
            direccion.TabIndex = 11;
            direccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(17, 463);
            txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(863, 27);
            txtDireccion.TabIndex = 10;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new System.Drawing.Point(17, 363);
            email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            email.Name = "email";
            email.Size = new System.Drawing.Size(46, 20);
            email.TabIndex = 9;
            email.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(17, 388);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(420, 27);
            txtEmail.TabIndex = 8;
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new System.Drawing.Point(17, 288);
            telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefono.Name = "telefono";
            telefono.Size = new System.Drawing.Size(67, 20);
            telefono.TabIndex = 7;
            telefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(17, 312);
            txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(420, 27);
            txtTelefono.TabIndex = 6;
            // 
            // documento
            // 
            documento.AutoSize = true;
            documento.Location = new System.Drawing.Point(17, 212);
            documento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            documento.Name = "documento";
            documento.Size = new System.Drawing.Size(87, 20);
            documento.TabIndex = 5;
            documento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(17, 237);
            txtDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(420, 27);
            txtDocumento.TabIndex = 4;
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new System.Drawing.Point(233, 137);
            apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellido.Name = "apellido";
            apellido.Size = new System.Drawing.Size(66, 20);
            apellido.TabIndex = 3;
            apellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(233, 162);
            txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(420, 27);
            txtApellido.TabIndex = 2;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new System.Drawing.Point(17, 137);
            nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombre.Name = "nombre";
            nombre.Size = new System.Drawing.Size(64, 20);
            nombre.TabIndex = 1;
            nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(17, 162);
            txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(207, 27);
            txtNombre.TabIndex = 0;
            // 
            // Frm_Cliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1045, 709);
            Controls.Add(datos_cliente);
            Controls.Add(pnl_registros);
            Controls.Add(pnl_opciones);
            Controls.Add(gestion);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Frm_Cliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gestión de Clientes";
            gestion.ResumeLayout(false);
            gestion.PerformLayout();
            pnl_opciones.ResumeLayout(false);
            pnl_registros.ResumeLayout(false);
            pnl_registros.PerformLayout();
            datos_cliente.ResumeLayout(false);
            datos_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel gestion;
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
        private System.Windows.Forms.GroupBox datos_cliente;
        private System.Windows.Forms.Label id_cliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label documento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}
