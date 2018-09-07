/// <author>Daniel Morato Baudi</author>
using System.Collections.Generic;
using System.Data.OleDb;

namespace BibliotecaJuegos
{
    /// <summary>
    /// Esta clase almacenará los métodos y atributos 
    /// para insertar un juego en la base de datos.
    /// </summary>
    class Juego
    {
        #region Atributos
        private string nombre;
        private string companyia;
        private int anyo;
        private int jugadores;
        private string paginaWeb;
        private int necesitaInternet;
        private int calificacion;
        private string rutaInstalacion;
        private List<string> tags;
        private SpecialBitmap icono;
        private SpecialBitmap imagen;
        private int favorito;
        private BaseDatos DB;

        private static List<Juego> 
            listaJuegos = new List<Juego>();
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor vacío de la clase Juego.
        /// </summary>
        public Juego()
        {
            this.nombre = "";
            this.companyia = "";
            this.anyo = 0;
            this.jugadores = 0;
            this.paginaWeb = "";
            this.necesitaInternet = 1;
            this.calificacion = 0;
            this.rutaInstalacion = "";
            this.tags = new List<string>();
            this.icono = new SpecialBitmap(
                Properties.Resources.icon_question);
            this.imagen = new SpecialBitmap(
                Properties.Resources.image_big);
            this.favorito = 0;
            this.DB = new BaseDatos();
        }

        /// <summary>
        /// Constructor por parametros de la clase Juego.
        /// </summary>
        /// <param name="nombre">(String) Nombre del juego.</param>
        /// <param name="companyia">(String) Compañia desarrolladora del juego</param>
        /// <param name="anyo">(Integer) Año de lanzamiento.</param>
        /// <param name="jugadores">(Integer) Nº de jugadores.</param>
        /// <param name="paginaWeb">(String) Página web del juego.</param>
        /// <param name="necesitaInternet">(Bool) Indica si el juego necesita o no internet para funcionar.</param>
        /// <param name="calificacion">(Integer) Calificación del juego.</param>
        /// <param name="rutaInstalacion">(String) Ruta completa donde se encuentra el ejecutable del juego.</param>
        /// <param name="tags">(List(String)) Etiquetas asociadas al juego.</param>
        /// <param name="icono">(SpecialBitmap) Icono del juego.</param>
        /// <param name="imagen">(SpecialBitmap) Imagen principal del juego.</param>
        /// <param name="favorito">(Integer) Indica si el juego esta marcado o no como favorito.</param>
        public Juego(string nombre, string companyia, int anyo,
                     int jugadores, string paginaWeb, int necesitaInternet,
                     int calificacion, string rutaInstalacion, List<string> tags,
                     SpecialBitmap icono, SpecialBitmap imagen, int favorito)
        {
            this.nombre = nombre;
            this.companyia = companyia;
            this.anyo = anyo;
            this.jugadores = jugadores;
            this.paginaWeb = paginaWeb;
            this.necesitaInternet = necesitaInternet;
            this.calificacion = calificacion;
            this.rutaInstalacion = rutaInstalacion;

            this.tags = new List<string>();
            foreach (string tag in tags)
                this.tags.Add(tag);

            this.icono = icono;
            this.imagen = imagen;
            this.favorito = favorito;
            this.DB = new BaseDatos();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Añade un juego reciente a la base de datos.
        /// </summary>
        /// <param name="juegoInsertar">Juego a insertar en la DB.</param>
        public void AnyadirReciente(Juego juegoInsertar)
        {
            OleDbDataReader datosLeidos;
            int contador = 0;

            datosLeidos = ConsultarBD("Nombre", "Recientes");
            while (datosLeidos.Read())
                contador++;

            if (contador >= 8)
            {
                BorrarDeBD("Recientes", "Id", ObtenerIdAntiguo());
                InsertarEnBD(juegoInsertar, "Recientes");

            } else {

                InsertarEnBD(juegoInsertar, "Recientes");
            }

            // Form1 formulario = new Form1();
            // formulario.ActualizarListaJuegosRecientes();
        }

        /// <summary>
        /// Obtiene el Id más antiguo de la taba Recientes.
        /// </summary>
        /// <returns>Devuelve el Id.</returns>
        public string ObtenerIdAntiguo()
        {
            OleDbDataReader datosLeidos;
            List<int> listaId = new List<int>();

            datosLeidos = ConsultarBD("Id", "Recientes");
            while (datosLeidos.Read())
                listaId.Add(datosLeidos.GetInt32(0));

            OrdenarBurbuja(listaId);
            return listaId[0].ToString();
        }

        /// <summary>
        /// Ordena una lista mediante el algoritmo de la burbuja.
        /// </summary>
        /// <param name="lista">Lista a ordenar.</param>
        public void OrdenarBurbuja(List<int> lista)
        {
            int aux = 0;
            for (int i = 1; i > lista.Count; i++)
                for (int j = 1; j > lista.Count - 2; j++)
                    if (lista[j] > lista[j - 2])
                    {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
        }

        // Metodos
        /// <summary>
        /// Inserta un nuevo juego en la base de datos.
        /// </summary>
        /// <param name="nuevoJuego">Juego a insertar en la base de datos.</param>
        /// <param name="tablaInsertar">Tabla en que se insertara el juego.</param>
        public void InsertarEnBD(Juego nuevoJuego, string tablaInsertar)
        {
            FormPrincipal form = new FormPrincipal("");
            string insercion = "INSERT INTO " + tablaInsertar + "(Nombre, Companyia," + 
                "Anyo, Jugadores, PaginaWeb, Internet, Calificacion, RutaInstalacion," +
                "Tags, RutaIcono, RutaImagen, Favorito) VALUES (@Nombre, @Companyia," +
                "@Anyo, @Jugadores, @PaginaWeb, @Internet, @Calificacion, @RutaInstalacion, " + 
                "@Tags, @RutaIcono, @RutaImagen, @Favorito);";

            DB.Orden.Parameters.AddWithValue("@Nombre", nuevoJuego.Nombre);
            DB.Orden.Parameters.AddWithValue("@Companyia", nuevoJuego.Companyia);
            DB.Orden.Parameters.AddWithValue("@Anyo", nuevoJuego.Anyo);
            DB.Orden.Parameters.AddWithValue("@Jugadores", nuevoJuego.Jugadores);
            DB.Orden.Parameters.AddWithValue("@PaginaWeb", nuevoJuego.PaginaWeb);
            DB.Orden.Parameters.AddWithValue("@Internet", nuevoJuego.NecesitaInternet);
            DB.Orden.Parameters.AddWithValue("@Calificacion", nuevoJuego.Calificacion);
            DB.Orden.Parameters.AddWithValue("@RutaInstalacion", nuevoJuego.RutaInstalacion);
            DB.Orden.Parameters.AddWithValue("@Tags", ToDBString(nuevoJuego.Tags));
            DB.Orden.Parameters.AddWithValue("@RutaIcono", nuevoJuego.Icono.Path);
            DB.Orden.Parameters.AddWithValue("@RutaImagen", nuevoJuego.Imagen.Path);
            DB.Orden.Parameters.AddWithValue("@Favorito", nuevoJuego.Favorito);

            DB.Insertar(insercion);
            InsertarTags(nuevoJuego.Tags);
            ListaJuegos.Add(nuevoJuego);

            // form.tss_lb_Mensajes.Text = DB.Insertar(insercion);
            // form.tss_lb_Mensajes.Visible = true;
            
            // InsertarTags(nuevoJuego.Tags);
            // ListaJuegos.Add(nuevoJuego);
            form.ActualizarListaJuegosCompleta();
        }

        /// <summary>
        /// Inserta los nuevos tags en la DB.
        /// </summary>
        /// <param name="tags">Lista de tags a insertar.</param>
        public void InsertarTags(List<string> tags)
        {
            
        }

        /// <summary>
        /// Extrae datos de la base de datos.
        /// </summary>
        /// <param name="campoBuscado">Campo que se desea extraer de la base de datos.</param>
        /// <param name="campoFiltrar">(Optional) Filtro a aplicar a la busqueda.</param>
        /// <param name="datoFiltrar">(Optional) Dato a filtrar en la busqueda.</param>
        /// <param name="operador">(Optional) Operador usado para filtrar en la busqueda.</param>
        /// <returns>Colección de datos extraida.</returns>
        public OleDbDataReader ConsultarBD(string campoBuscado, string tablaBuscada,
                                           string campoFiltrar = "", string datoFiltrar = "", 
                                           string operador = "")
        {
            string[] campos = new string[6];
            string[] datos  = new string[2];
            string consulta = "SELECT " + campoBuscado
                             + " FROM " + tablaBuscada;

            // Comprobamos si se ha de filtrar por favorito.
            if (campoFiltrar.Contains(",Favorito"))
                datos = datoFiltrar.Split(',');
            else
                datos[1] = datoFiltrar;

            // Comprobamos si se ha introducido mas de un campo a filtrar.
            if (campoFiltrar.Contains(","))
                campos = campoFiltrar.Split(',');
            else
                campos[0] = campoFiltrar;

            // Aplicar filtro WHERE.
            if ((campoFiltrar.Length > 0) && (datoFiltrar.Length > 0))
                if (ManejoErrores.EsNumero(datoFiltrar))
                    consulta += " WHERE " + campos[0] +
                                " = " + datos[1] + "";
                else
                    consulta += " WHERE " + campos[0] +
                                " = '" + datos[1] + "'";

            // Aplicar operador AND u OR.
            if (datos[0] != null)
                consulta += " AND " + campos[
                    campos.Length - 1] + " = " 
                    + datos[0];

            if ((operador == "OR") || (operador == "AND"))
                for (int i = 1; i < campos.Length; i++)
                    if (ManejoErrores.EsNumero(datoFiltrar))
                        consulta += " " + operador + " "
                            + campos[i] + " = " + datos[1];
                    else
                        consulta += " " + operador +
                            " " + campos[i] + " = '"
                            + datos[1] + "'";

            return DB.Consultar(consulta);
        }

        /// <summary>
        /// Borra una entrada de la base de datos.
        /// </summary>
        /// <param name="tablaBuscada">Tabla de la cual queremos borrar la entrada.</param>
        /// <param name="campoFiltrar">(Optional) Campo utilizado para filtrar.</param>
        /// <param name="datoFiltrar">(Optional) Datos para filtrar.</param>
        public void BorrarDeBD(string tablaBuscada, string campoFiltrar = "", 
                               string datoFiltrar = "")
        {
            string borrado = "DELETE * FROM " + tablaBuscada;
            if ((campoFiltrar.Length > 0) && (datoFiltrar.Length > 0))
            {
                if (ManejoErrores.EsNumero(datoFiltrar))
                    borrado += " WHERE " + campoFiltrar +
                                " = " + datoFiltrar + "";
                else
                    borrado += " WHERE " + campoFiltrar +
                                " = '" + datoFiltrar + "'";
            }
        }

        /// <summary>
        /// Convierte una lista de strings en una única cadena para insertar en la DB.
        /// </summary>
        /// <param name="Lista">Lista de strings a convertir.</param>
        /// <returns>Cadena de strings lista para insertar a DB.</returns>
        public string ToDBString(List<string> lista)
        {
            string cadena = "";
            foreach (string elemento in lista)
                cadena += elemento + ", ";

            cadena = cadena.Remove(cadena.LastIndexOf(", "));
            return cadena;
        }

        /// <summary>
        /// Convierte a List<string> una cadena.
        /// </summary>
        /// <param name="cadena">cadena a convertir.</param>
        /// <returns></returns>
        public List<string> ToList(string cadena)
        {
            List<string> lista = new List<string>();
            string[] listaAux;

            cadena.Replace(" ", "");
            listaAux = cadena.Split(',');

            for (int i = 0; i < listaAux.Length; i++)
                lista.Add(listaAux[i]);

            return lista;
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Companyia
        {
            get { return this.companyia; }
            set { this.companyia = value; }
        }
        public int Anyo
        {
            get { return this.anyo; }
            set { this.anyo = value; }
        }
        public int Jugadores
        {
            get { return this.jugadores; }
            set { this.jugadores = value; }
        }
        public string PaginaWeb
        {
            get { return this.paginaWeb; }
            set { this.paginaWeb = value; }
        }
        public int NecesitaInternet
        {
            get { return this.necesitaInternet; }
            set { this.necesitaInternet = value; }
        }
        public int Calificacion
        {
            get { return this.calificacion; }
            set { this.calificacion = value; }
        }
        public string RutaInstalacion
        {
            get { return this.rutaInstalacion; }
            set { this.rutaInstalacion = value; }
        }
        public List<string> Tags
        {
            get { return this.tags; }
            set { foreach (string tag in value)
                    this.tags.Add(tag); }
        }
        public SpecialBitmap Icono
        {
            get { return this.icono; }
            set { this.icono = value; }
        }
        public SpecialBitmap Imagen
        {
            get { return this.imagen; }
            set { this.imagen = value; }
        }
        public int Favorito
        {
            get { return this.favorito; }
            set { this.favorito = value; }
        }

        public static List<Juego> ListaJuegos
        {
            get { return listaJuegos; }
            set { foreach (Juego juego in value)
                    listaJuegos.Add(juego); }
        }
        #endregion
    }
}