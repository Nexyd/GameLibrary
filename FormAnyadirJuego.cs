/// <author>Daniel Morato Baudi</author>
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    public partial class FormAnyadirJuego : Form
    {
        int calificacion;
        public FormAnyadirJuego()
        {
            InitializeComponent();
            calificacion = 0;
        }

        #region Eventos
        private void tb_Tags_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter) && !(tb_Tags.Text.Length == 0))
            {
                lbx_ListaTags.Items.Add(tb_Tags.Text);
                tb_Tags.Clear();

            } else if (tb_Tags.Text.Length == 0) {

                // ErrorProvider
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            SpecialBitmap icono = cb_Icono.Checked ? new SpecialBitmap(Properties
                .Resources.checked_star) : new SpecialBitmap(tb_Icono.Text);

            SpecialBitmap imagen = cb_Imagen.Checked ? new SpecialBitmap(Properties
                .Resources.checked_star) : new SpecialBitmap(tb_Imagen.Text);

            int internet = cb_Internet.Checked ? 1 : 0;
            int favorito = cb_Favorito.Checked ? 1 : 0;

            List<string> tags = new List<string>();
            foreach (string tag in lbx_ListaTags.Items)
                tags.Add(tag);

            Juego nuevoJuego = new Juego(
                tb_Nombre.Text, tb_Companyia.Text,
                Convert.ToInt32(mtb_Anyo.Text),
                Convert.ToInt32(mtb_Jugadores.Text),
                tb_PaginaWeb.Text, internet, 
                calificacion, tb_RutaInstalacion.Text, 
                tags, icono, imagen, favorito);
            
            nuevoJuego.InsertarEnBD(nuevoJuego, "Juegos");
            this.Close();
        }

        private void pb_Calificacion1_Click(object sender, EventArgs e)
        {
            pb_Calificacion1.Image = Properties.Resources.checked_star;
            pb_Calificacion2.Image = Properties.Resources.unchecked_star;
            pb_Calificacion3.Image = Properties.Resources.unchecked_star;
            pb_Calificacion4.Image = Properties.Resources.unchecked_star;
            pb_Calificacion5.Image = Properties.Resources.unchecked_star;

            calificacion = 1;
        }

        #region Calificación 2-5
        private void pb_Calificacion2_Click(object sender, EventArgs e)
        {
            pb_Calificacion1.Image = Properties.Resources.checked_star;
            pb_Calificacion2.Image = Properties.Resources.checked_star;
            pb_Calificacion3.Image = Properties.Resources.unchecked_star;
            pb_Calificacion4.Image = Properties.Resources.unchecked_star;
            pb_Calificacion5.Image = Properties.Resources.unchecked_star;

            calificacion = 2;
        }

        private void pb_Calificacion3_Click(object sender, EventArgs e)
        {
            pb_Calificacion1.Image = Properties.Resources.checked_star;
            pb_Calificacion2.Image = Properties.Resources.checked_star;
            pb_Calificacion3.Image = Properties.Resources.checked_star;
            pb_Calificacion4.Image = Properties.Resources.unchecked_star;
            pb_Calificacion5.Image = Properties.Resources.unchecked_star;

            calificacion = 3;
        }

        private void pb_Calificacion4_Click(object sender, EventArgs e)
        {
            pb_Calificacion1.Image = Properties.Resources.checked_star;
            pb_Calificacion2.Image = Properties.Resources.checked_star;
            pb_Calificacion3.Image = Properties.Resources.checked_star;
            pb_Calificacion4.Image = Properties.Resources.checked_star;
            pb_Calificacion5.Image = Properties.Resources.unchecked_star;

            calificacion = 4;
        }

        private void pb_Calificacion5_Click(object sender, EventArgs e)
        {
            pb_Calificacion1.Image = Properties.Resources.checked_star;
            pb_Calificacion2.Image = Properties.Resources.checked_star;
            pb_Calificacion3.Image = Properties.Resources.checked_star;
            pb_Calificacion4.Image = Properties.Resources.checked_star;
            pb_Calificacion5.Image = Properties.Resources.checked_star;

            calificacion = 5;
        }
        #endregion

        private void btn_RutaJuego_Click(object sender, EventArgs e)
        {
            ofd_RutaInstalacion.ShowDialog();
            tb_RutaInstalacion.Text = ofd_RutaInstalacion.FileName;
        }

        private void btn_Icono_Click(object sender, EventArgs e)
        {
            ofd_Icono.ShowDialog();
            tb_Icono.Text = ofd_Icono.FileName;
        }

        private void btn_Imagen_Click(object sender, EventArgs e)
        {
            ofd_Imagen.ShowDialog();
            tb_Imagen.Text = ofd_Imagen.FileName;
        }

        private void cb_Icono_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Icono.Checked)
                btn_Icono.Enabled = false;

            else if (!(cb_Icono.Checked))
                btn_Icono.Enabled = true;
        }

        private void cb_Imagen_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Imagen.Checked)
                btn_Imagen.Enabled = false;

            else if (!(cb_Imagen.Checked))
                btn_Imagen.Enabled = true;
        }

        private void tb_Tags_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void tb_Tags_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btn_Aceptar;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lb_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                lb_Maximize.Image = Properties.Resources.maximizar;

            } else {

                this.WindowState = FormWindowState.Maximized;
                lb_Maximize.Image = Properties.Resources.minimizar;
            }
        }

        private void lb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    
        #region Dll Imports
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
                                int wMsg, int wParam, int lParam);

        // Permite arrastrar la ventana.
        private void FormAnyadirJuego_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}