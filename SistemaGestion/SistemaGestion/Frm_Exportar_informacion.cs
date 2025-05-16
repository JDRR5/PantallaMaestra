using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using SistemaGestion.Exportadores;

namespace SistemaGestion.Formularios
{
    public partial class Frm_Exportar_informacion : Form
    {
        private readonly ExportadorSQLite _exportador;

        public Frm_Exportar_informacion(string dbFilePath)
        {
            InitializeComponent();
            _exportador = new ExportadorSQLite(dbFilePath);
            InicializarComponentes();
            CargarTablasDisponibles();
            CargarFormatosDisponibles();
        }

        private void InicializarComponentes()
        {
            // Configuración básica del formulario
            this.Text = "Exportar Datos";
            this.Size = new System.Drawing.Size(450, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            // Configurar controles existentes (declarados en el diseñador)
            cmbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTablas.Location = new System.Drawing.Point(20, 50);
            cmbTablas.Width = 400;

            cmbFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormato.Location = new System.Drawing.Point(20, 120);
            cmbFormato.Width = 400;

            btnExportar.Text = "Exportar";
            btnExportar.Location = new System.Drawing.Point(20, 170);
            btnExportar.Size = new System.Drawing.Size(100, 30);
            btnExportar.Click += btnExportar_Click;

            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(130, 170);
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.Click += btnCancelar_Click;

            lblTablas.Text = "Seleccione la tabla:";
            lblTablas.Location = new System.Drawing.Point(20, 20);
            lblTablas.AutoSize = true;

            lblFormato.Text = "Seleccione el formato:";
            lblFormato.Location = new System.Drawing.Point(20, 90);
            lblFormato.AutoSize = true;
        }

        private void CargarTablasDisponibles()
        {
            try
            {
                using (var connection = new SQLiteConnection(_exportador.ConnectionString))
                {
                    connection.Open();
                    var tables = connection.GetSchema("Tables");

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        if (!tableName.StartsWith("sqlite_"))
                        {
                            cmbTablas.Items.Add(tableName);
                        }
                    }

                    if (cmbTablas.Items.Count > 0)
                    {
                        cmbTablas.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tablas: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFormatosDisponibles()
        {
            cmbFormato.DataSource = Enum.GetValues(typeof(ExportadorSQLite.FormatoExportacion));
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTablas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una tabla para exportar", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tabla = cmbTablas.SelectedItem.ToString();
                var formato = (ExportadorSQLite.FormatoExportacion)cmbFormato.SelectedItem;
                string query = $"SELECT * FROM {tabla}";

                // Verificar si ya existe un archivo guardado para esta sesión
                string nombreArchivo = $"{tabla}_export_{DateTime.Now:yyyyMMddHHmm}";
                string rutaCompleta = string.Empty;

                // Solo mostrar el diálogo si no se ha guardado previamente
                if (string.IsNullOrEmpty(rutaCompleta))
                {
                    using (var saveDialog = new SaveFileDialog())
                    {
                        saveDialog.Filter = ObtenerFiltroFormato(formato);
                        saveDialog.FileName = nombreArchivo;
                        saveDialog.OverwritePrompt = true;

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            rutaCompleta = saveDialog.FileName;
                        }
                        else
                        {
                            // Usuario canceló la operación
                            return;
                        }
                    }
                }

                // Solo continuar si tenemos una ruta válida
                if (!string.IsNullOrEmpty(rutaCompleta))
                {
                    _exportador.ExportarDatos(query, rutaCompleta, formato);
                    MessageBox.Show("Exportación completada con éxito", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ObtenerFiltroFormato(ExportadorSQLite.FormatoExportacion formato)
        {
            switch (formato)
            {
                case ExportadorSQLite.FormatoExportacion.CSV:
                    return "Archivos CSV (*.csv)|*.csv";
                case ExportadorSQLite.FormatoExportacion.TXT:
                    return "Archivos de texto (*.txt)|*.txt";
                case ExportadorSQLite.FormatoExportacion.XML:
                    return "Archivos XML (*.xml)|*.xml";
                case ExportadorSQLite.FormatoExportacion.JSON:
                    return "Archivos JSON (*.json)|*.json";
                default:
                    return "Todos los archivos (*.*)|*.*";
            }
        }
    }
}