namespace prototipo
{
    partial class EntradaTexto
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
            this.txtEntradaTexto = new System.Windows.Forms.TextBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.pnlCentral.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntradaTexto
            // 
            this.txtEntradaTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEntradaTexto.Location = new System.Drawing.Point(0, 21);
            this.txtEntradaTexto.Name = "txtEntradaTexto";
            this.txtEntradaTexto.Size = new System.Drawing.Size(500, 29);
            this.txtEntradaTexto.TabIndex = 1;
            this.txtEntradaTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntradaTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntradaTexto_KeyPress);
            // 
            // pnlCentral
            // 
            this.pnlCentral.BackColor = System.Drawing.Color.White;
            this.pnlCentral.Controls.Add(this.pnlCampos);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentral.Location = new System.Drawing.Point(0, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(700, 200);
            this.pnlCentral.TabIndex = 0;
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCampos.Controls.Add(this.lblInformacion);
            this.pnlCampos.Controls.Add(this.txtEntradaTexto);
            this.pnlCampos.Controls.Add(this.lblTitulo);
            this.pnlCampos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCampos.Location = new System.Drawing.Point(100, 65);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(500, 71);
            this.pnlCampos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(331, 50);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(169, 21);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "ENTER para Confirmar.";
            // 
            // EntradaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 200);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradaTexto";
            this.Opacity = 0.86D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntradaTexto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntradaTexto_Load);
            this.pnlCentral.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaTexto;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlCampos;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInformacion;
    }
}