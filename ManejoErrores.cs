/// <author>Daniel Morato Baudi</author>
using System;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    /// <summary>
    /// Esta clase proporciona metodos para hacer comprobaciones y validaciones.
    /// </summary>
    class ManejoErrores
    {
        /// <summary>
        /// Este método permite comprobar si un string es únicamente numérico.
        /// </summary>
        /// <param name="cadena">Cadena a comprobar.</param>
        /// <returns>Devuelve un boolean indicando si es o no numerico.</returns>
        public static bool EsNumero(string cadena)
        {
            try {
                Convert.ToInt32(cadena);

            } catch (FormatException error) {
                // MessageBox.Show("Error: La cadena introducida"
                //           + "es inválida - " + error.Message);
                return false;

            } catch (InvalidCastException error) {
                // MessageBox.Show("Error: La cadena introducida"
                //           + "es inválida - " + error.Message);
                return false;

            } catch (Exception error) {
                // MessageBox.Show("Error: La cadena introducida"
                //           + "es inválida - " + error.Message);
                return false;
            }

            return true;
        }
    }
}
