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
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            btnUltimo = new System.Windows.Forms.Button();
            btnSiguiente = new System.Windows.Forms.Button();
            btnAnterior = new System.Windows.Forms.Button();
            btnPrimero = new System.Windows.Forms.Button();
            lblPosicion = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            gestion.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gestion
            // 
            gestion.BackColor = System.Drawing.SystemColors.ControlLight;
            gestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gestion.Controls.Add(lblTotalRegistros);
            gestion.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(16, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(243, 29);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Clientes";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnNuevo);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(912, 91);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(133, 618);
            panel2.TabIndex = 1;
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
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Control;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(btnUltimo);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(btnPrimero);
            panel3.Controls.Add(lblPosicion);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 636);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(912, 73);
            panel3.TabIndex = 2;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 91);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(912, 545);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(17, 40);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(22, 20);
            label8.TabIndex = 13;
            label8.Text = "Id";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(17, 438);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(72, 20);
            label7.TabIndex = 11;
            label7.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(17, 463);
            txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(863, 27);
            txtDireccion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 363);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(17, 388);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(420, 27);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 288);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 20);
            label5.TabIndex = 7;
            label5.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(17, 312);
            txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(420, 27);
            txtTelefono.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 212);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 20);
            label4.TabIndex = 5;
            label4.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(17, 237);
            txtDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(420, 27);
            txtDocumento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(233, 137);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(233, 162);
            txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(420, 27);
            txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 137);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
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
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(gestion);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Frm_Cliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gestión de Clientes";
            gestion.ResumeLayout(false);
            gestion.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel gestion;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
    }
}
