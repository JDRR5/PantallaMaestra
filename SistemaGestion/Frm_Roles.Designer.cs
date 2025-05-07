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
            this.pnl_gestionRoles = new System.Windows.Forms.Panel();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_guardar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnl_registros = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.grp_asignacionRoles = new System.Windows.Forms.GroupBox();
            this.lblInfoEdicion = new System.Windows.Forms.Label();
            this.lblRolActual = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lbl_nuevoRol = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pnl_gestionRoles.SuspendLayout();
            this.pnl_guardar.SuspendLayout();
            this.pnl_registros.SuspendLayout();
            this.grp_asignacionRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_gestionRoles
            // 
            this.pnl_gestionRoles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_gestionRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_gestionRoles.Controls.Add(this.lblTotalRegistros);
            this.pnl_gestionRoles.Controls.Add(this.lbl_titulo);
            this.pnl_gestionRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_gestionRoles.Location = new System.Drawing.Point(0, 0);
            this.pnl_gestionRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_gestionRoles.Name = "pnl_gestionRoles";
            this.pnl_gestionRoles.Size = new System.Drawing.Size(912, 73);
            this.pnl_gestionRoles.TabIndex = 0;
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
            this.lbl_titulo.Size = new System.Drawing.Size(215, 29);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestión de Roles";
            // 
            // pnl_guardar
            // 
            this.pnl_guardar.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_guardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_guardar.Controls.Add(this.btnCancelar);
            this.pnl_guardar.Controls.Add(this.btnGuardar);
            this.pnl_guardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_guardar.Location = new System.Drawing.Point(779, 73);
            this.pnl_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_guardar.Name = "pnl_guardar";
            this.pnl_guardar.Size = new System.Drawing.Size(133, 371);
            this.pnl_guardar.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 62);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 14);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 41);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
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
            this.pnl_registros.Location = new System.Drawing.Point(0, 385);
            this.pnl_registros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_registros.Name = "pnl_registros";
            this.pnl_registros.Size = new System.Drawing.Size(779, 59);
            this.pnl_registros.TabIndex = 2;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUltimo.Location = new System.Drawing.Point(669, 12);
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
            this.btnSiguiente.Location = new System.Drawing.Point(581, 12);
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
            this.btnAnterior.Location = new System.Drawing.Point(493, 12);
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
            this.btnPrimero.Location = new System.Drawing.Point(405, 12);
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
            // grp_asignacionRoles
            // 
            this.grp_asignacionRoles.Controls.Add(this.lblInfoEdicion);
            this.grp_asignacionRoles.Controls.Add(this.lblRolActual);
            this.grp_asignacionRoles.Controls.Add(this.cmbRol);
            this.grp_asignacionRoles.Controls.Add(this.lbl_nuevoRol);
            this.grp_asignacionRoles.Controls.Add(this.txtUsuario);
            this.grp_asignacionRoles.Controls.Add(this.lbl_usuario);
            this.grp_asignacionRoles.Controls.Add(this.txtId);
            this.grp_asignacionRoles.Controls.Add(this.lbl_id);
            this.grp_asignacionRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_asignacionRoles.Location = new System.Drawing.Point(0, 73);
            this.grp_asignacionRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_asignacionRoles.Name = "grp_asignacionRoles";
            this.grp_asignacionRoles.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_asignacionRoles.Size = new System.Drawing.Size(779, 312);
            this.grp_asignacionRoles.TabIndex = 3;
            this.grp_asignacionRoles.TabStop = false;
            this.grp_asignacionRoles.Text = "Asignación de Roles";
            // 
            // lblInfoEdicion
            // 
            this.lblInfoEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEdicion.Location = new System.Drawing.Point(21, 220);
            this.lblInfoEdicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoEdicion.Name = "lblInfoEdicion";
            this.lblInfoEdicion.Size = new System.Drawing.Size(727, 72);
            this.lblInfoEdicion.TabIndex = 12;
            this.lblInfoEdicion.Text = "Selecciona un nuevo rol y haz clic en Guardar para cambiar.";
            this.lblInfoEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRolActual
            // 
            this.lblRolActual.AutoSize = true;
            this.lblRolActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolActual.Location = new System.Drawing.Point(17, 139);
            this.lblRolActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolActual.Name = "lblRolActual";
            this.lblRolActual.Size = new System.Drawing.Size(113, 20);
            this.lblRolActual.TabIndex = 11;
            this.lblRolActual.Text = "Rol actual: -";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(21, 190);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(420, 24);
            this.cmbRol.TabIndex = 10;
            // 
            // lbl_nuevoRol
            // 
            this.lbl_nuevoRol.AutoSize = true;
            this.lbl_nuevoRol.Location = new System.Drawing.Point(17, 170);
            this.lbl_nuevoRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nuevoRol.Name = "lbl_nuevoRol";
            this.lbl_nuevoRol.Size = new System.Drawing.Size(74, 16);
            this.lbl_nuevoRol.TabIndex = 9;
            this.lbl_nuevoRol.Text = "Nuevo Rol:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(21, 108);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(420, 22);
            this.txtUsuario.TabIndex = 8;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(17, 89);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(57, 16);
            this.lbl_usuario.TabIndex = 7;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(21, 52);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 6;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(17, 32);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 16);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "Id";
            // 
            // Frm_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 444);
            this.Controls.Add(this.grp_asignacionRoles);
            this.Controls.Add(this.pnl_registros);
            this.Controls.Add(this.pnl_guardar);
            this.Controls.Add(this.pnl_gestionRoles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Roles";
            this.pnl_gestionRoles.ResumeLayout(false);
            this.pnl_gestionRoles.PerformLayout();
            this.pnl_guardar.ResumeLayout(false);
            this.pnl_registros.ResumeLayout(false);
            this.pnl_registros.PerformLayout();
            this.grp_asignacionRoles.ResumeLayout(false);
            this.grp_asignacionRoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_gestionRoles;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_guardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnl_registros;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.GroupBox grp_asignacionRoles;
        private System.Windows.Forms.Label lblInfoEdicion;
        private System.Windows.Forms.Label lblRolActual;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lbl_nuevoRol;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl_id;
    }
}
