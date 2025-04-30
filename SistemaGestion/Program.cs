using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestion.BaseDatos;
using SistemaGestion.Formularios;

namespace SistemaGestion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Para .NET 6/7/8
            ApplicationConfiguration.Initialize();

            // Inicializar la base de datos
            try
            {
                InitializeDatabase();
                Application.Run(new Frm_Registrarse());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la aplicación: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void InitializeDatabase()
        {
            try
            {
                string dbPath = "sistema_gestion.db";
                bool exists = File.Exists(dbPath);

                if (!exists)
                {
                    SQLiteConnection.CreateFile(dbPath);
                    
                    using (var connection = Frm_BasedeDatos.Instance.CrearConexion())
                    {
                        connection.Open();
                        using (var command = new SQLiteCommand(connection))
                        {
                            // Crear tabla de roles
                            command.CommandText = @"
                                CREATE TABLE IF NOT EXISTS roles (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    nombre TEXT NOT NULL
                                );
                            ";
                            command.ExecuteNonQuery();

                            // Crear tabla de usuarios
                            command.CommandText = @"
                                CREATE TABLE IF NOT EXISTS usuarios (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    username TEXT NOT NULL UNIQUE,
                                    password TEXT NOT NULL,
                                    id_rol INTEGER,
                                    FOREIGN KEY (id_rol) REFERENCES roles(id)
                                );
                            ";
                            command.ExecuteNonQuery();

                            // Crear tabla de clientes
                            command.CommandText = @"
                                CREATE TABLE IF NOT EXISTS clientes (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    nombre TEXT NOT NULL,
                                    apellido TEXT NOT NULL,
                                    documento TEXT NOT NULL UNIQUE,
                                    telefono TEXT,
                                    email TEXT,
                                    direccion TEXT
                                );
                            ";
                            command.ExecuteNonQuery();

                            // Crear tabla de productos
                            command.CommandText = @"
                                CREATE TABLE IF NOT EXISTS productos (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    codigo TEXT NOT NULL UNIQUE,
                                    nombre TEXT NOT NULL,
                                    descripcion TEXT,
                                    precio REAL NOT NULL,
                                    stock INTEGER NOT NULL DEFAULT 0
                                );
                            ";
                            command.ExecuteNonQuery();

                            // Insertar roles por defecto
                            command.CommandText = "INSERT INTO roles (nombre) VALUES ('Administrador');";
                            command.ExecuteNonQuery();
                            command.CommandText = "INSERT INTO roles (nombre) VALUES ('Vendedor');";
                            command.ExecuteNonQuery();
                            command.CommandText = "INSERT INTO roles (nombre) VALUES ('Almacenista');";
                            command.ExecuteNonQuery();

                            // Insertar usuario administrador por defecto
                            command.CommandText = "INSERT INTO usuarios (username, password, id_rol) VALUES ('admin', 'admin123', 1);";
                            command.ExecuteNonQuery();

                            // Insertar datos de ejemplo
                            InsertarDatosEjemplo(connection);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar la base de datos: {ex.Message}", "Error de inicialización", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Propagar el error para registrarlo en la aplicación principal
            }
        }

        private static void InsertarDatosEjemplo(SQLiteConnection connection)
        {
            try
            {
                using (var command = new SQLiteCommand(connection))
                {
                    // Insertar usuarios de ejemplo
                    command.CommandText = "INSERT INTO usuarios (username, password, id_rol) VALUES ('vendedor', 'venta123', 2);";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO usuarios (username, password, id_rol) VALUES ('almacen', 'almacen123', 3);";
                    command.ExecuteNonQuery();

                    // Insertar clientes de ejemplo
                    command.CommandText = @"
                        INSERT INTO clientes (nombre, apellido, documento, telefono, email, direccion) 
                        VALUES ('Juan', 'Pérez', '12345678', '555-1234', 'juan@example.com', 'Calle 123');
                    ";
                    command.ExecuteNonQuery();
                    command.CommandText = @"
                        INSERT INTO clientes (nombre, apellido, documento, telefono, email, direccion) 
                        VALUES ('María', 'González', '87654321', '555-5678', 'maria@example.com', 'Avenida 456');
                    ";
                    command.ExecuteNonQuery();
                    command.CommandText = @"
                        INSERT INTO clientes (nombre, apellido, documento, telefono, email, direccion) 
                        VALUES ('Carlos', 'Rodríguez', '23456789', '555-9012', 'carlos@example.com', 'Plaza 789');
                    ";
                    command.ExecuteNonQuery();

                    // Insertar productos de ejemplo
                    command.CommandText = @"
                        INSERT INTO productos (codigo, nombre, descripcion, precio, stock) 
                        VALUES ('P001', 'Laptop', 'Laptop de 15 pulgadas', 1200.00, 10);
                    ";
                    command.ExecuteNonQuery();
                    command.CommandText = @"
                        INSERT INTO productos (codigo, nombre, descripcion, precio, stock) 
                        VALUES ('P002', 'Smartphone', 'Teléfono inteligente', 800.00, 20);
                    ";
                    command.ExecuteNonQuery();
                    command.CommandText = @"
                        INSERT INTO productos (codigo, nombre, descripcion, precio, stock) 
                        VALUES ('P003', 'Tablet', 'Tablet de 10 pulgadas', 500.00, 15);
                    ";
                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                // Detectamos errores específicos de SQLite
                // Código 19 corresponde a restricciones (UNIQUE, etc.)
                if (ex.ErrorCode == 19)
                {
                    // Esto puede ser normal si ya existen los datos (restricciones UNIQUE)
                    Console.WriteLine($"Algunos datos de ejemplo ya existen: {ex.Message}");
                }
                else
                {
                    // Para otros errores de SQLite, mostramos mensaje
                    MessageBox.Show($"Error al insertar datos de ejemplo: {ex.Message}", "Error de base de datos", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Para errores generales, mostramos mensaje
                MessageBox.Show($"Error inesperado al insertar datos: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
