using System.Windows.Forms;

namespace SistemaGestion.Formularios
{
    partial class Frm_Importar_Datos
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
            this.btnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.lblTablas = new System.Windows.Forms.Label();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            // 
            // lblTablas
            // 
            this.lblTablas.Name = "lblTablas";
            // 
            // cmbTablas
            // 
            this.cmbTablas.Name = "cmbTablas";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Name = "dgvDatos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Name = "btnGuardar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Name = "btnCancelar";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            // 
            // Frm_Importar_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Name = "Frm_Importar_Datos";
            this.Text = "Importar Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarArchivo;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblInfo;
    }
}
