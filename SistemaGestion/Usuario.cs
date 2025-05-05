using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Modelos
{
    /// <summary>
    /// Modelo que representa un usuario del sistema
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Identificador único del usuario
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nombre de usuario (único en el sistema)
        /// </summary>
        public string Username { get; set; }
        
        /// <summary>
        /// Identificador del rol asignado al usuario
        /// </summary>
        public int IdRol { get; set; }
        
        /// <summary>
        /// Nombre del rol asignado al usuario (para visualización)
        /// </summary>
        public string NombreRol { get; set; }

        /// <summary>
        /// Indica si el usuario es un administrador
        /// </summary>
        public bool EsAdministrador
        {
            get { return IdRol == 1; }
        }

        /// <summary>
        /// Indica si el usuario es un vendedor
        /// </summary>
        public bool EsVendedor
        {
            get { return IdRol == 2; }
        }

        /// <summary>
        /// Indica si el usuario es un almacenista
        /// </summary>
        public bool EsAlmacenista
        {
            get { return IdRol == 3; }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Usuario()
        {
            Id = 0;
            Username = string.Empty;
            IdRol = 0;
            NombreRol = string.Empty;
        }

        /// <summary>
        /// Constructor con parámetros básicos
        /// </summary>
        public Usuario(string username, int idRol)
        {
            Id = 0;
            Username = username;
            IdRol = idRol;
            AsignarNombreRolPorId();
        }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        public Usuario(int id, string username, int idRol, string nombreRol)
        {
            Id = id;
            Username = username;
            IdRol = idRol;
            NombreRol = nombreRol;
        }

        /// <summary>
        /// Asigna el nombre del rol basado en el ID del rol
        /// </summary>
        private void AsignarNombreRolPorId()
        {
            switch (IdRol)
            {
                case 1:
                    NombreRol = "Administrador";
                    break;
                case 2:
                    NombreRol = "Vendedor";
                    break;
                case 3:
                    NombreRol = "Almacenista";
                    break;
                default:
                    NombreRol = "Desconocido";
                    break;
            }
        }

        /// <summary>
        /// Representación en string del usuario
        /// </summary>
        public override string ToString()
        {
            return $"{Username} ({NombreRol})";
        }
    }
}
