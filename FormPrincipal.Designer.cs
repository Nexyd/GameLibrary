namespace BibliotecaJuegos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pn_Juegos = new System.Windows.Forms.Panel();
            this.btn_AccesoRapido5 = new System.Windows.Forms.Button();
            this.cms_MenuAccesoRapido = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_AsignarJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AccesoRapido4 = new System.Windows.Forms.Button();
            this.btn_AccesoRapido3 = new System.Windows.Forms.Button();
            this.btn_AccesoRapido2 = new System.Windows.Forms.Button();
            this.btn_AccesoRapido1 = new System.Windows.Forms.Button();
            this.tc_Juegos = new System.Windows.Forms.TabControl();
            this.tp_JuegosCompleta = new System.Windows.Forms.TabPage();
            this.lv_Completa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_JuegosFavoritos = new System.Windows.Forms.TabPage();
            this.lv_Favoritos = new System.Windows.Forms.ListView();
            this.tp_JuegosRecientes = new System.Windows.Forms.TabPage();
            this.lv_Recientes = new System.Windows.Forms.ListView();
            this.tb_BuscarJuego = new System.Windows.Forms.TextBox();
            this.lb_BuscarJuego = new System.Windows.Forms.Label();
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AnyadirJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ajustes = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.lb_Close = new System.Windows.Forms.Label();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.il_Completa = new System.Windows.Forms.ImageList(this.components);
            this.il_Favoritos = new System.Windows.Forms.ImageList(this.components);
            this.il_Recientes = new System.Windows.Forms.ImageList(this.components);
            this.ss_Estados = new System.Windows.Forms.StatusStrip();
            this.tss_lb_Mensajes = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_Maximize = new System.Windows.Forms.Label();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.lb_FiltroTags = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_FiltrarTags = new System.Windows.Forms.Button();
            this.chbx_FiltroTags = new BibliotecaJuegos.CheckComboBox();
            this.chbx_Busqueda = new BibliotecaJuegos.CheckComboBox();
            this.pn_Juegos.SuspendLayout();
            this.cms_MenuAccesoRapido.SuspendLayout();
            this.tc_Juegos.SuspendLayout();
            this.tp_JuegosCompleta.SuspendLayout();
            this.tp_JuegosFavoritos.SuspendLayout();
            this.tp_JuegosRecientes.SuspendLayout();
            this.ms_Menu.SuspendLayout();
            this.ss_Estados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Juegos
            // 
            this.pn_Juegos.Controls.Add(this.btn_AccesoRapido5);
            this.pn_Juegos.Controls.Add(this.btn_AccesoRapido4);
            this.pn_Juegos.Controls.Add(this.btn_AccesoRapido3);
            this.pn_Juegos.Controls.Add(this.btn_AccesoRapido2);
            this.pn_Juegos.Controls.Add(this.btn_AccesoRapido1);
            this.pn_Juegos.Controls.Add(this.tc_Juegos);
            this.pn_Juegos.Location = new System.Drawing.Point(4, 95);
            this.pn_Juegos.Name = "pn_Juegos";
            this.pn_Juegos.Size = new System.Drawing.Size(537, 392);
            this.pn_Juegos.TabIndex = 9;
            // 
            // btn_AccesoRapido5
            // 
            this.btn_AccesoRapido5.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccesoRapido5.ContextMenuStrip = this.cms_MenuAccesoRapido;
            this.btn_AccesoRapido5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccesoRapido5.Location = new System.Drawing.Point(10, 318);
            this.btn_AccesoRapido5.Name = "btn_AccesoRapido5";
            this.btn_AccesoRapido5.Size = new System.Drawing.Size(67, 67);
            this.btn_AccesoRapido5.TabIndex = 4;
            this.btn_AccesoRapido5.Tag = "Asignar_5";
            this.btn_AccesoRapido5.Text = "Sin Asignar";
            this.btn_AccesoRapido5.UseVisualStyleBackColor = false;
            this.btn_AccesoRapido5.Click += new System.EventHandler(this.btn_AccesoRapido_Click);
            // 
            // cms_MenuAccesoRapido
            // 
            this.cms_MenuAccesoRapido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AsignarJuego});
            this.cms_MenuAccesoRapido.Name = "cms_MenuAccesoRapido";
            this.cms_MenuAccesoRapido.Size = new System.Drawing.Size(157, 26);
            // 
            // tsmi_AsignarJuego
            // 
            this.tsmi_AsignarJuego.Name = "tsmi_AsignarJuego";
            this.tsmi_AsignarJuego.Size = new System.Drawing.Size(156, 22);
            this.tsmi_AsignarJuego.Text = "Asignar juego...";
            this.tsmi_AsignarJuego.Click += new System.EventHandler(this.tsmi_AsignarJuego_Click);
            // 
            // btn_AccesoRapido4
            // 
            this.btn_AccesoRapido4.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccesoRapido4.ContextMenuStrip = this.cms_MenuAccesoRapido;
            this.btn_AccesoRapido4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccesoRapido4.Location = new System.Drawing.Point(10, 245);
            this.btn_AccesoRapido4.Name = "btn_AccesoRapido4";
            this.btn_AccesoRapido4.Size = new System.Drawing.Size(67, 67);
            this.btn_AccesoRapido4.TabIndex = 3;
            this.btn_AccesoRapido4.Tag = "Asignar_4";
            this.btn_AccesoRapido4.Text = "Sin Asignar";
            this.btn_AccesoRapido4.UseVisualStyleBackColor = false;
            this.btn_AccesoRapido4.Click += new System.EventHandler(this.btn_AccesoRapido_Click);
            // 
            // btn_AccesoRapido3
            // 
            this.btn_AccesoRapido3.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccesoRapido3.ContextMenuStrip = this.cms_MenuAccesoRapido;
            this.btn_AccesoRapido3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccesoRapido3.Location = new System.Drawing.Point(10, 171);
            this.btn_AccesoRapido3.Name = "btn_AccesoRapido3";
            this.btn_AccesoRapido3.Size = new System.Drawing.Size(67, 67);
            this.btn_AccesoRapido3.TabIndex = 2;
            this.btn_AccesoRapido3.Tag = "Asignar_3";
            this.btn_AccesoRapido3.Text = "Sin Asignar";
            this.btn_AccesoRapido3.UseVisualStyleBackColor = false;
            this.btn_AccesoRapido3.Click += new System.EventHandler(this.btn_AccesoRapido_Click);
            // 
            // btn_AccesoRapido2
            // 
            this.btn_AccesoRapido2.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccesoRapido2.ContextMenuStrip = this.cms_MenuAccesoRapido;
            this.btn_AccesoRapido2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccesoRapido2.Location = new System.Drawing.Point(11, 98);
            this.btn_AccesoRapido2.Name = "btn_AccesoRapido2";
            this.btn_AccesoRapido2.Size = new System.Drawing.Size(66, 67);
            this.btn_AccesoRapido2.TabIndex = 1;
            this.btn_AccesoRapido2.Tag = "Asignar_2";
            this.btn_AccesoRapido2.Text = "Sin Asignar";
            this.btn_AccesoRapido2.UseVisualStyleBackColor = false;
            this.btn_AccesoRapido2.Click += new System.EventHandler(this.btn_AccesoRapido_Click);
            // 
            // btn_AccesoRapido1
            // 
            this.btn_AccesoRapido1.BackColor = System.Drawing.Color.Transparent;
            this.btn_AccesoRapido1.ContextMenuStrip = this.cms_MenuAccesoRapido;
            this.btn_AccesoRapido1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AccesoRapido1.Location = new System.Drawing.Point(11, 25);
            this.btn_AccesoRapido1.Name = "btn_AccesoRapido1";
            this.btn_AccesoRapido1.Size = new System.Drawing.Size(66, 67);
            this.btn_AccesoRapido1.TabIndex = 0;
            this.btn_AccesoRapido1.Tag = "Asignar_1";
            this.btn_AccesoRapido1.Text = "Sin Asignar";
            this.btn_AccesoRapido1.UseVisualStyleBackColor = false;
            this.btn_AccesoRapido1.Click += new System.EventHandler(this.btn_AccesoRapido_Click);
            // 
            // tc_Juegos
            // 
            this.tc_Juegos.Controls.Add(this.tp_JuegosCompleta);
            this.tc_Juegos.Controls.Add(this.tp_JuegosFavoritos);
            this.tc_Juegos.Controls.Add(this.tp_JuegosRecientes);
            this.tc_Juegos.Location = new System.Drawing.Point(79, 3);
            this.tc_Juegos.Name = "tc_Juegos";
            this.tc_Juegos.SelectedIndex = 0;
            this.tc_Juegos.Size = new System.Drawing.Size(453, 382);
            this.tc_Juegos.TabIndex = 5;
            // 
            // tp_JuegosCompleta
            // 
            this.tp_JuegosCompleta.Controls.Add(this.lv_Completa);
            this.tp_JuegosCompleta.Location = new System.Drawing.Point(4, 22);
            this.tp_JuegosCompleta.Name = "tp_JuegosCompleta";
            this.tp_JuegosCompleta.Padding = new System.Windows.Forms.Padding(3);
            this.tp_JuegosCompleta.Size = new System.Drawing.Size(445, 356);
            this.tp_JuegosCompleta.TabIndex = 0;
            this.tp_JuegosCompleta.Text = "Completa";
            this.tp_JuegosCompleta.UseVisualStyleBackColor = true;
            // 
            // lv_Completa
            // 
            this.lv_Completa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_Completa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Completa.Location = new System.Drawing.Point(3, 3);
            this.lv_Completa.Name = "lv_Completa";
            this.lv_Completa.Size = new System.Drawing.Size(439, 350);
            this.lv_Completa.TabIndex = 0;
            this.lv_Completa.UseCompatibleStateImageBehavior = false;
            this.lv_Completa.DoubleClick += new System.EventHandler(this.lv_Completa_DoubleClick);
            // 
            // tp_JuegosFavoritos
            // 
            this.tp_JuegosFavoritos.Controls.Add(this.lv_Favoritos);
            this.tp_JuegosFavoritos.Location = new System.Drawing.Point(4, 22);
            this.tp_JuegosFavoritos.Name = "tp_JuegosFavoritos";
            this.tp_JuegosFavoritos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_JuegosFavoritos.Size = new System.Drawing.Size(445, 356);
            this.tp_JuegosFavoritos.TabIndex = 1;
            this.tp_JuegosFavoritos.Text = "Favoritos";
            this.tp_JuegosFavoritos.UseVisualStyleBackColor = true;
            // 
            // lv_Favoritos
            // 
            this.lv_Favoritos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Favoritos.Location = new System.Drawing.Point(3, 3);
            this.lv_Favoritos.Name = "lv_Favoritos";
            this.lv_Favoritos.Size = new System.Drawing.Size(439, 350);
            this.lv_Favoritos.TabIndex = 0;
            this.lv_Favoritos.UseCompatibleStateImageBehavior = false;
            this.lv_Favoritos.DoubleClick += new System.EventHandler(this.lv_Favoritos_DoubleClick);
            // 
            // tp_JuegosRecientes
            // 
            this.tp_JuegosRecientes.Controls.Add(this.lv_Recientes);
            this.tp_JuegosRecientes.Location = new System.Drawing.Point(4, 22);
            this.tp_JuegosRecientes.Name = "tp_JuegosRecientes";
            this.tp_JuegosRecientes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_JuegosRecientes.Size = new System.Drawing.Size(445, 356);
            this.tp_JuegosRecientes.TabIndex = 2;
            this.tp_JuegosRecientes.Text = "Recientes";
            this.tp_JuegosRecientes.UseVisualStyleBackColor = true;
            // 
            // lv_Recientes
            // 
            this.lv_Recientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Recientes.Location = new System.Drawing.Point(3, 3);
            this.lv_Recientes.Name = "lv_Recientes";
            this.lv_Recientes.Size = new System.Drawing.Size(439, 350);
            this.lv_Recientes.TabIndex = 0;
            this.lv_Recientes.UseCompatibleStateImageBehavior = false;
            this.lv_Recientes.DoubleClick += new System.EventHandler(this.lv_Recientes_DoubleClick);
            // 
            // tb_BuscarJuego
            // 
            this.tb_BuscarJuego.Location = new System.Drawing.Point(170, 57);
            this.tb_BuscarJuego.Name = "tb_BuscarJuego";
            this.tb_BuscarJuego.Size = new System.Drawing.Size(124, 20);
            this.tb_BuscarJuego.TabIndex = 6;
            // 
            // lb_BuscarJuego
            // 
            this.lb_BuscarJuego.AutoSize = true;
            this.lb_BuscarJuego.Location = new System.Drawing.Point(15, 60);
            this.lb_BuscarJuego.Name = "lb_BuscarJuego";
            this.lb_BuscarJuego.Size = new System.Drawing.Size(43, 13);
            this.lb_BuscarJuego.TabIndex = 10;
            this.lb_BuscarJuego.Text = "Buscar:";
            // 
            // ms_Menu
            // 
            this.ms_Menu.BackColor = System.Drawing.SystemColors.Control;
            this.ms_Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Archivo});
            this.ms_Menu.Location = new System.Drawing.Point(2, 29);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(68, 24);
            this.ms_Menu.TabIndex = 12;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // tsmi_Archivo
            // 
            this.tsmi_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AnyadirJuego,
            this.tsmi_Ajustes});
            this.tsmi_Archivo.Name = "tsmi_Archivo";
            this.tsmi_Archivo.Size = new System.Drawing.Size(60, 20);
            this.tsmi_Archivo.Text = "Archivo";
            // 
            // tsmi_AnyadirJuego
            // 
            this.tsmi_AnyadirJuego.Name = "tsmi_AnyadirJuego";
            this.tsmi_AnyadirJuego.Size = new System.Drawing.Size(151, 22);
            this.tsmi_AnyadirJuego.Text = "Añadir juego...";
            this.tsmi_AnyadirJuego.Click += new System.EventHandler(this.tsmi_AnyadirJuego_Click);
            // 
            // tsmi_Ajustes
            // 
            this.tsmi_Ajustes.Name = "tsmi_Ajustes";
            this.tsmi_Ajustes.Size = new System.Drawing.Size(151, 22);
            this.tsmi_Ajustes.Text = "Ajustes...";
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(33, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(121, 15);
            this.lb_Titulo.TabIndex = 13;
            this.lb_Titulo.Text = "Biblioteca de Juegos";
            // 
            // lb_Close
            // 
            this.lb_Close.AutoSize = true;
            this.lb_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Close.Location = new System.Drawing.Point(517, 11);
            this.lb_Close.Name = "lb_Close";
            this.lb_Close.Size = new System.Drawing.Size(15, 15);
            this.lb_Close.TabIndex = 15;
            this.lb_Close.Text = "X";
            this.lb_Close.Click += new System.EventHandler(this.lb_Close_Click);
            // 
            // lb_Minimize
            // 
            this.lb_Minimize.AutoSize = true;
            this.lb_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Minimize.Location = new System.Drawing.Point(477, 11);
            this.lb_Minimize.Name = "lb_Minimize";
            this.lb_Minimize.Size = new System.Drawing.Size(14, 15);
            this.lb_Minimize.TabIndex = 16;
            this.lb_Minimize.Text = "_";
            this.lb_Minimize.Click += new System.EventHandler(this.lb_Minimize_Click);
            // 
            // il_Completa
            // 
            this.il_Completa.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_Completa.ImageSize = new System.Drawing.Size(40, 40);
            this.il_Completa.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // il_Favoritos
            // 
            this.il_Favoritos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_Favoritos.ImageSize = new System.Drawing.Size(40, 40);
            this.il_Favoritos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // il_Recientes
            // 
            this.il_Recientes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.il_Recientes.ImageSize = new System.Drawing.Size(40, 40);
            this.il_Recientes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ss_Estados
            // 
            this.ss_Estados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lb_Mensajes});
            this.ss_Estados.Location = new System.Drawing.Point(0, 484);
            this.ss_Estados.Name = "ss_Estados";
            this.ss_Estados.Size = new System.Drawing.Size(549, 22);
            this.ss_Estados.TabIndex = 19;
            this.ss_Estados.Text = "statusStrip1";
            this.ss_Estados.Visible = false;
            // 
            // tss_lb_Mensajes
            // 
            this.tss_lb_Mensajes.Name = "tss_lb_Mensajes";
            this.tss_lb_Mensajes.Size = new System.Drawing.Size(219, 17);
            this.tss_lb_Mensajes.Text = "Aqui irán los mensajes de la aplicación...";
            this.tss_lb_Mensajes.Visible = false;
            // 
            // lb_Maximize
            // 
            this.lb_Maximize.AutoSize = true;
            this.lb_Maximize.Enabled = false;
            this.lb_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Maximize.Image = global::BibliotecaJuegos.Properties.Resources.maximizar;
            this.lb_Maximize.Location = new System.Drawing.Point(497, 11);
            this.lb_Maximize.Name = "lb_Maximize";
            this.lb_Maximize.Size = new System.Drawing.Size(16, 15);
            this.lb_Maximize.TabIndex = 17;
            this.lb_Maximize.Text = "   ";
            this.lb_Maximize.Click += new System.EventHandler(this.lb_Maximize_Click);
            // 
            // pb_Icon
            // 
            this.pb_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_Icon.Image")));
            this.pb_Icon.Location = new System.Drawing.Point(4, 8);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(23, 18);
            this.pb_Icon.TabIndex = 14;
            this.pb_Icon.TabStop = false;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::BibliotecaJuegos.Properties.Resources.actualizar;
            this.btn_Actualizar.Location = new System.Drawing.Point(500, 87);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(27, 27);
            this.btn_Actualizar.TabIndex = 8;
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // lb_FiltroTags
            // 
            this.lb_FiltroTags.AutoSize = true;
            this.lb_FiltroTags.Location = new System.Drawing.Point(329, 60);
            this.lb_FiltroTags.Name = "lb_FiltroTags";
            this.lb_FiltroTags.Size = new System.Drawing.Size(76, 13);
            this.lb_FiltroTags.TabIndex = 21;
            this.lb_FiltroTags.Text = "Filtrar por tags:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::BibliotecaJuegos.Properties.Resources.images;
            this.btn_Buscar.Location = new System.Drawing.Point(300, 55);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(23, 23);
            this.btn_Buscar.TabIndex = 23;
            this.btn_Buscar.Tag = "Busqueda";
            this.btn_Buscar.Text = " ";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_FiltrarTags
            // 
            this.btn_FiltrarTags.Image = global::BibliotecaJuegos.Properties.Resources.images;
            this.btn_FiltrarTags.Location = new System.Drawing.Point(516, 55);
            this.btn_FiltrarTags.Name = "btn_FiltrarTags";
            this.btn_FiltrarTags.Size = new System.Drawing.Size(23, 23);
            this.btn_FiltrarTags.TabIndex = 24;
            this.btn_FiltrarTags.Tag = "FiltroTags";
            this.btn_FiltrarTags.Text = " ";
            this.btn_FiltrarTags.UseVisualStyleBackColor = true;
            // 
            // chbx_FiltroTags
            // 
            this.chbx_FiltroTags.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chbx_FiltroTags.FormattingEnabled = true;
            this.chbx_FiltroTags.Location = new System.Drawing.Point(410, 57);
            this.chbx_FiltroTags.Name = "chbx_FiltroTags";
            this.chbx_FiltroTags.Size = new System.Drawing.Size(100, 21);
            this.chbx_FiltroTags.TabIndex = 22;
            // 
            // chbx_Busqueda
            // 
            this.chbx_Busqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chbx_Busqueda.FormattingEnabled = true;
            this.chbx_Busqueda.Location = new System.Drawing.Point(64, 57);
            this.chbx_Busqueda.Name = "chbx_Busqueda";
            this.chbx_Busqueda.Size = new System.Drawing.Size(100, 21);
            this.chbx_Busqueda.TabIndex = 20;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btn_FiltrarTags);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.chbx_FiltroTags);
            this.Controls.Add(this.lb_FiltroTags);
            this.Controls.Add(this.chbx_Busqueda);
            this.Controls.Add(this.ss_Estados);
            this.Controls.Add(this.lb_Maximize);
            this.Controls.Add(this.lb_Minimize);
            this.Controls.Add(this.lb_Close);
            this.Controls.Add(this.pb_Icon);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.pn_Juegos);
            this.Controls.Add(this.tb_BuscarJuego);
            this.Controls.Add(this.lb_BuscarJuego);
            this.Controls.Add(this.ms_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca de Juegos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pn_Juegos.ResumeLayout(false);
            this.cms_MenuAccesoRapido.ResumeLayout(false);
            this.tc_Juegos.ResumeLayout(false);
            this.tp_JuegosCompleta.ResumeLayout(false);
            this.tp_JuegosFavoritos.ResumeLayout(false);
            this.tp_JuegosRecientes.ResumeLayout(false);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ss_Estados.ResumeLayout(false);
            this.ss_Estados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Panel pn_Juegos;
        private System.Windows.Forms.Button btn_AccesoRapido5;
        private System.Windows.Forms.Button btn_AccesoRapido4;
        private System.Windows.Forms.Button btn_AccesoRapido3;
        private System.Windows.Forms.Button btn_AccesoRapido2;
        private System.Windows.Forms.Button btn_AccesoRapido1;
        private System.Windows.Forms.TabControl tc_Juegos;
        private System.Windows.Forms.TabPage tp_JuegosCompleta;
        private System.Windows.Forms.ListView lv_Completa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tp_JuegosFavoritos;
        private System.Windows.Forms.ListView lv_Favoritos;
        private System.Windows.Forms.TabPage tp_JuegosRecientes;
        private System.Windows.Forms.ListView lv_Recientes;
        private System.Windows.Forms.TextBox tb_BuscarJuego;
        private System.Windows.Forms.Label lb_BuscarJuego;
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Archivo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AnyadirJuego;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ajustes;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Label lb_Close;
        private System.Windows.Forms.Label lb_Minimize;
        private System.Windows.Forms.Label lb_Maximize;
        private System.Windows.Forms.ContextMenuStrip cms_MenuAccesoRapido;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AsignarJuego;
        private System.Windows.Forms.ImageList il_Completa;
        private System.Windows.Forms.ImageList il_Favoritos;
        private System.Windows.Forms.ImageList il_Recientes;
        private System.Windows.Forms.StatusStrip ss_Estados;
        public System.Windows.Forms.ToolStripStatusLabel tss_lb_Mensajes;
        private CheckComboBox chbx_Busqueda;
        private System.Windows.Forms.Label lb_FiltroTags;
        private CheckComboBox chbx_FiltroTags;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_FiltrarTags;

    }
}