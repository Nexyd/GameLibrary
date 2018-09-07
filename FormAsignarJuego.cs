/// <author>Daniel Morato Baudi</author>
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    public partial class FormAsignarJuego : Form
    {
        Button btn;

        #region Constructor
        public FormAsignarJuego()
        {
            InitializeComponent();
            btn = new Button();
        }

        /// <summary>
        /// Recibe el control que inició este formulario.
        /// </summary>
        /// <param name="sender">Control que inició este formulario</param>
        public FormAsignarJuego(object sender)
        {
            InitializeComponent();

            if (sender is Button)
                this.btn = (Button)sender;
        }
        #endregion

        #region Eventos
        private void FormAsignarJuego_Load(object sender, System.EventArgs e)
        {
            lbx_ListaJuegos.DisplayMember = "Nombre";
            foreach (Juego juego in Juego.ListaJuegos)
                lbx_ListaJuegos.Items.Add(juego);
        }

        private void lbx_ListaJuegos_DoubleClick(object sender, System.EventArgs e)
        {
            if (lbx_ListaJuegos.SelectedItem != null)
                MessageBox.Show(lbx_ListaJuegos.SelectedItem.ToString());
            else
                MessageBox.Show("Sin seleccionar");
        }

        private void btn_Aceptar_Click(object sender, System.EventArgs e)
        {
            if (lbx_ListaJuegos.SelectedItem != null)
            {
                FormPrincipal form = new FormPrincipal("");
                form.AsignarJuego(this.btn,
                    (Juego)lbx_ListaJuegos.SelectedItem);
            
                this.Close();
            } else {
                MessageBox.Show("Debe seleccionar un juego antes.");
            }
        }

        #region Form
        private void lb_Minimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lb_Maximize_Click(object sender, System.EventArgs e)
        {
            // if (this.WindowState == FormWindowState.Maximized)
            // {
            //     this.WindowState = FormWindowState.Normal;
            //     lb_Maximize.Image = Properties.Resources.maximizar;
            // 
            // } else {
            // 
            //     this.WindowState = FormWindowState.Maximized;
            //     lb_Maximize.Image = Properties.Resources.minimizar;
            // }
        }

        private void lb_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        #region Dll Imports
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
                                int wMsg, int wParam, int lParam);

        // Permite arrastrar la ventana.
        private void FormAsignarJuego_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}