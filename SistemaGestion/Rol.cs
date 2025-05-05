using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Modelos
{
    /// <summary>
    /// Modelo que representa un rol de usuario en el sistema
    /// </summary>
    public class Rol
    {
        /// <summary>
        /// Identificador único del rol
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nombre descriptivo del rol
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Constante para el ID del rol de Administrador
        /// </summary>
        public const int ADMINISTRADOR_ID = 1;
        
        /// <summary>
        /// Constante para el ID del rol de Vendedor
        /// </summary>
        public const int VENDEDOR_ID = 2;
        
        /// <summary>
        /// Constante para el ID del rol de Almacenista
        /// </summary>
        public const int ALMACENISTA_ID = 3;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Rol()
        {
            Id = 0;
            Nombre = string.Empty;
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Rol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        /// <summary>
        /// Obtiene un rol de administrador
        /// </summary>
        public static Rol ObtenerRolAdministrador()
        {
            return new Rol(ADMINISTRADOR_ID, "Administrador");
        }

        /// <summary>
        /// Obtiene un rol de vendedor
        /// </summary>
        public static Rol ObtenerRolVendedor()
        {
            return new Rol(VENDEDOR_ID, "Vendedor");
        }

        /// <summary>
        /// Obtiene un rol de almacenista
        /// </summary>
        public static Rol ObtenerRolAlmacenista()
        {
            return new Rol(ALMACENISTA_ID, "Almacenista");
        }

        /// <summary>
        /// Representación en string del rol
        /// </summary>
        public override string ToString()
        {
            return Nombre;
        }
    }
}
