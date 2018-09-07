/// <author>Daniel Morato Baudi</author>
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    public partial class FormMostrarJuego : Form
    {
        #region Atributos
        Juego juegoMostrar;
        #endregion

        #region Constructores
        public FormMostrarJuego()
        {
            InitializeComponent();
            this.juegoMostrar = new Juego();
        }

        public FormMostrarJuego(string nombreJuego)
        {
            InitializeComponent();
            
            this.juegoMostrar = new Juego();
            this.juegoMostrar.Nombre = nombreJuego;
            this.Text = nombreJuego;
        }
        #endregion

        #region Eventos
        private void FormMostrarJuego_Load(object sender, EventArgs e)
        {
            ActualizarInformacion();
        }

        private void btn_Jugar_Click(object sender, EventArgs e)
        {
            Process juego = Process.Start(
                juegoMostrar.RutaInstalacion);
            juegoMostrar.AnyadirReciente(juegoMostrar);
        }

        private void btn_Favorito_Click(object sender, EventArgs e)
        {
            // To Do.
        }

        private void btn_CambiarIcono_Click(object sender, EventArgs e)
        {
            // To Do.
        }

        private void btn_CambiarImagen_Click(object sender, EventArgs e)
        {
            // To Do.
        }

        // Permite arrastrar la ventana.
        private void FormMostrarJuego_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        #region Métodos
        /// <summary>
        /// Permite actualizar la información del juego que muestra.
        /// </summary>
        public void ActualizarInformacion()
        {
            System.Data.OleDb.OleDbDataReader datosLeidos;
            datosLeidos = juegoMostrar.ConsultarBD(
                "*", "Juegos", "Nombre", this.juegoMostrar.Nombre);

            while (datosLeidos.Read())
            {
                // Nombre.
                lb_NombreJuego.Text = datosLeidos.GetString(1);
                juegoMostrar.Nombre = datosLeidos.GetString(1);

                // Compañia.
                lb_NombreCompanyia.Text = datosLeidos.GetString(2);
                juegoMostrar.Companyia = datosLeidos.GetString(2);

                // Año de lanzamiento.
                lb_AnyoLanzamiento.Text = datosLeidos.GetInt32(3).ToString();
                juegoMostrar.Anyo = datosLeidos.GetInt32(3);

                // Numero de jugadores.
                lb_NJugadores.Text = datosLeidos.GetInt32(4).ToString();
                juegoMostrar.Jugadores = datosLeidos.GetInt32(4);

                // Pagina web.
                lb_NombrePaginaWeb.Text = datosLeidos.GetString(5);
                juegoMostrar.PaginaWeb = datosLeidos.GetString(5);

                // Necesidad de Internet.
                ComprobarInternet(datosLeidos.GetInt32(6));
                juegoMostrar.NecesitaInternet = datosLeidos.GetInt32(6);

                // Calificación.
                EstablecerCalificacion(datosLeidos.GetInt32(7));
                juegoMostrar.Calificacion = datosLeidos.GetInt32(7);

                // Ruta de instalación.
                juegoMostrar.RutaInstalacion = datosLeidos.GetString(8);
                lb_RutaInstalacion.Text = datosLeidos.GetString(8);

                // Tags.
                lbx_Tags.Items.AddRange(RellenarTags(
                            datosLeidos.GetString(9)));
                juegoMostrar.Tags.AddRange(RellenarTags(
                            datosLeidos.GetString(9)));

                // Icono.
                AsignarIcono(datosLeidos.GetString(10));
                juegoMostrar.Icono.Path = datosLeidos.GetString(10);
                if (juegoMostrar.Icono.Path == "Recurso local.")
                    juegoMostrar.Icono = new SpecialBitmap(Properties.Resources.icon_question);
                else
                    juegoMostrar.Icono = new SpecialBitmap(juegoMostrar.Icono.Path);

                // Imagen.
                AsignarImagen(datosLeidos.GetString(11));
                juegoMostrar.Imagen.Path = datosLeidos.GetString(11);
                if (juegoMostrar.Imagen.Path == "Recurso local.")
                    juegoMostrar.Imagen = new SpecialBitmap(Properties.Resources.image_big);
                else
                    juegoMostrar.Imagen = new SpecialBitmap(juegoMostrar.Imagen.Path);

                // Favorito.
                ComprobarFavorito(datosLeidos.GetInt32(12));
                juegoMostrar.Favorito = datosLeidos.GetInt32(12);
            }
        }

        /// <summary>
        /// Permite comprobar si el juego necesita internet.
        /// </summary>
        /// <param name="estado">(Integer) Estado actual del juego mostrado.</param>
        public void ComprobarInternet(int estado)
        {
            if (estado == 1)
                lb_Internet.Text = "Si.";
            else if (estado == 0)
                lb_Internet.Text = "No.";
        }

        /// <summary>
        /// Permite asignar una nueva imagen al icono o imagen principal del juego.
        /// </summary>
        /// <param name="ruta">(String) Ruta de la imagen.</param>
        public void AsignarIcono(string ruta)
        {
            // Size tamanyo = new Size(40, 40);
            if (ruta == "Recurso local.")
            {
                pb_IconoJuego.Image = Properties.Resources.icon_question;
                // pb_IconoJuego.Image.Size = tamanyo;

            } else {

                pb_IconoJuego.Image = new Bitmap(ruta);
                // pb_IconoJuego.Image.Size = tamanyo;
            }
        }

        /// <summary>
        /// Permite asignar una nueva imagen al icono o imagen principal del juego.
        /// </summary>
        /// <param name="ruta">(String) Ruta de la imagen.</param>
        public void AsignarImagen(string ruta)
        {
            if (ruta == "Recurso local.")
                pb_ImagenPrincipal.Image = Properties.Resources.image_big;
            else
                pb_ImagenPrincipal.Image = new Bitmap(ruta);
        }

        /// <summary>
        /// Permite comprobar si el juego ha sido marcado o no como favorito.
        /// </summary>
        /// <param name="estado">(Integer) Estado actual del juego.</param>
        public void ComprobarFavorito(int estado)
        {
            if (estado == 1)
            {
                btn_Favorito.Text = "Añadido a Favoritos";
                btn_Favorito.Enabled = false;

            } else if (estado == 0) {

                btn_Favorito.Text = "Añadir a Favoritos";
                btn_Favorito.Enabled = true;
            }
        }

        /// <summary>
        /// Permite rellenar el ListBox de tags con los tags extraidos de la base de datos.
        /// </summary>
        /// <param name="tags">(String) Cadena de tags extraida.</param>
        public string[] RellenarTags(string tags)
        {
            char delimitador = ',';
            string[] listaTags;

            tags = tags.Replace(" ", "");
            listaTags = tags.Split(delimitador);

            return listaTags;
        }

        /// <summary>
        /// Permite establecer la calificacion del juego.
        /// </summary>
        /// <param name="calificacion">(Integer) Calificación numérica del juego.</param>
        public void EstablecerCalificacion(int calificacion)
        {
            switch (calificacion)
            {
                case 1:

                    pb_Calificacion1.Image = Properties.Resources.checked_star;
                    pb_Calificacion2.Image = Properties.Resources.unchecked_star;
                    pb_Calificacion3.Image = Properties.Resources.unchecked_star;
                    pb_Calificacion4.Image = Properties.Resources.unchecked_star;
                    pb_Calificacion5.Image = Properties.Resources.unchecked_star;

                    break;

                #region Case 2-5
                case 2:

                    pb_Calificacion1.Image = Properties.Resources.checked_star;
                    pb_Calificacion2.Image = Properties.Resources.checked_star;
                    pb_Calificacion3.Image = Properties.Resources.unchecked_star;
                    pb_Calificacion4.Image = Properties.Resources.unchecked_star;
                    pb_Calificacion5.Image = Properties.Resources.unchecked_star;

                    break;

                case 3:

                    pb_Calificacion1.Image = Properties.Resources.checked_star;
                    pb_Calificacion2.Image = Properties.Resources.checked_star;
                    pb_Calificacion3.Image = Properties.Resources.checked_star;
                    pb_Calificacion4.Image = Properties.Resources.unchecked_star;
                    pb_Calificacion5.Image = Properties.Resources.unchecked_star;

                    break;

                case 4:

                    pb_Calificacion1.Image = Properties.Resources.checked_star;
                    pb_Calificacion2.Image = Properties.Resources.checked_star;
                    pb_Calificacion3.Image = Properties.Resources.checked_star;
                    pb_Calificacion4.Image = Properties.Resources.checked_star;
                    pb_Calificacion5.Image = Properties.Resources.unchecked_star;

                    break;

                case 5:

                    pb_Calificacion1.Image = Properties.Resources.checked_star;
                    pb_Calificacion2.Image = Properties.Resources.checked_star;
                    pb_Calificacion3.Image = Properties.Resources.checked_star;
                    pb_Calificacion4.Image = Properties.Resources.checked_star;
                    pb_Calificacion5.Image = Properties.Resources.checked_star;

                    break;
                #endregion
            }
        }
        #endregion

        #region Dll Imports
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,
                                int wMsg, int wParam, int lParam);
        #endregion
    }
}