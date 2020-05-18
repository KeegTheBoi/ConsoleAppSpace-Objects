using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace ConsoleAppSpace_Objects
{
    class Program
    {
        //Massimizza la finestra di console all'inizio dell'esequzione del codice
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); 
        }

        //Matrice di stringhe che verrà utilizzato come sfondo degli oggetti
        static string[,] matriceConsole;
        //Massima altezza della finestra di console
        const int MAXHEIGHT = 40;
        const int MAXWIDTH = 167;
        //Lista di elementi constenenti gli oggetti spaziali
        static List<OggettoSpaziale> listaElementi = new List<OggettoSpaziale>();
        static void Main(string[] args)
        {
            // Nasconde il cursore.
            Console.CursorVisible = false;
            Maximize();
            //Inizializza la matrice di sfondo
            SetupConsole();
            //aggiunge gli oggetti nella lista
            AggiungiOggetti();
            //Fa partire il metodo step in tutti gli oggetti
            SetupTimer();
            Console.ReadLine();
        }

        static void SetupConsole()
        {
            matriceConsole = new string[MAXHEIGHT, MAXWIDTH];
            for(int r = 0; r < matriceConsole.GetLength(0); r++)                  
                for (int c = 0; c < matriceConsole.GetLength(1); c++)
                    matriceConsole[r, c] = " ";                      
        }
        /// <summary>
        /// Aggiunge gli oggetti nella lista
        /// </summary>
        static void AggiungiOggetti()
        {
            listaElementi.Add(new Pianeta(10, 20, matriceConsole));
            //Aggiunge un nuovo pianeta nella posizione 3 ,40
            listaElementi.Add(new Pianeta(3, 40, matriceConsole));
            
            listaElementi.Add(new Astronave("£", 8, 60, matriceConsole, 15));
            // Aggiunge un nuovo asteroide nella posizione 2 , 50
            listaElementi.Add(new Asteroide("*", 2, 50, matriceConsole, 2));

            listaElementi.Add(new Asteroide("*", 4, 60, matriceConsole, 2));
            // Aggiunge una nuova astronave nella posizione 30, 20 
            listaElementi.Add(new Astronave("£", 30, 20, matriceConsole, 5));


        }

        
        /// <summary>
        /// Finche l'utente premerà un tasto il programma continuerà a mostrare
        /// lo step di ciascun oggetto
        /// </summary>
        static public void SetupTimer()
        {
            while (true)
            {
                //Esegue il metodo astratto per ognni elemento della lista
                foreach (OggettoSpaziale os in listaElementi)
                    os.Step();
            }
        }


       
    }
}
