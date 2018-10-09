namespace prototipo
{
    partial class Asistente
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Árbol Nacional");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Bandera Nacional");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Escudo Nacional");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Flor Nacional");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Himno Nacional");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Pájaro Nacional");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Símbolos Patrios", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Temas", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Nombre : Ana");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Nivel Audio : ");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Asistente", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Reconocimiento Facial\r");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Reconocimiento Voz");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Propiedades", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlAudio = new System.Windows.Forms.Panel();
            this.pnlVolumen = new System.Windows.Forms.Panel();
            this.tmrVerificador = new System.Windows.Forms.Timer(this.components);
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlIzquierdoSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlDerechoSuperior = new System.Windows.Forms.Panel();
            this.PicVisibilidad = new System.Windows.Forms.PictureBox();
            this.PicCerrar = new System.Windows.Forms.PictureBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlIzquierdoCentral = new System.Windows.Forms.Panel();
            this.PicFondo = new System.Windows.Forms.PictureBox();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.pnlDerechoCentral = new System.Windows.Forms.Panel();
            this.pnlTemas = new System.Windows.Forms.Panel();
            this.trvInformacion = new System.Windows.Forms.TreeView();
            this.pnlAsistente = new System.Windows.Forms.Panel();
            this.PicAsistente = new System.Windows.Forms.PictureBox();
            this.tmrMostrarVoz = new System.Windows.Forms.Timer(this.components);
            this.TipInformacion = new System.Windows.Forms.ToolTip(this.components);
            this.PicVozAsistente = new System.Windows.Forms.PictureBox();
            this.PicSep = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicSep2 = new System.Windows.Forms.PictureBox();
            this.pnlInferior.SuspendLayout();
            this.pnlAudio.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlIzquierdoSuperior.SuspendLayout();
            this.pnlDerechoSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicVisibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCerrar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            this.pnlIzquierdoCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).BeginInit();
            this.pnlInformacion.SuspendLayout();
            this.pnlDerechoCentral.SuspendLayout();
            this.pnlTemas.SuspendLayout();
            this.pnlAsistente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAsistente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicVozAsistente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSep)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSep2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.White;
            this.pnlInferior.Controls.Add(this.pnlAudio);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInferior.Location = new System.Drawing.Point(0, 391);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(805, 29);
            this.pnlInferior.TabIndex = 2;
            this.pnlInferior.Visible = false;
            // 
            // pnlAudio
            // 
            this.pnlAudio.Controls.Add(this.pnlVolumen);
            this.pnlAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAudio.Location = new System.Drawing.Point(0, 0);
            this.pnlAudio.Name = "pnlAudio";
            this.pnlAudio.Size = new System.Drawing.Size(805, 29);
            this.pnlAudio.TabIndex = 0;
            // 
            // pnlVolumen
            // 
            this.pnlVolumen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlVolumen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVolumen.Location = new System.Drawing.Point(805, 0);
            this.pnlVolumen.Name = "pnlVolumen";
            this.pnlVolumen.Size = new System.Drawing.Size(0, 29);
            this.pnlVolumen.TabIndex = 0;
            // 
            // tmrVerificador
            // 
            this.tmrVerificador.Enabled = true;
            this.tmrVerificador.Tick += new System.EventHandler(this.tmrVerificador_Tick);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.pnlIzquierdoSuperior);
            this.pnlSuperior.Controls.Add(this.pnlDerechoSuperior);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(805, 32);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlIzquierdoSuperior
            // 
            this.pnlIzquierdoSuperior.Controls.Add(this.lblTitulo);
            this.pnlIzquierdoSuperior.Controls.Add(this.lblEstado);
            this.pnlIzquierdoSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzquierdoSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdoSuperior.Name = "pnlIzquierdoSuperior";
            this.pnlIzquierdoSuperior.Size = new System.Drawing.Size(709, 32);
            this.pnlIzquierdoSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ANA : ASISTENTE VIRTUAL";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Red;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(581, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 21);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "PUEDE HABLAR";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEstado.Visible = false;
            // 
            // pnlDerechoSuperior
            // 
            this.pnlDerechoSuperior.Controls.Add(this.PicVisibilidad);
            this.pnlDerechoSuperior.Controls.Add(this.PicCerrar);
            this.pnlDerechoSuperior.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerechoSuperior.Location = new System.Drawing.Point(709, 0);
            this.pnlDerechoSuperior.Name = "pnlDerechoSuperior";
            this.pnlDerechoSuperior.Size = new System.Drawing.Size(96, 32);
            this.pnlDerechoSuperior.TabIndex = 1;
            // 
            // PicVisibilidad
            // 
            this.PicVisibilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicVisibilidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.PicVisibilidad.Image = global::prototipo.Properties.Resources.Next_32x32;
            this.PicVisibilidad.Location = new System.Drawing.Point(32, 0);
            this.PicVisibilidad.Name = "PicVisibilidad";
            this.PicVisibilidad.Size = new System.Drawing.Size(32, 32);
            this.PicVisibilidad.TabIndex = 1;
            this.PicVisibilidad.TabStop = false;
            this.PicVisibilidad.Click += new System.EventHandler(this.PicVisibilidad_Click);
            // 
            // PicCerrar
            // 
            this.PicCerrar.BackgroundImage = global::prototipo.Properties.Resources.Close_32x32;
            this.PicCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PicCerrar.Location = new System.Drawing.Point(64, 0);
            this.PicCerrar.Name = "PicCerrar";
            this.PicCerrar.Size = new System.Drawing.Size(32, 32);
            this.PicCerrar.TabIndex = 0;
            this.PicCerrar.TabStop = false;
            this.TipInformacion.SetToolTip(this.PicCerrar, "Cerrar");
            this.PicCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.White;
            this.pnlCentral.Controls.Add(this.pnlIzquierdoCentral);
            this.pnlCentral.Controls.Add(this.pnlDerechoCentral);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentral.Location = new System.Drawing.Point(0, 32);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(805, 359);
            this.pnlCentral.TabIndex = 1;
            // 
            // pnlIzquierdoCentral
            // 
            this.pnlIzquierdoCentral.Controls.Add(this.PicFondo);
            this.pnlIzquierdoCentral.Controls.Add(this.pnlInformacion);
            this.pnlIzquierdoCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIzquierdoCentral.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdoCentral.Name = "pnlIzquierdoCentral";
            this.pnlIzquierdoCentral.Size = new System.Drawing.Size(505, 359);
            this.pnlIzquierdoCentral.TabIndex = 0;
            // 
            // PicFondo
            // 
            this.PicFondo.BackColor = System.Drawing.Color.Black;
            this.PicFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicFondo.Location = new System.Drawing.Point(0, 0);
            this.PicFondo.Name = "PicFondo";
            this.PicFondo.Size = new System.Drawing.Size(505, 330);
            this.PicFondo.TabIndex = 0;
            this.PicFondo.TabStop = false;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.Controls.Add(this.txtTema);
            this.pnlInformacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInformacion.Location = new System.Drawing.Point(0, 330);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(505, 29);
            this.pnlInformacion.TabIndex = 0;
            // 
            // txtTema
            // 
            this.txtTema.BackColor = System.Drawing.Color.White;
            this.txtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTema.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTema.Enabled = false;
            this.txtTema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(0, 0);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(505, 22);
            this.txtTema.TabIndex = 0;
            this.txtTema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlDerechoCentral
            // 
            this.pnlDerechoCentral.Controls.Add(this.pnlTemas);
            this.pnlDerechoCentral.Controls.Add(this.pnlAsistente);
            this.pnlDerechoCentral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerechoCentral.Location = new System.Drawing.Point(505, 0);
            this.pnlDerechoCentral.Name = "pnlDerechoCentral";
            this.pnlDerechoCentral.Size = new System.Drawing.Size(300, 359);
            this.pnlDerechoCentral.TabIndex = 1;
            // 
            // pnlTemas
            // 
            this.pnlTemas.Controls.Add(this.trvInformacion);
            this.pnlTemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTemas.Location = new System.Drawing.Point(0, 200);
            this.pnlTemas.Name = "pnlTemas";
            this.pnlTemas.Size = new System.Drawing.Size(300, 159);
            this.pnlTemas.TabIndex = 1;
            // 
            // trvInformacion
            // 
            this.trvInformacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvInformacion.Location = new System.Drawing.Point(0, 0);
            this.trvInformacion.Name = "trvInformacion";
            treeNode15.Name = "Nodo2";
            treeNode15.Text = "Árbol Nacional";
            treeNode16.Name = "Nodo6";
            treeNode16.Text = "Bandera Nacional";
            treeNode17.Name = "Nodo0";
            treeNode17.Text = "Escudo Nacional";
            treeNode18.Name = "Nodo14";
            treeNode18.Text = "Flor Nacional";
            treeNode19.Name = "Nodo13";
            treeNode19.Text = "Himno Nacional";
            treeNode20.Name = "Nodo8";
            treeNode20.Text = "Pájaro Nacional";
            treeNode21.Name = "Nodo1";
            treeNode21.Text = "Símbolos Patrios";
            treeNode22.Name = "Nodo0";
            treeNode22.Text = "Temas";
            treeNode23.Name = "Nodo1";
            treeNode23.Text = "Nombre : Ana";
            treeNode24.Name = "Nodo2";
            treeNode24.Text = "Nivel Audio : ";
            treeNode25.Name = "Nodo0";
            treeNode25.Text = "Asistente";
            treeNode26.Name = "Nodo18";
            treeNode26.Text = "Reconocimiento Facial\r";
            treeNode27.Name = "Nodo19";
            treeNode27.Text = "Reconocimiento Voz";
            treeNode28.Name = "Nodo15";
            treeNode28.Text = "Propiedades";
            this.trvInformacion.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode25,
            treeNode28});
            this.trvInformacion.Size = new System.Drawing.Size(300, 159);
            this.trvInformacion.TabIndex = 0;
            // 
            // pnlAsistente
            // 
            this.pnlAsistente.Controls.Add(this.PicAsistente);
            this.pnlAsistente.Controls.Add(this.PicSep);
            this.pnlAsistente.Controls.Add(this.panel1);
            this.pnlAsistente.Controls.Add(this.PicSep2);
            this.pnlAsistente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAsistente.Location = new System.Drawing.Point(0, 0);
            this.pnlAsistente.Name = "pnlAsistente";
            this.pnlAsistente.Size = new System.Drawing.Size(300, 200);
            this.pnlAsistente.TabIndex = 0;
            // 
            // PicAsistente
            // 
            this.PicAsistente.BackgroundImage = global::prototipo.Properties.Resources.Ana;
            this.PicAsistente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicAsistente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicAsistente.Enabled = false;
            this.PicAsistente.Location = new System.Drawing.Point(0, 10);
            this.PicAsistente.Name = "PicAsistente";
            this.PicAsistente.Size = new System.Drawing.Size(300, 130);
            this.PicAsistente.TabIndex = 0;
            this.PicAsistente.TabStop = false;
            // 
            // tmrMostrarVoz
            // 
            this.tmrMostrarVoz.Interval = 1000;
            this.tmrMostrarVoz.Tick += new System.EventHandler(this.tmrMostrarVoz_Tick);
            // 
            // PicVozAsistente
            // 
            this.PicVozAsistente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicVozAsistente.Enabled = false;
            this.PicVozAsistente.Image = global::prototipo.Properties.Resources.ondas_sonoras;
            this.PicVozAsistente.Location = new System.Drawing.Point(6, 6);
            this.PicVozAsistente.Name = "PicVozAsistente";
            this.PicVozAsistente.Size = new System.Drawing.Size(290, 40);
            this.PicVozAsistente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicVozAsistente.TabIndex = 1;
            this.PicVozAsistente.TabStop = false;
            // 
            // PicSep
            // 
            this.PicSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicSep.Enabled = false;
            this.PicSep.Location = new System.Drawing.Point(0, 0);
            this.PicSep.Name = "PicSep";
            this.PicSep.Size = new System.Drawing.Size(300, 10);
            this.PicSep.TabIndex = 3;
            this.PicSep.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicVozAsistente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // PicSep2
            // 
            this.PicSep2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PicSep2.Enabled = false;
            this.PicSep2.Location = new System.Drawing.Point(0, 190);
            this.PicSep2.Name = "PicSep2";
            this.PicSep2.Size = new System.Drawing.Size(300, 10);
            this.PicSep2.TabIndex = 2;
            this.PicSep2.TabStop = false;
            // 
            // Asistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 420);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistente";
            this.ShowIcon = false;
            this.Text = "HNic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Asistente_Load);
            this.pnlInferior.ResumeLayout(false);
            this.pnlAudio.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlIzquierdoSuperior.ResumeLayout(false);
            this.pnlIzquierdoSuperior.PerformLayout();
            this.pnlDerechoSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicVisibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCerrar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            this.pnlIzquierdoCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).EndInit();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.pnlDerechoCentral.ResumeLayout(false);
            this.pnlTemas.ResumeLayout(false);
            this.pnlAsistente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicAsistente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicVozAsistente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSep)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicSep2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Timer tmrVerificador;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlDerechoSuperior;
        private System.Windows.Forms.PictureBox PicCerrar;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.PictureBox PicFondo;
        private System.Windows.Forms.Timer tmrMostrarVoz;
        private System.Windows.Forms.Panel pnlAudio;
        private System.Windows.Forms.Panel pnlVolumen;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlIzquierdoSuperior;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox PicVisibilidad;
        private System.Windows.Forms.Panel pnlIzquierdoCentral;
        private System.Windows.Forms.Panel pnlDerechoCentral;
        private System.Windows.Forms.Panel pnlAsistente;
        private System.Windows.Forms.Panel pnlTemas;
        private System.Windows.Forms.TreeView trvInformacion;
        private System.Windows.Forms.PictureBox PicAsistente;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.ToolTip TipInformacion;
        private System.Windows.Forms.PictureBox PicVozAsistente;
        private System.Windows.Forms.PictureBox PicSep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicSep2;
    }
}