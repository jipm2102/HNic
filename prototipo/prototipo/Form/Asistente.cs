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
    public partial class Asistente : Form
    {

        #region Campos/Propiedades

        SpeechRecognitionEngine Reconocimiento = new SpeechRecognitionEngine();

        #endregion

        public Asistente()
        {
            InitializeComponent();
            CargarGramaticas();
        }

        #region Métodos

        private void BarraAudio(int NivelAudio)
        {
            int Porcentaje = (pnlAudio.Width / 100);
            pnlVolumen.Width = 0;
            pnlVolumen.Width = NivelAudio * Porcentaje;
        }

        private void Bienvenida()
        {
            tmrMostrarVoz.Stop();

            string bienvenida = $"{_Global.NombrePersona}, ¿Qué quieres conocer a cerca de Nicaragua? {_Global.Puntos(5)}";
            _Global.TextoAVoz(bienvenida, true);

            trvInformacion.Nodes[1].Nodes[1].Text = $"Nivel Audio : {_Global.NivelAudioAsistente}";
            trvInformacion.ExpandAll();
        }

        private void CargarGramaticas()
        {
            //Reconocimiento.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(_Global.Comandos))));
            Reconocimiento.LoadGrammar(new DictationGrammar());
            Reconocimiento.RequestRecognizerUpdate();
            Reconocimiento.SpeechRecognized += Reconocimiento_SpeechRecognized;
            Reconocimiento.AudioLevelUpdated += Reconocimiento_AudioLevelUpdated;
            Reconocimiento.SetInputToDefaultAudioDevice();
            Reconocimiento.RecognizeAsync(RecognizeMode.Multiple);

            _Global.Sintetizador = new SpeechSynthesizer();
            _Global.Sintetizador.SpeakCompleted += Sintetizador_SpeakCompleted;
            _Global.Sintetizador.SpeakStarted += Sintetizador_SpeakStarted;
        }

        private void EstadoReconocimiento(bool Habilitar)
        {
            if (Habilitar)
                Reconocimiento.RecognizeAsync(RecognizeMode.Multiple);
            else
            {
                Reconocimiento.RecognizeAsyncCancel();
                BarraAudio(0);
            }
            PicVozAsistente.Enabled = !Habilitar;
            panel1.Visible = !Habilitar;
            lblEstado.Visible = Habilitar;
            pnlInferior.Visible = Habilitar;
        }

        private void IrPreguntar()
        {
            new EntradaTexto() { Text = "Preguntar:" }.ShowDialog();
            Temas(_Global.Texto);
        }

        private void IrReconocimientoFacial()
        {
            new ReconocimientoFacial().ShowDialog();
        }

        private void IrSimbolosPatrios()
        {
            Image Imagen = null;
            List<string> Informacion = new List<string>();
            string Simbolo = _Global.Tema.ToUpper();
            string Tema = string.Empty;
            _Global.Tema = Tema;
            string Texto = string.Empty;

            switch (Simbolo)
            {
                case "ÁRBOL NACIONAL":
                    Imagen = Properties.Resources.arbol_nacional_de_nicaragua;
                    Informacion.Add($"Nombre Común: Madroño. Este fue declarado el Árbol Nacional de Nicaragua {_Global.Puntos(5)}");
                    Informacion.Add($"Es un árbol frondoso, leñoso de blancas ores, que tiene la característica de ser el primer árbol que orece en Nicaragua a mediados de Noviembre {_Global.Puntos(5)}");
                    Informacion.Add($"Sus flores son el adorno tradicional de los altares de las purísimas en toda Nicaragua. Su madera ha sido utilizada como leña por su alto rendimiento calórico y por el aroma que emana al quemarse.");
                    Tema = $"Símbolos Patrios : {_Global.Tema}";
                    break;
                case "AVE NACIONAL":
                    Imagen = Properties.Resources.ave_nacional_de_nicaragua;
                    Informacion.Add($"Nombre Científico: Eumomota Superciliosa, Nombre Común: Guardabarranco Común {_Global.Puntos(5)}");
                    Informacion.Add($"Esta colorida ave es fácilmente reconocida por su larga cola rematada por dos plumas azules {_Global.Puntos(5)}");
                    Informacion.Add($"Estos se alimentan principalmente de insectos. Cavan su nido en un hoyo en la tierra, para poner sus huevos. Pueden ser vistos en los bosques de Nicaragua, principalmente al sudoeste del país.");
                    Tema = $"Símbolos Patrios : {_Global.Tema}";
                    break;
                case "BANDERA NACIONAL":
                    Imagen = Properties.Resources.bandera_nacional_de_nicaragua;
                    Informacion.Add($"La Bandera Nicaragüense tiene tres franjas horizontales (dos azules, arriba y abajo) con el escudo nacional en el centro, en la franja blanca {_Global.Puntos(5)}");
                    Informacion.Add($"La franja blanca del Pabellón Nacional representa el territorio de la nación y simboliza la pureza de Nicaragua {_Global.Puntos(5)}");
                    Informacion.Add($"Las dos franjas azules significan que Nicaragua está bañado por dos océanos.");
                    Tema = $"Símbolos Patrios : {_Global.Tema}";
                    break;
                case "CINCO VOLCANES":
                    Imagen = Properties.Resources.escudo_nacional_de_nicaragua;
                    Informacion.Add($"Los cinco volcanes expresan la UNION y la FRATERNIDAD de los cinco países centroamericanos.");
                    Tema = $"Escudo Nacional : {_Global.Tema}";
                    break;
                case "ESCUDO NACIONAL":
                    Imagen = Properties.Resources.escudo_nacional_de_nicaragua;
                    Informacion.Add($"El escudo nacional es un triángulo. Rodeado circularmente con las palabras REPÚBLICA DE NICARAGUA arriba y AMÉRICA CENTRAL abajo {_Global.Puntos(5)}");
                    Informacion.Add($"Tiene la forma de un triángulo equilátero. El triángulo significa IGUALDAD. El arco iris significa PAZ {_Global.Puntos(5)}");
                    Informacion.Add($"El gorro frigio es símbolo de LIBERTAD. Los cinco volcanes expresan la UNION y la FRATERNIDAD de los cinco países centroamericanos.");
                    Tema = $"Símbolos Patrios : {_Global.Tema}";
                    break;
                case "FLOR NACIONAL":
                    Imagen = Properties.Resources.flor_nacional_de_nicaragua;
                    Informacion.Add($"Nombre Común: Sacuanjoche {_Global.Puntos(5)}");
                    Informacion.Add($"Desde las épocas precolombinas, niquiranos y chorotegas ensartaban las ores de Sacuanjoches en hilos y juntaban varias sartas para formar una verdadera cabellera o racimo de rosario de Sacuanjoches, para adornar altares y criptas funerarias {_Global.Puntos(5)}");
                    Informacion.Add($"Esa forma de preparar sartas de Sacuanjoches es una costumbre que aún se practica en Nicaragua, especialmente para el día de los difuntos. En los matrimonios precolombinos y aún entre las campesinas, racimos de Sacuanjoches se usan como adornos de las cabelleras femeninas.");
                    Tema = $"Símbolos Patrios : {_Global.Tema}";
                    break;
                case "GORRO FRIGIO":
                    Imagen = Properties.Resources.escudo_nacional_de_nicaragua;
                    Informacion.Add($"El gorro frigio es símbolo de LIBERTAD");
                    Tema = $"Escudo Nacional : {_Global.Tema}";
                    break;
                case "GUARDABARRANCO":
                    Imagen = Properties.Resources.ave_nacional_de_nicaragua;
                    Informacion.Add($"Es la Ave Nacional de Nicaragua {_Global.Puntos(5)}");
                    Informacion.Add($"Esta colorida ave es fácilmente reconocida por su larga cola rematada por dos plumas azules {_Global.Puntos(5)}");
                    Informacion.Add($"Estos se alimentan principalmente de insectos. Cavan su nido en un hoyo en la tierra, para poner sus huevos. Pueden ser vistos en los bosques de Nicaragua, principalmente al sudoeste del país.");
                    Tema = $"Ave Nacional : {_Global.Tema}";
                    break;
                case "GUARDA BARRANCO":
                    goto case "GUARDABARRANCO";
                case "HIMNO NACIONAL":
                    Imagen = Properties.Resources.himno_nacional_de_nicaragua;
                    Informacion.Add($"Constituye así mismo uno de nuestros Símbolos Patrios {_Global.Puntos(5)}");
                    Informacion.Add($"Es el más corto de América y el único que no se inspira en la \"Marsellesa\" ni proclama la guerra. Su música es de origen religioso, atribuida a un fraile: Anselmo o Ernesto Castinove. Su letra, original de Salomón Ibarra Mayorga (1887-1985) {_Global.Puntos(5)}");
                    Informacion.Add($"Fue cantado por primera vez el 16 de diciembre de 1918, pero se adoptó oficialmente en 1938.");
                    Tema = $"Símbolos Patrios : {_Global.Tema}";
                    break;
                case "PÁJARO NACIONAL":
                    goto case "AVE NACIONAL";
                case "SÍMBOLOS PATRIOS":
                    Imagen = Properties.Resources.Símbolos_patrios_de_Nicaragua;
                    Informacion.Add($"Los Símbolos patrios son:");
                    Informacion.Add($"La Bandera Nacional de Nicaragua. Escudo Nacional de Nicaragua. Himno Nacional de Nicaragua {_Global.Puntos(5)}");
                    Informacion.Add($"Ave Nacional de Nicaragua. Árbol Nacional de Nicaragua. Flor Nacional de Nicaragua.");
                    Tema = "Símbolos Patrios";
                    break;
            }

            foreach (string item in Informacion)
            { Texto += item; }
            _Global.TextoAVoz(Texto, true);
            PicFondo.BackgroundImage = Imagen;
        }

        private void Temas(string Texto)
        {
            if (vReconocimientoFacial(Texto))
                IrReconocimientoFacial();
            else if (vPreguntar(Texto))
                IrPreguntar();
            else if (vSimbolosPatrios(Texto))
                IrSimbolosPatrios();
            
            txtTema.Text = _Global.Tema;
        }

        private bool vPreguntar(string Texto)
        {
            return (Texto.ToUpper().Contains("ESCRIBIR PREGUNTA") || Texto.ToUpper().Contains("INGRESAR PREGUNTA"));
        }

        private bool vReconocimientoFacial(string Texto)
        {
            bool RF = false;
            for (int i = 0; i < _Global.ListaPalabras.Count; i++)
            {
                RF = Texto.ToUpper().Contains(_Global.ListaPalabras[i].ToUpper());
                if (RF)
                    goto Salto;
            }

            Salto:
            bool RF2 = false;
            for (int i = 0; i < _Global.ListaPalabras2.Count; i++)
            {
                RF2 = Texto.ToUpper().Contains(_Global.ListaPalabras2[i].ToUpper());
                if (RF2)
                    goto Salto2;
            }

            Salto2:
            return (RF && RF2);
        }

        private bool vSimbolosPatrios(string Texto)
        {
            bool Ir = false;
            for (int i = 0; i < _Global.SimbolosPatrios.Count; i++)
            {
                Ir = Texto.ToUpper().Contains(_Global.SimbolosPatrios[i].ToUpper());
                if (Ir)
                {
                    _Global.Tema = _Global.SimbolosPatrios[i];
                    goto Salto;
                }
            }

            Salto:
            return Ir;
        }

        #endregion

        #region Eventos

        #region Form

        private void Asistente_Load(object sender, EventArgs e)
        {
            tmrMostrarVoz.Start();
        }

        #endregion
        #region PictureBox

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            _Global.Cerrar(this);
        }

        private void PicVisibilidad_Click(object sender, EventArgs e)
        {
            pnlDerechoCentral.Visible = !pnlDerechoCentral.Visible;

            Image Imagen = Properties.Resources.Prev_32x32;
            if (pnlDerechoCentral.Visible)
                Imagen = Properties.Resources.Next_32x32;
            PicVisibilidad.Image = Imagen;
        }

        #endregion
        #region SpeechRecognitionEngine

        private void Reconocimiento_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
        {
            int NivelAudio = e.AudioLevel;
            BarraAudio(NivelAudio);
        }

        private void Reconocimiento_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string VozATexto = e.Result.Text;
            Temas(VozATexto);
        }

        #endregion
        #region SpeechSynthesizer

        private void Sintetizador_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            EstadoReconocimiento(true);
        }

        private void Sintetizador_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            EstadoReconocimiento(false);
        }

        #endregion
        #region Timer

        private void tmrMostrarVoz_Tick(object sender, EventArgs e)
        {
            _Global.ContVoz++;
            if (_Global.ContVoz == _Global.MaxContVoz)
                Bienvenida();
        }

        private void tmrVerificador_Tick(object sender, EventArgs e)
        {
            PicFondo.BackColor = (PicFondo.BackgroundImage != null) ? Color.White : Color.Black;
        }

        #endregion

        #endregion

    }
}
