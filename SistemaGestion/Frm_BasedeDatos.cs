using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SistemaGestion.BaseDatos
{
    public class Frm_BasedeDatos
    {
        private static Frm_BasedeDatos _instance;
        private readonly string _connectionString;

        private Frm_BasedeDatos()
        {
            string dbPath = "sistema_gestion.db";
            _connectionString = $"Data Source={dbPath};Version=3;";
        }

        public static Frm_BasedeDatos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Frm_BasedeDatos();
                }
                return _instance;
            }
        }

        public SQLiteConnection CrearConexion()
        {
            return new SQLiteConnection(_connectionString);
        }

        public bool EjecutarComando(string comandoSQL, params SQLiteParameter[] parametros)
        {
            try
            {
                using (var conexion = CrearConexion())
                {
                    conexion.Open();
                    using (var comando = new SQLiteCommand(comandoSQL, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar comando: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable EjecutarConsulta(string consultaSQL, params SQLiteParameter[] parametros)
        {
            try
            {
                using (var conexion = CrearConexion())
                {
                    conexion.Open();
                    using (var comando = new SQLiteCommand(consultaSQL, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }

                        var tabla = new DataTable();
                        var adaptador = new SQLiteDataAdapter(comando);
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        public object EjecutarEscalar(string consultaSQL, params SQLiteParameter[] parametros)
        {
            try
            {
                using (var conexion = CrearConexion())
                {
                    conexion.Open();
                    using (var comando = new SQLiteCommand(consultaSQL, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        return comando.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar escalar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
