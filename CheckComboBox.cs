// Original Source: CodeProject.com
// Modified by: Daniel Morato Baudi
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BibliotecaJuegos
{
    /// <summary>
    /// Inherits from ComboBox and handles DrawItem and SelectedIndexChanged events to create an
    /// owner drawn combo box drop-down.  The contents of the dropdown are rendered using the
    /// CheckBoxRenderer class.
    /// </summary>
    public partial class CheckComboBox : ComboBox
    {
        #region Atributos
        private CheckComboBoxItem item;
        private bool focused;
        private CheckBoxState state;
        #endregion

        #region Constructor
        /// <summary>
        /// Inicializa una nueva instancia de CheckComboBox.
        /// </summary>
        public CheckComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(
                                CheckComboBox_DrawItem);

            this.SelectedIndexChanged += new EventHandler(
                      CheckComboBox_SelectedIndexChanged);

            this.DropDown += new EventHandler(CheckComboBox_DropDown);
            this.DropDownClosed += new EventHandler(CheckComboBox_DropDownClosed);

            this.SelectedText = "";
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Invoked when the selected index is changed on the dropdown.  This sets the check state
        /// of the CheckComboBoxItem and fires the public event CheckStateChanged using the 
        /// CheckComboBoxItem as the event sender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            item = (CheckComboBoxItem)this.SelectedItem;
            item.CheckState = !item.CheckState;
            if (this.CheckStateChanged != null)
                this.CheckStateChanged(item, e);
        }

        /// <summary>
        /// Invoked when the ComboBox has to render the drop-down items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
			// make sure the index is valid (sanity check)
			if (e.Index == -1)
				return;

			// test the item to see if its a CheckComboBoxItem
			if (!(this.Items[e.Index] is CheckComboBoxItem))
			{
				// it's not, so just render it as a default string
				e.Graphics.DrawString(
					this.Items[e.Index].ToString(),
					this.Font, Brushes.Black,
					new Point(e.Bounds.X, e.Bounds.Y));

				return;
			}

			// get the CheckComboBoxItem from the collection and render it.
			item = (CheckComboBoxItem)Items[e.Index];
			CheckBoxRenderer.RenderMatchingApplicationState = true;

            focused = (e.State & DrawItemState.Focus) == 0;
            state = item.CheckState ? 
                CheckBoxState.CheckedNormal : 
                CheckBoxState.UncheckedNormal;

            if (!item.Drawn)
            {
                CheckBoxRenderer.DrawCheckBox(
                    e.Graphics, new Point(e.Bounds.X,
                    e.Bounds.Y), e.Bounds, item.Text,
                    this.Font, focused, state);

                item.Drawn = true;
            }
		}

        void CheckComboBox_DropDown(object sender, EventArgs e)
        {
            foreach (CheckComboBoxItem item in this.Items)
                item.Drawn = false;
        }

        void CheckComboBox_DropDownClosed(object sender, EventArgs e)
        {
            foreach (CheckComboBoxItem item in this.Items)
                item.Drawn = false;
        }

        /// <summary>
        /// Fired when the user clicks a check box item in the drop-down list
        /// </summary>
        public event EventHandler CheckStateChanged;
        #endregion
    }
}