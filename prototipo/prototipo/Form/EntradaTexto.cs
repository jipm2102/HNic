using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class EntradaTexto : Form
    {

        public EntradaTexto()
        {
            InitializeComponent();
        }

        #region Eventos

        #region Form

        private void EntradaTexto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = this.Text;
        }

        #endregion
        #region TextBox

        private void txtEntradaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Tecla = e.KeyChar;
            switch (Tecla)
            {
                case '\r':
                    _Global.Texto = txtEntradaTexto.Text;
                    _Global.Cerrar(this);
                    break;
            }
        }

        #endregion

        #endregion

    }
}
