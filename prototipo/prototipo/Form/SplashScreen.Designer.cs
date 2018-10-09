namespace prototipo
{
    partial class SplashScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.PicFondo = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblNicaragua = new System.Windows.Forms.Label();
            this.tmrVerificador = new System.Windows.Forms.Timer(this.components);
            this.tmrMostrarVoz = new System.Windows.Forms.Timer(this.components);
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCentral.Controls.Add(this.PicFondo);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentral.Location = new System.Drawing.Point(0, 100);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(805, 300);
            this.pnlCentral.TabIndex = 1;
            // 
            // PicFondo
            // 
            this.PicFondo.BackColor = System.Drawing.Color.White;
            this.PicFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicFondo.Image = global::prototipo.Properties.Resources.bandera_argentina_animada;
            this.PicFondo.Location = new System.Drawing.Point(0, 0);
            this.PicFondo.Name = "PicFondo";
            this.PicFondo.Size = new System.Drawing.Size(805, 300);
            this.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicFondo.TabIndex = 1;
            this.PicFondo.TabStop = false;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperior.Controls.Add(this.lblNicaragua);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(805, 100);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblNicaragua
            // 
            this.lblNicaragua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNicaragua.AutoSize = true;
            this.lblNicaragua.BackColor = System.Drawing.Color.White;
            this.lblNicaragua.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNicaragua.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNicaragua.Location = new System.Drawing.Point(-2, 15);
            this.lblNicaragua.Name = "lblNicaragua";
            this.lblNicaragua.Size = new System.Drawing.Size(809, 71);
            this.lblNicaragua.TabIndex = 0;
            this.lblNicaragua.Text = "HISTORIADOR NICARAGUENSE";
            this.lblNicaragua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrVerificador
            // 
            this.tmrVerificador.Enabled = true;
            this.tmrVerificador.Tick += new System.EventHandler(this.tmrVerificador_Tick);
            // 
            // tmrMostrarVoz
            // 
            this.tmrMostrarVoz.Interval = 1000;
            this.tmrMostrarVoz.Tick += new System.EventHandler(this.tmrMostrarVoz_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 400);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.Text = "HNic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicFondo)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblNicaragua;
        private System.Windows.Forms.Timer tmrVerificador;
        private System.Windows.Forms.Timer tmrMostrarVoz;
        private System.Windows.Forms.PictureBox PicFondo;
    }
}

