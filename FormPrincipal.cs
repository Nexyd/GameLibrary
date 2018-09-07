/// <author>Daniel Morato Baudi</author>
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    public partial class FormPrincipal : Form
    {
        #region Atributos
        private Juego nuevoJuego;
        private List<Juego> juegosRecientes;
        private string directorioNuevo;
        #endregion

        #region Constructor
        public FormPrincipal()
        {
            InitializeComponent();

            // directorioNuevo = Application.StartupPath;
            // directorioNuevo = directorioNuevo.Remove(
            //      directorioNuevo.LastIndexOf("\\bin\\Debug"));
            // AppDomain.CurrentDomain.SetData(
            //     "DataDirectory", directorioNuevo);

            nuevoJuego = new Juego();
            juegosRecientes = new List<Juego>();
            PrepararDatos();
        }

        public FormPrincipal(string param)
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Asigna un juego a uno de los botones de acceso rápido.
        /// </summary>
        /// <param name="juego">Juego a asignar.</param>
        /// <param name="boton">Botón al que asignaremos el juego.</param>
        internal void AsignarJuego(Button boton, Juego juego)
        {
            foreach (Control control in pn_Juegos.Controls)
                if ((control is Button) &&
                    (control.Name == boton.Name))
                    {
                        control.Text = "";
                        ((Button)control).Image =
                            juego.Icono.Bitmap;

                        control.Refresh();
                        pn_Juegos.Refresh();
                    }
        }

        /// <summary>
        /// Inicializa los datos necesarios del formulario.
        /// </summary>
        private void PrepararDatos()
        {
            ObtenerDBData("*", "Juegos");
            ObtenerDBData("*", "Recientes");
            
            ActualizarListaJuegosCompleta();
            ActualizarListaJuegosFavoritos();
            ActualizarListaJuegosRecientes();
            
            RellenarComboBox();
        }

        /// <summary>
        /// Rellena el CheckComboBox con todos los filtros.
        /// </summary>
        private void RellenarComboBox()
        {
            chbx_Busqueda.Items.Add(new CheckComboBoxItem("Nombre", false));
            chbx_Busqueda.Items.Add(new CheckComboBoxItem("Compañia", false));
            chbx_Busqueda.Items.Add(new CheckComboBoxItem("Año", false));
            chbx_Busqueda.Items.Add(new CheckComboBoxItem("Jugadores", false));
            chbx_Busqueda.Items.Add(new CheckComboBoxItem("Internet", false));
            chbx_Busqueda.Items.Add(new CheckComboBoxItem("Calificación", false));

            // Guardar en la DB todos los tags introducidos hasta el momento.
            // chbx_FiltroTags.Items.Add(new CheckComboBoxItem("NombreTag1", false));
            // chbx_FiltroTags.Items.Add(new CheckComboBoxItem("NombreTag2", false));
            // chbx_FiltroTags.Items.Add(new CheckComboBoxItem("NombreTag3", false));
        }

        /// <summary>
        /// Permite determinar que control llamó al evento.
        /// </summary>
        /// <param name="sender">Control que llamó al evento.</param>
        /// <returns></returns>
        private string ComprobarSender(object sender)
        {
            Button btn = new Button();
            string btnText = "";

            if (sender is Button)
            {
                btn = (Button)sender;
                if (btn.Tag.ToString() == "Busqueda")
                    btnText = "Busqueda";
                else if (btn.Tag.ToString() == "FiltroTags")
                    btnText = "FiltroTags";
            }

            return btnText;
        }

        /// <summary>
        /// Busca una propiedad especifica de la clase Juego.
        /// </summary>
        /// <param name="propiedad"></param>
        private string GetFilterField(Juego juego, string propiedad)
        {
            AdaptarPropiedad(ref propiedad);
            PropertyInfo propInfo = typeof(Juego).GetProperty(propiedad);
            return propInfo.GetValue(juego).ToString();
        }

        /// <summary>
        /// Reemplaza los caracteres inválidos del lenguaje.
        /// </summary>
        /// <param name="propiedad">propiedad a adaptar.</param>
        private void AdaptarPropiedad(ref string propiedad)
        {
            propiedad = propiedad
                .Replace("Compañia", "Companyia")
                .Replace("Año", "Anyo")
                .Replace("Calificación", "Calificacion");
        }

        /// <summary>
        /// Elimina y reemplaza las partes innecesarias de la consulta.
        /// </summary>
        /// <param name="busqueda">Sentencia SQL.</param>
        private void PrepararFiltroTags(ref string busqueda)
        {
            busqueda = busqueda.Remove(busqueda.LastIndexOf(","));

            // Cambiar datos por los tags correspondientes.
            busqueda = busqueda
                .Replace("Compañia", "Companyia")
                .Replace("Año", "Anyo")
                .Replace("Calificación", "Calificacion");
        }

        /// <summary>
        /// Elimina y reemplaza las partes innecesarias de la consulta.
        /// </summary>
        /// <param name="busqueda">Sentencia SQL.</param>
        private void PrepararBusqueda(ref string busqueda)
        { 
            busqueda = busqueda.Remove(busqueda.LastIndexOf(","));
            busqueda = busqueda.Replace("Compañia", "Companyia")
                               .Replace("Año", "Anyo")
                               .Replace("Calificación", "Calificacion");
        }

        /// <summary>
        /// Obtiene un CheckComboBox en función del sender.
        /// </summary>
        /// <param name="sender">Control que llamó al evento.</param>
        /// <returns></returns>
        private CheckComboBox ObtenerListaItems(object sender)
        {
            CheckComboBox chbx = new CheckComboBox();
            if (ComprobarSender(sender) == "Busqueda")
                chbx = chbx_Busqueda;
            else if (ComprobarSender(sender) == "FiltroTags")
                chbx = chbx_FiltroTags;

            return chbx;
        }

        /// <summary>
        /// Devuelve un objeto SpecialBitmap con el path asignado.
        /// </summary>
        /// <param name="path">Ruta extraida de la DB.</param>
        /// <returns>SpecialBitmap con la imagen correspondiente.</returns>
        private SpecialBitmap ObtenerImagen(string path)
        {
            if (path == "Recurso local.")
                return new SpecialBitmap(
                    Properties.Resources.icon_question);
            else
                return new SpecialBitmap(path);
        }

        /// <summary>
        /// Obtiene datos en función de la pestaña seleccionada.
        /// </summary>
        /// <param name="busqueda">Datos buscados.</param>
        /// <returns>Datos leidos.</returns>
        private void ObtenerDBData(string busqueda, string tabla)
        {
            Juego juego = new Juego();
            List<Juego> listaAux = new List<Juego>();
            System.Data.OleDb.OleDbDataReader
                    datosLeidos = nuevoJuego.
                    ConsultarBD(busqueda, tabla);

            while (datosLeidos.Read())
            {
                juego = new Juego();

                try {

                    juego.Nombre = datosLeidos.GetString(1);
                    juego.Companyia = datosLeidos.GetString(2);
                    juego.Anyo = datosLeidos.GetInt32(3);
                    juego.Jugadores = datosLeidos.GetInt32(4);
                    juego.PaginaWeb = datosLeidos.GetString(5);
                    juego.NecesitaInternet = datosLeidos.GetInt32(6);
                    juego.Calificacion = datosLeidos.GetInt32(7);
                    juego.RutaInstalacion = datosLeidos.GetString(8);
                    juego.Tags = juego.ToList(datosLeidos.GetString(9));
                    juego.Icono = ObtenerImagen(datosLeidos.GetString(10));
                    juego.Imagen = ObtenerImagen(datosLeidos.GetString(11));
                    juego.Favorito = datosLeidos.GetInt32(12);
                
                    if (tabla == "Juegos")
                        listaAux.Add(juego);
                    else if (tabla == "Recientes")
                        juegosRecientes.Add(juego);

                } catch (Exception ex) {
                    // Error
                    // Pensar como manejarlo.
                }
            }

            if (tabla == "Juegos")
                Juego.ListaJuegos = listaAux;
        }

        /// <summary>
        /// Obtiene la pestaña actual del TabControl.
        /// </summary>
        /// <param name="lista">Lista de juegos.</param>
        private void ActualizarTabPage(List<Juego> lista)
        {
            if (tc_Juegos.SelectedTab.Text == "Completa")
                ActualizarListaJuegosCompleta(lista);
            else if (tc_Juegos.SelectedTab.Text == "Favoritos")
                ActualizarListaJuegosFavoritos(lista);
            else if (tc_Juegos.SelectedTab.Text == "Recientes")
                ActualizarListaJuegosRecientes(lista);
        }

        /// <summary>
        /// Actualiza la lista de juegos completa.
        /// </summary>
        /// <param name="lista">Lista de juegos.</param>
        internal void ActualizarListaJuegosCompleta(
                           List<Juego> lista = null)
        {
            int contador = 1;
            SpecialBitmap imagen;
            ListViewItem item;
            List<string> listaNombres;
            List<string> listaRutas;
            List<Juego> listaAux;

            listaNombres = new List<string>();
            listaRutas = new List<string>();

            if (!(lista == null))
                listaAux = lista;
            else
                listaAux = Juego.ListaJuegos;

            foreach (Juego juego in listaAux)
            {
                listaNombres.Add(juego.Nombre);
                listaRutas.Add(juego.Icono.Path);
            }

            il_Completa.Images.Clear();
            lv_Completa.Items.Clear();

            imagen = new SpecialBitmap(Properties
                        .Resources.icon_question);
            il_Completa.Images.Add(imagen.Bitmap);

            foreach (string ruta in listaRutas)
            {
                if (!(ruta == "Recurso local."))
                {
                    imagen = new SpecialBitmap(ruta);
                    il_Completa.Images.Add(imagen.Bitmap);
                }
            }

            lv_Completa.LargeImageList = il_Completa;
            for (int i = 0; i < listaNombres.Count; i++)
            {
                item = new ListViewItem();
                item.Name = "lvi_Juego" + i;
                item.Text = listaNombres[i];

                if (listaRutas[i] == "Recurso local.")
                    item.ImageIndex = 0;

                else {

                    item.ImageIndex = contador;
                    contador++;
                }

                lv_Completa.Items.Add(item);
            }
        }

        /// <summary>
        /// Actualiza la lista de juegos favoritos.
        /// </summary>
        /// <param name="lista">Lista de juegos.</param>
        internal void ActualizarListaJuegosFavoritos(
                            List<Juego> lista = null)
        {
            int contador = 1;
            SpecialBitmap imagen;
            ListViewItem item;
            List<string> listaNombres;
            List<string> listaRutas;
            List<Juego> listaAux;

            listaNombres = new List<string>();
            listaRutas = new List<string>();

            if (!(lista == null))
                listaAux = lista;
            else
                listaAux = Juego.ListaJuegos;

            foreach (Juego juego in listaAux)
            {
                if (juego.Favorito == 1) // true.
                {
                    listaNombres.Add(juego.Nombre);
                    listaRutas.Add(juego.Icono.Path);
                }
            }

            il_Favoritos.Images.Clear();
            lv_Favoritos.Items.Clear();

            imagen = new SpecialBitmap(Properties
                       .Resources.icon_question);
            il_Favoritos.Images.Add(imagen.Bitmap);

            foreach (string ruta in listaRutas)
            {
                if (!(ruta == "Recurso local."))
                {
                    imagen = new SpecialBitmap(ruta);
                    il_Favoritos.Images.Add(imagen.Bitmap);
                }
            }

            lv_Favoritos.LargeImageList = il_Favoritos;
            for (int i = 0; i < listaNombres.Count; i++)
            {
                item = new ListViewItem();
                item.Name = "lvi_Juego" + i;
                item.Text = listaNombres[i];

                if (listaRutas[i] == "Recurso local.")
                    item.ImageIndex = 0;

                else {

                    item.ImageIndex = contador;
                    contador++;
                }

                lv_Favoritos.Items.Add(item);
            }
        }

        /// <summary>
        /// Actualiza la lista de juegos recientes.
        /// </summary>
        /// <param name="lista">Lista de juegos.</param>
        internal void ActualizarListaJuegosRecientes(
                            List<Juego> lista = null)
        {
            int contador = 1;
            SpecialBitmap imagen;
            ListViewItem item;
            List<string> listaNombres;
            List<string> listaRutas;
            List<Juego> listaAux;

            listaNombres = new List<string>();
            listaRutas = new List<string>();

            if (!(lista == null))
                listaAux = lista;
            else
                listaAux = juegosRecientes;

            foreach (Juego juego in listaAux)
            {
                listaNombres.Add(juego.Nombre);
                listaRutas.Add(juego.Icono.Path);
            }

            il_Recientes.Images.Clear();
            lv_Recientes.Items.Clear();

            imagen = new SpecialBitmap(Properties
                       .Resources.icon_question);
            il_Recientes.Images.Add(imagen.Bitmap);

            foreach (string ruta in listaRutas)
            {
                if (!(ruta == "Recurso local."))
                {
                    imagen = new SpecialBitmap(ruta);
                    il_Recientes.Images.Add(imagen.Bitmap);
                }
            }

            lv_Recientes.LargeImageList = il_Recientes;
            for (int i = 0; i < listaNombres.Count; i++)
            {
                item = new ListViewItem();
                item.Name = "lvi_Juego" + i;
                item.Text = listaNombres[i];

                if (listaRutas[i] == "Recurso local.")
                    item.ImageIndex = 0;

                else {

                    item.ImageIndex = contador;
                    contador++;
                }

                lv_Recientes.Items.Add(item);
            }
        }
        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            // RellenarComboBox();
            
            // ActualizarListaJuegosCompleta();
            // ActualizarListaJuegosFavoritos();
            // ActualizarListaJuegosRecientes();

            // Descomentar cuando el CheckComboBox de filtros este listo.
            // btn_FiltrarTags.Click += new System.EventHandler(btn_Buscar_Click);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Juego aux = new Juego();
            List<Juego> listaResultados = 
                        new List<Juego>();
            
            if (!(tb_BuscarJuego.Text == ""))
                foreach (CheckComboBoxItem item in ObtenerListaItems(sender).Items)
                    foreach (Juego juego in Juego.ListaJuegos)
                        if (item.CheckState == true)
                            if ((GetFilterField(juego, item.Text))
                                == (tb_BuscarJuego.Text))
                                listaResultados.Add(juego);

            ActualizarTabPage(listaResultados);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (tc_Juegos.SelectedTab.Text == "Completa")
                ActualizarListaJuegosCompleta();
            else if (tc_Juegos.SelectedTab.Text == "Favoritos")
                ActualizarListaJuegosFavoritos();
            else if (tc_Juegos.SelectedTab.Text == "Recientes")
                ActualizarListaJuegosRecientes();
        }

        #region Form
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

        private void lb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lb_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_AnyadirJuego_Click(object sender, EventArgs e)
        {
            FormAnyadirJuego formulario = new FormAnyadirJuego();
            formulario.Show();
        }

        private void lv_Completa_DoubleClick(object sender, EventArgs e)
        {
            FormMostrarJuego formulario = new FormMostrarJuego(
                lv_Completa.SelectedItems[0].Text);

            formulario.Show();
        }

        private void lv_Favoritos_DoubleClick(object sender, EventArgs e)
        {
            FormMostrarJuego formulario = new FormMostrarJuego(
                lv_Favoritos.SelectedItems[0].Text);

            formulario.Show();
        }

        private void lv_Recientes_DoubleClick(object sender, EventArgs e)
        {
            FormMostrarJuego formulario = new FormMostrarJuego(
                lv_Recientes.SelectedItems[0].Text);

            formulario.Show();
        }

        private void tsmi_AsignarJuego_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsmi.GetCurrentParent(); // Contenedor actual del sender.
            Button btn = (Button)cms.SourceControl;       // Control que accedió por ultima vez el contenedor.

            FormAsignarJuego form = new FormAsignarJuego(btn);
            form.Show();
        }

        private void btn_AccesoRapido_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (sender is Button)
                if (!(btn.Text == "Sin Asignar"))
                    MessageBox.Show("hola");
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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion   
    }
}