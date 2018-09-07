/// <author>Daniel Morato Baudi</author>
using System.Drawing;

namespace BibliotecaJuegos
{
    /// <summary>
    /// Esta clase nos permitira crear un tipo especial de Bitmap,
    /// del cual podremos extraer su path.
    /// </summary>
    class SpecialBitmap
    {
        #region Atributos
        private Bitmap imagen;
        private string path;
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa un SpecialBitmap con un path.
        /// </summary>
        /// <param name="path">Imagen que vamos a usar para inicializar nuestro Bitmap.</param>
        public SpecialBitmap(string path)
        {
            this.path = path;
            if (path != "")
                this.imagen = new Bitmap(path);
        }

        /// <summary>
        /// Inicializa un SpecialBitmap con otro Bitmap.
        /// </summary>
        /// <param name="imagen">Bitmap que vamos a usar para inicializar nuestro Bitmap.</param>
        public SpecialBitmap(Bitmap imagen)
        {
            this.path = "Recurso local.";
            this.imagen = imagen;
        }
        #endregion

        #region Propiedades
        public Bitmap Bitmap
        {
            get { return this.imagen; }
            set { this.imagen = value; }
        }
        public string Path
        { 
            get { return this.path; }
            set { this.path = value; }
        }
        #endregion
    }
}