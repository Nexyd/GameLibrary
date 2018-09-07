namespace BibliotecaJuegos
{
    partial class FormAsignarJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarJuego));
            this.lb_Maximize = new System.Windows.Forms.Label();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.lb_Close = new System.Windows.Forms.Label();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.lbx_ListaJuegos = new System.Windows.Forms.ListBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Maximize
            // 
            this.lb_Maximize.AutoSize = true;
            this.lb_Maximize.Enabled = false;
            this.lb_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Maximize.Image = global::BibliotecaJuegos.Properties.Resources.maximizar;
            this.lb_Maximize.Location = new System.Drawing.Point(242, 8);
            this.lb_Maximize.Name = "lb_Maximize";
            this.lb_Maximize.Size = new System.Drawing.Size(16, 15);
            this.lb_Maximize.TabIndex = 43;
            this.lb_Maximize.Text = "   ";
            this.lb_Maximize.Click += new System.EventHandler(this.lb_Maximize_Click);
            // 
            // lb_Minimize
            // 
            this.lb_Minimize.AutoSize = true;
            this.lb_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Minimize.Location = new System.Drawing.Point(222, 8);
            this.lb_Minimize.Name = "lb_Minimize";
            this.lb_Minimize.Size = new System.Drawing.Size(14, 15);
            this.lb_Minimize.TabIndex = 42;
            this.lb_Minimize.Text = "_";
            this.lb_Minimize.Click += new System.EventHandler(this.lb_Minimize_Click);
            // 
            // lb_Close
            // 
            this.lb_Close.AutoSize = true;
            this.lb_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Close.Location = new System.Drawing.Point(262, 8);
            this.lb_Close.Name = "lb_Close";
            this.lb_Close.Size = new System.Drawing.Size(15, 15);
            this.lb_Close.TabIndex = 41;
            this.lb_Close.Text = "X";
            this.lb_Close.Click += new System.EventHandler(this.lb_Close_Click);
            // 
            // pb_Icon
            // 
            this.pb_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_Icon.Image")));
            this.pb_Icon.Location = new System.Drawing.Point(4, 8);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(23, 18);
            this.pb_Icon.TabIndex = 40;
            this.pb_Icon.TabStop = false;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(33, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(82, 15);
            this.lb_Titulo.TabIndex = 39;
            this.lb_Titulo.Text = "Asignar juego";
            // 
            // lbx_ListaJuegos
            // 
            this.lbx_ListaJuegos.FormattingEnabled = true;
            this.lbx_ListaJuegos.Location = new System.Drawing.Point(12, 41);
            this.lbx_ListaJuegos.Name = "lbx_ListaJuegos";
            this.lbx_ListaJuegos.Size = new System.Drawing.Size(260, 212);
            this.lbx_ListaJuegos.TabIndex = 44;
            this.lbx_ListaJuegos.DoubleClick += new System.EventHandler(this.lbx_ListaJuegos_DoubleClick);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(94, 259);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(97, 23);
            this.btn_Aceptar.TabIndex = 45;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // FormAsignarJuego
            // 
            this.AcceptButton = this.btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbx_ListaJuegos);
            this.Controls.Add(this.lb_Maximize);
            this.Controls.Add(this.lb_Minimize);
            this.Controls.Add(this.lb_Close);
            this.Controls.Add(this.pb_Icon);
            this.Controls.Add(this.lb_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAsignarJuego";
            this.Text = "FormAsignarJuego";
            this.Load += new System.EventHandler(this.FormAsignarJuego_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAsignarJuego_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Maximize;
        private System.Windows.Forms.Label lb_Minimize;
        private System.Windows.Forms.Label lb_Close;
        private System.Windows.Forms.PictureBox pb_Icon;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.ListBox lbx_ListaJuegos;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}