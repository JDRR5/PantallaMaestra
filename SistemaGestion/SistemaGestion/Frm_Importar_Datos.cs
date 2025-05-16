using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using System.Xml;
using System.Text;
using System.Collections.Generic;
using SistemaGestion.Exportadores;
using System.Reflection;

namespace SistemaGestion.Formularios
{
    public partial class Frm_Importar_Datos : Form
    {
        private readonly string _dbFilePath;
        private DataTable _dataTable;
        private string _selectedTable;
        
        public Frm_Importar_Datos(string dbFilePath)
        {
            InitializeComponent();
            _dbFilePath = dbFilePath;
            _dataTable = new DataTable();
            
            ConfigurarFormulario();
            CargarTablasDisponibles();
        }
        
        private void ConfigurarFormulario()
        {
            this.Text = "Importar Datos";
            this.Size = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            
            // Botón Seleccionar Archivo
            btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            btnSeleccionarArchivo.Location = new System.Drawing.Point(20, 20);
            btnSeleccionarArchivo.Size = new System.Drawing.Size(150, 30);
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            
            // Combobox para seleccionar tabla
            lblTablas.Text = "Seleccione la tabla destino:";
            lblTablas.Location = new System.Drawing.Point(200, 25);
            lblTablas.AutoSize = true;
            
            cmbTablas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTablas.Location = new System.Drawing.Point(370, 20);
            cmbTablas.Size = new System.Drawing.Size(200, 25);
            cmbTablas.SelectedIndexChanged += cmbTablas_SelectedIndexChanged;
            
            // DataGridView para mostrar y editar datos
            dgvDatos.Location = new System.Drawing.Point(20, 70);
            dgvDatos.Size = new System.Drawing.Size(750, 450);
            dgvDatos.AllowUserToAddRows = true;
            dgvDatos.AllowUserToDeleteRows = true;
            dgvDatos.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDatos.DataError += dgvDatos_DataError;
            
            // Botones para guardar y cancelar
            btnGuardar.Text = "Guardar en Base de Datos";
            btnGuardar.Location = new System.Drawing.Point(20, 530);
            btnGuardar.Size = new System.Drawing.Size(180, 30);
            btnGuardar.Click += btnGuardar_Click;
            
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(210, 530);
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.Click += btnCancelar_Click;
            
            // Label para mostrar información
            lblInfo.Text = "Seleccione un archivo para importar";
            lblInfo.Location = new System.Drawing.Point(330, 535);
            lblInfo.AutoSize = true;
        }
        
        private void CargarTablasDisponibles()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={_dbFilePath};Version=3;"))
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
        
        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                openDialog.Title = "Seleccione un archivo para importar";
                
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string extension = Path.GetExtension(openDialog.FileName).ToLower();
                        
                        // Cargar datos según el tipo de archivo
                        switch (extension)
                        {
                            case ".csv":
                                CargarArchivoCSV(openDialog.FileName);
                                break;
                            case ".txt":
                                CargarArchivoTXT(openDialog.FileName);
                                break;
                            case ".xml":
                                CargarArchivoXML(openDialog.FileName);
                                break;
                            default:
                                MessageBox.Show("Formato de archivo no soportado.", "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                        
                        // Mostrar datos en el DataGridView
                        dgvDatos.DataSource = _dataTable;
                        lblInfo.Text = $"Archivo cargado: {Path.GetFileName(openDialog.FileName)}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void CargarArchivoCSV(string filePath)
        {
            _dataTable = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            
            if (lines.Length == 0)
            {
                throw new Exception("El archivo está vacío.");
            }
            
            // Obtener encabezados (primera línea)
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                _dataTable.Columns.Add(header.Trim());
            }
            
            // Obtener datos (resto de líneas)
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                if (data.Length > 0)
                {
                    DataRow row = _dataTable.NewRow();
                    
                    for (int j = 0; j < headers.Length && j < data.Length; j++)
                    {
                        row[j] = data[j].Trim();
                    }
                    
                    _dataTable.Rows.Add(row);
                }
            }
        }
        
        private void CargarArchivoTXT(string filePath)
        {
            _dataTable = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            
            if (lines.Length < 2)
            {
                throw new Exception("El archivo no tiene suficientes datos.");
            }
            
            // Asumimos que la primera línea contiene encabezados
            string[] headers = lines[0].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string header in headers)
            {
                _dataTable.Columns.Add(header.Trim());
            }
            
            // Saltamos la segunda línea (separadores)
            for (int i = 2; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (data.Length > 0)
                {
                    DataRow row = _dataTable.NewRow();
                    
                    for (int j = 0; j < headers.Length && j < data.Length; j++)
                    {
                        row[j] = data[j].Trim();
                    }
                    
                    _dataTable.Rows.Add(row);
                }
            }
        }
        
        private void CargarArchivoXML(string filePath)
        {
            _dataTable = new DataTable();
            
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                // Asumimos un formato XML simple con elementos y atributos
                DataSet ds = new DataSet();
                ds.ReadXml(filePath);
                
                if (ds.Tables.Count > 0)
                {
                    _dataTable = ds.Tables[0];
                }
                else
                {
                    throw new Exception("No se encontraron datos en el archivo XML.");
                }
            }
        }
        
        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTable = cmbTablas.SelectedItem.ToString();
            
            // Si ya hay datos cargados, podemos validar la estructura de la tabla
            if (_dataTable.Rows.Count > 0)
            {
                ValidarEstructuraTabla();
            }
        }
        
        private void ValidarEstructuraTabla()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={_dbFilePath};Version=3;"))
                {
                    connection.Open();
                    
                    // Obtener la estructura de la tabla seleccionada
                    DataTable schemaTable = connection.GetSchema("Columns", new[] { null, null, _selectedTable, null });
                    
                    // Comparar columnas
                    List<string> columnasTabla = new List<string>();
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        columnasTabla.Add(row["COLUMN_NAME"].ToString());
                    }
                    
                    StringBuilder mensajeColumnas = new StringBuilder();
                    mensajeColumnas.AppendLine("Información sobre la estructura de la tabla:");
                    mensajeColumnas.AppendLine("Columnas en la tabla de la base de datos:");
                    
                    foreach (string columna in columnasTabla)
                    {
                        mensajeColumnas.AppendLine($"- {columna}");
                    }
                    
                    mensajeColumnas.AppendLine("\nColumnas en los datos importados:");
                    foreach (DataColumn col in _dataTable.Columns)
                    {
                        mensajeColumnas.AppendLine($"- {col.ColumnName}");
                    }
                    
                    // Mostrar información pero permitir continuar
                    MessageBox.Show(mensajeColumnas.ToString(), "Información de Estructura",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar estructura: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_dataTable == null || _dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrEmpty(_selectedTable))
            {
                MessageBox.Show("Seleccione una tabla destino.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={_dbFilePath};Version=3;"))
                {
                    connection.Open();
                    
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Verificar que las columnas coincidan
                            DataTable schemaTable = connection.GetSchema("Columns", new[] { null, null, _selectedTable, null });
                            List<string> columnasTabla = new List<string>();
                            
                            foreach (DataRow row in schemaTable.Rows)
                            {
                                columnasTabla.Add(row["COLUMN_NAME"].ToString());
                            }
                            
                            // Generar la consulta de inserción para cada fila
                            int filasInsertadas = 0;
                            
                            foreach (DataRow row in _dataTable.Rows)
                            {
                                // Solo procesar filas que no estén marcadas como borradas
                                if (!row.HasErrors && row.RowState != DataRowState.Deleted)
                                {
                                    StringBuilder columnas = new StringBuilder();
                                    StringBuilder valores = new StringBuilder();
                                    List<SQLiteParameter> parametros = new List<SQLiteParameter>();
                                    
                                    int paramIndex = 0;
                                    
                                    foreach (DataColumn col in _dataTable.Columns)
                                    {
                                        // Verificar si la columna existe en la tabla destino
                                        if (columnasTabla.Contains(col.ColumnName))
                                        {
                                            // Agregar la columna y el valor correspondiente
                                            if (paramIndex > 0)
                                            {
                                                columnas.Append(", ");
                                                valores.Append(", ");
                                            }
                                            
                                            columnas.Append(col.ColumnName);
                                            valores.Append($"@p{paramIndex}");
                                            
                                            parametros.Add(new SQLiteParameter($"@p{paramIndex}", 
                                                           row[col] == DBNull.Value ? null : row[col]));
                                            
                                            paramIndex++;
                                        }
                                    }
                                    
                                    if (paramIndex > 0)
                                    {
                                        string query = $"INSERT INTO {_selectedTable} ({columnas}) VALUES ({valores})";
                                        
                                        using (var command = new SQLiteCommand(query, connection, transaction))
                                        {
                                            // Agregar parámetros
                                            foreach (var param in parametros)
                                            {
                                                command.Parameters.Add(param);
                                            }
                                            
                                            // Ejecutar la inserción
                                            command.ExecuteNonQuery();
                                            filasInsertadas++;
                                        }
                                    }
                                }
                            }
                            
                            // Confirmar la transacción
                            transaction.Commit();
                            
                            MessageBox.Show($"Se insertaron {filasInsertadas} registros en la tabla {_selectedTable}.",
                                          "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Revertir la transacción en caso de error
                            transaction.Rollback();
                            throw new Exception($"Error al insertar datos: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgvDatos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Error de datos en la celda ({e.ColumnIndex}, {e.RowIndex}): {e.Exception.Message}",
                          "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.ThrowException = false;
        }
    }
}
