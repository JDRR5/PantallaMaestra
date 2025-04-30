using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaGestion.Helpers
{
    /// <summary>
    /// Clase estática para validación de datos de entrada
    /// </summary>
    public static class Validacion
    {
        /// <summary>
        /// Verifica si una cadena es un correo electrónico válido
        /// </summary>
        /// <param name="email">Correo electrónico a validar</param>
        /// <returns>True si el correo es válido, False en caso contrario</returns>
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true; // Permitimos emails vacíos (no son obligatorios)

            // Patrón básico para validar emails
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Verifica si una cadena es un número decimal positivo
        /// </summary>
        /// <param name="valor">Valor a validar</param>
        /// <returns>True si es un decimal positivo, False en caso contrario</returns>
        public static bool EsNumeroDecimalPositivo(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            // Permitir tanto punto como coma para separador decimal
            valor = valor.Replace(',', '.');

            if (decimal.TryParse(valor, out decimal resultado))
            {
                return resultado >= 0;
            }
            return false;
        }

        /// <summary>
        /// Verifica si una cadena es un número entero positivo
        /// </summary>
        /// <param name="valor">Valor a validar</param>
        /// <returns>True si es un entero positivo, False en caso contrario</returns>
        public static bool EsEnteroPositivo(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            if (int.TryParse(valor, out int resultado))
            {
                return resultado >= 0;
            }
            return false;
        }

        /// <summary>
        /// Verifica si una cadena contiene solo letras y espacios
        /// </summary>
        /// <param name="texto">Texto a validar</param>
        /// <returns>True si solo contiene letras y espacios, False en caso contrario</returns>
        public static bool SoloLetras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            return Regex.IsMatch(texto, @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ\s]+$");
        }

        /// <summary>
        /// Verifica si una cadena es un número de teléfono válido
        /// </summary>
        /// <param name="telefono">Teléfono a validar</param>
        /// <returns>True si es un teléfono válido, False en caso contrario</returns>
        public static bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                return true; // Permitimos teléfonos vacíos (no son obligatorios)

            // Patrón para validar teléfonos (permite números, espacios, guiones y paréntesis)
            string pattern = @"^[\d\s\-\(\)]+$";
            return Regex.IsMatch(telefono, pattern);
        }

        /// <summary>
        /// Valida la longitud mínima de una cadena
        /// </summary>
        /// <param name="texto">Texto a validar</param>
        /// <param name="longitudMinima">Longitud mínima requerida</param>
        /// <returns>True si cumple con la longitud mínima, False en caso contrario</returns>
        public static bool LongitudMinima(string texto, int longitudMinima)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            return texto.Length >= longitudMinima;
        }

        /// <summary>
        /// Valida la longitud máxima de una cadena
        /// </summary>
        /// <param name="texto">Texto a validar</param>
        /// <param name="longitudMaxima">Longitud máxima permitida</param>
        /// <returns>True si cumple con la longitud máxima, False en caso contrario</returns>
        public static bool LongitudMaxima(string texto, int longitudMaxima)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return true; // Permitimos textos vacíos

            return texto.Length <= longitudMaxima;
        }

        /// <summary>
        /// Formatea un texto con la primera letra en mayúscula y el resto en minúscula
        /// </summary>
        /// <param name="texto">Texto a formatear</param>
        /// <returns>Texto formateado</returns>
        public static string PrimeraLetraMayuscula(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            if (texto.Length == 1)
                return texto.ToUpper();

            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }
    }
}
