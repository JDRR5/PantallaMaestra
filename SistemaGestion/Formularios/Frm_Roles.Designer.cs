namespace SistemaGestion.Formularios
{
    partial class Frm_Roles
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
            gestion_roles = new System.Windows.Forms.Panel();
            lblTotalRegistros = new System.Windows.Forms.Label();
            lbl_titulo = new System.Windows.Forms.Label();
            panel_guardar = new System.Windows.Forms.Panel();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            pnl_registros = new System.Windows.Forms.Panel();
            btnUltimo = new System.Windows.Forms.Button();
            btnSiguiente = new System.Windows.Forms.Button();
            btnAnterior = new System.Windows.Forms.Button();
            btnPrimero = new System.Windows.Forms.Button();
            lblPosicion = new System.Windows.Forms.Label();
            asignacion_roles = new System.Windows.Forms.GroupBox();
            lblInfoEdicion = new System.Windows.Forms.Label();
            lblRolActual = new System.Windows.Forms.Label();
            cmbRol = new System.Windows.Forms.ComboBox();
            lbl_nuevor_rol = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.TextBox();
            lbl_usuario = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lbl_id = new System.Windows.Forms.Label();
            gestion_roles.SuspendLayout();
            panel_guardar.SuspendLayout();
            pnl_registros.SuspendLayout();
            asignacion_roles.SuspendLayout();
            SuspendLayout();
            // 
            // gestion_roles
            // 
            gestion_roles.BackColor = System.Drawing.SystemColors.ControlLight;
            gestion_roles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gestion_roles.Controls.Add(lblTotalRegistros);
            gestion_roles.Controls.Add(lbl_titulo);
            gestion_roles.Dock = System.Windows.Forms.DockStyle.Top;
            gestion_roles.Location = new System.Drawing.Point(0, 0);
            gestion_roles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gestion_roles.Name = "gestion_roles";
            gestion_roles.Size = new System.Drawing.Size(912, 91);
            gestion_roles.TabIndex = 0;
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
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbl_titulo.Location = new System.Drawing.Point(16, 14);
            lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(215, 29);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Gestión de Roles";
            // 
            // panel_guardar
            // 
            panel_guardar.BackColor = System.Drawing.SystemColors.Control;
            panel_guardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel_guardar.Controls.Add(btnCancelar);
            panel_guardar.Controls.Add(btnGuardar);
            panel_guardar.Dock = System.Windows.Forms.DockStyle.Right;
            panel_guardar.Location = new System.Drawing.Point(779, 91);
            panel_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel_guardar.Name = "panel_guardar";
            panel_guardar.Size = new System.Drawing.Size(133, 464);
            panel_guardar.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(15, 78);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 51);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(15, 18);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(100, 51);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
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
            pnl_registros.Location = new System.Drawing.Point(0, 482);
            pnl_registros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnl_registros.Name = "pnl_registros";
            pnl_registros.Size = new System.Drawing.Size(779, 73);
            pnl_registros.TabIndex = 2;
            // 
            // btnUltimo
            // 
            btnUltimo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnUltimo.Location = new System.Drawing.Point(669, 15);
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
            btnSiguiente.Location = new System.Drawing.Point(581, 15);
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
            btnAnterior.Location = new System.Drawing.Point(493, 15);
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
            btnPrimero.Location = new System.Drawing.Point(405, 15);
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
            // asignacion_roles
            // 
            asignacion_roles.Controls.Add(lblInfoEdicion);
            asignacion_roles.Controls.Add(lblRolActual);
            asignacion_roles.Controls.Add(cmbRol);
            asignacion_roles.Controls.Add(lbl_nuevor_rol);
            asignacion_roles.Controls.Add(txtUsuario);
            asignacion_roles.Controls.Add(lbl_usuario);
            asignacion_roles.Controls.Add(txtId);
            asignacion_roles.Controls.Add(lbl_id);
            asignacion_roles.Dock = System.Windows.Forms.DockStyle.Fill;
            asignacion_roles.Location = new System.Drawing.Point(0, 91);
            asignacion_roles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            asignacion_roles.Name = "asignacion_roles";
            asignacion_roles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            asignacion_roles.Size = new System.Drawing.Size(779, 391);
            asignacion_roles.TabIndex = 3;
            asignacion_roles.TabStop = false;
            asignacion_roles.Text = "Asignación de Roles";
            // 
            // lblInfoEdicion
            // 
            lblInfoEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblInfoEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblInfoEdicion.Location = new System.Drawing.Point(21, 275);
            lblInfoEdicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfoEdicion.Name = "lblInfoEdicion";
            lblInfoEdicion.Size = new System.Drawing.Size(727, 90);
            lblInfoEdicion.TabIndex = 12;
            lblInfoEdicion.Text = "Selecciona un nuevo rol y haz clic en Guardar para cambiar.";
            lblInfoEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRolActual
            // 
            lblRolActual.AutoSize = true;
            lblRolActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblRolActual.Location = new System.Drawing.Point(17, 174);
            lblRolActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRolActual.Name = "lblRolActual";
            lblRolActual.Size = new System.Drawing.Size(113, 20);
            lblRolActual.TabIndex = 11;
            lblRolActual.Text = "Rol actual: -";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new System.Drawing.Point(21, 237);
            cmbRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new System.Drawing.Size(420, 28);
            cmbRol.TabIndex = 10;
            // 
            // lbl_nuevor_rol
            // 
            lbl_nuevor_rol.AutoSize = true;
            lbl_nuevor_rol.Location = new System.Drawing.Point(17, 212);
            lbl_nuevor_rol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_nuevor_rol.Name = "lbl_nuevor_rol";
            lbl_nuevor_rol.Size = new System.Drawing.Size(81, 20);
            lbl_nuevor_rol.TabIndex = 9;
            lbl_nuevor_rol.Text = "Nuevo Rol:";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new System.Drawing.Point(21, 135);
            txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new System.Drawing.Size(420, 27);
            txtUsuario.TabIndex = 8;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new System.Drawing.Point(17, 111);
            lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new System.Drawing.Size(62, 20);
            lbl_usuario.TabIndex = 7;
            lbl_usuario.Text = "Usuario:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(21, 65);
            txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new System.Drawing.Size(132, 27);
            txtId.TabIndex = 6;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new System.Drawing.Point(17, 40);
            lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new System.Drawing.Size(22, 20);
            lbl_id.TabIndex = 5;
            lbl_id.Text = "Id";
            // 
            // Frm_Roles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(912, 555);
            Controls.Add(asignacion_roles);
            Controls.Add(pnl_registros);
            Controls.Add(panel_guardar);
            Controls.Add(gestion_roles);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Frm_Roles";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gestión de Roles";
            gestion_roles.ResumeLayout(false);
            gestion_roles.PerformLayout();
            panel_guardar.ResumeLayout(false);
            pnl_registros.ResumeLayout(false);
            pnl_registros.PerformLayout();
            asignacion_roles.ResumeLayout(false);
            asignacion_roles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel gestion_roles;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel_guardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnl_registros;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.GroupBox asignacion_roles;
        private System.Windows.Forms.Label lblInfoEdicion;
        private System.Windows.Forms.Label lblRolActual;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lbl_nuevor_rol;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl_id;
    }
}
