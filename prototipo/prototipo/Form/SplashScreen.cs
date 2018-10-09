using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region  No Remover

using System.Speech.Recognition;
using System.Speech.Synthesis;

#endregion

namespace prototipo
{
    public partial class SplashScreen : Form
    {

        public SplashScreen()
        {
            InitializeComponent();
        }

        #region Métodos
        
        private void Bienvenida()
        {
            tmrMostrarVoz.Stop();
            _Global.ContVoz = 0;

            string[] bienvenida = 
            {
                $"¡Bienvenido al Historiador Nicaragüense!. Soy {_Global.NombreAsistente} {_Global.Puntos(10)}",
                $"¿Cuál es tu nombre? {_Global.Puntos(5)}"
            };

            _Global.TextoAVoz(bienvenida[0] + bienvenida[1], false);
            new EntradaTexto() { Text = "¿Cuál es tu nombre?"  }.ShowDialog();
            _Global.NombrePersona = _Global.Texto;
        }

        private void Inicializar()
        {
            _Global.ContVoz = 0;
            _Global.NombreAsistente = "Ana";
            _Global.Sintetizador = new SpeechSynthesizer();
        }

        private void IrAsistente()
        {
            this.Hide();
            new Asistente().ShowDialog();
            Salir();
        }

        private void Salir()
        {
            Application.Exit();
        }

        #endregion

        #region Eventos

        #region Form

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            Inicializar();
            tmrMostrarVoz.Start();
        }

        #endregion
        #region Timer

        private void tmrMostrarVoz_Tick(object sender, EventArgs e)
        {
            _Global.ContVoz++;
            switch (_Global.ContVoz)
            {
                case 2:
                    PicFondo.BackgroundImage = Properties.Resources._9111518283_d3f94aea37_z_1;
                    PicFondo.Image = null;
                    break;
                case _Global.MaxContVoz:
                    Bienvenida();
                    IrAsistente();
                    break;
            }
        }

        private void tmrVerificador_Tick(object sender, EventArgs e)
        {
 
        }

        #endregion

        #endregion

    }
}
