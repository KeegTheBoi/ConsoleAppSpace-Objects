using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ConsoleAppSpace_Objects
{
    /// <summary>
    /// classe relativa ai solo oggetti in movimento
    /// </summary>
    class Dinamico : OggettoSpaziale
    {
        //l'immagine della dell'oggetto rappresentato da una stringa
        protected string _immagine;
        public Dinamico(string forma, int x, int y, string[,] matriceSfondo) : base(x, y)
        {
            _immagine = forma;
            //assegnazione dell'immagine nella matrice
            matriceSfondo[x, y] = _immagine;           
        }

        public override void Step() { }
    }
}
