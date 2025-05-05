using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Modelos
{
    /// <summary>
    /// Modelo que representa un producto en el sistema
    /// </summary>
    public class Producto
    {
        /// <summary>
        /// Identificador único del producto
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Código único del producto
        /// </summary>
        public string Codigo { get; set; }
        
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Nombre { get; set; }
        
        /// <summary>
        /// Descripción detallada del producto
        /// </summary>
        public string Descripcion { get; set; }
        
        /// <summary>
        /// Precio unitario del producto
        /// </summary>
        public decimal Precio { get; set; }
        
        /// <summary>
        /// Cantidad disponible en inventario
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Indica si el producto tiene stock disponible
        /// </summary>
        public bool TieneStock
        {
            get { return Stock > 0; }
        }

        /// <summary>
        /// Descripción corta del producto (para listados)
        /// </summary>
        public string DescripcionCorta
        {
            get
            {
                if (string.IsNullOrEmpty(Descripcion) || Descripcion.Length <= 30)
                    return Descripcion;
                return Descripcion.Substring(0, 30) + "...";
            }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Producto()
        {
            Id = 0;
            Codigo = string.Empty;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            Stock = 0;
        }

        /// <summary>
        /// Constructor con parámetros básicos
        /// </summary>
        public Producto(string codigo, string nombre, decimal precio)
        {
            Id = 0;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = string.Empty;
            Precio = precio;
            Stock = 0;
        }

        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        public Producto(int id, string codigo, string nombre, string descripcion, decimal precio, int stock)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

        /// <summary>
        /// Representación en string del producto
        /// </summary>
        public override string ToString()
        {
            return $"{Codigo} - {Nombre} (${Precio:N2})";
        }
    }
}
