using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region No Remover

using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

#endregion

namespace prototipo
{
    public class _Global
    {
        //He puesto un comentario 

        #region Campos/Propiedades/Estructuras

        public const int MaxContVoz = 3;

        public static int  ContVoz { get; set; }
        public static List<string> ListaPalabras
        {
            get
            {
                return new List<string>()
                {
                    "conocer",
                    "identificar",
                    "saber",
                };
            }
        }
        public static List<string> ListaPalabras2
        {
            get {
                    return new List<string>()
                    {
                        "cara",
                        "foto",
                        "imagen",
                        "rostro"
                    };
                }
        }
        public static int NivelAudioAsistente { get { return Sintetizador.Volume; } }
        public static string NombreAsistente { get; set; }
        public static string NombrePersona { get; set; }
        public static List<string> SimbolosPatrios
        {
            get
            {
                return new List<string>()
                {
                    "árbol nacional",
                    "ave nacional",
                    "Guardabarranco",
                    "Guarda barranco",
                    "bandera nacional",
                    "escudo nacional",
                    "gorro frigio",
                    "cinco volcanes",
                    "flor nacional",
                    "himno nacional",
                    "pájaro nacional",
                    "símbolos patrios",
                };
            }
        }
        public static SpeechSynthesizer Sintetizador { get; set; }
        public static string Tema { get; set; }
        public static string Texto { get; set; }

        #endregion

        #region Métodos        

        public static void Cerrar(Form form)
        {
            form.Close();
        }

        public static string Espacios(int Numero)
        {
            string numeroEspacios = String.Empty;
            for (int i = 0; i < Numero; i++)
            {
                numeroEspacios += " ";
            }
            return numeroEspacios;
        }

        public static string Puntos(int Numero)
        {
            string numeroPuntos = ".";
            for (int i = 0; i < Numero; i++)
            {
                numeroPuntos += numeroPuntos;
            }
            return numeroPuntos;
        }

        public static void TextoAVoz(string textoAVoz, bool Asincrono)
        {
            if (Asincrono)
                Sintetizador.SpeakAsync(textoAVoz);
            else
                Sintetizador.Speak(textoAVoz);
        }

        #endregion

    }
}
