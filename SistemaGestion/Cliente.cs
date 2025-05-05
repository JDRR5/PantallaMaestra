using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Modelos
{
    /// <summary>
    /// Modelo que representa un cliente en el sistema
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Identificador único del cliente
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string Nombre { get; set; }
        
        /// <summary>
        /// Apellido del cliente
        /// </summary>
        public string Apellido { get; set; }
        
        /// <summary>
        /// Documento de identidad del cliente (único)
        /// </summary>
        public string Documento { get; set; }
        
        /// <summary>
        /// Número de teléfono del cliente
        /// </summary>
        public string Telefono { get; set; }
        
        /// <summary>
        /// Correo electrónico del cliente
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Dirección del cliente
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Nombre completo del cliente (Nombre + Apellido)
        /// </summary>
        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Cliente()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Documento = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
        }

        /// <summary>
        /// Constructor con parámetros básicos
        /// </summary>
        public Cliente(string nombre, string apellido, string documento)
        {
            Id = 0;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Telefono = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
        }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        public Cliente(int id, string nombre, string apellido, string documento, string telefono, string email, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

        /// <summary>
        /// Representación en string del cliente
        /// </summary>
        public override string ToString()
        {
            return $"{NombreCompleto} - {Documento}";
        }
    }
}
