// Original Source: CodeProject.com
// Modified by: Daniel Morato Baudi
namespace BibliotecaJuegos
{
    /// <summary>
    /// CheckBox para añadir al CheckComboBox.
    /// </summary>
    public class CheckComboBoxItem
    {
        #region Atributos
        private bool _checkState;
        private string _text;
        private bool _drawn;
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una nueva instancia de CheckComboBoxItem.
        /// </summary>
        /// <param name="text">Texto del CheckBox.</param>
        /// <param name="initialCheckState">Estado inicial del CheckBox.</param>
        public CheckComboBoxItem(string text, bool checkState)
        {
            this._checkState = checkState;
            this._text = text;
            this._drawn = false;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// This is used to keep the edit control portion of the combo box consistent
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text; // "";
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el estado.
        /// </summary>
        public bool CheckState
        {
            get { return _checkState; }
            set { _checkState = value; }
        }

        /// <summary>
        /// Obtiene o establece el texto.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// Obtiene o establece el estado de escritura.
        /// </summary>
        public bool Drawn
        {
            get { return _drawn; }
            set { _drawn = value; }
        }
        #endregion
    }
}