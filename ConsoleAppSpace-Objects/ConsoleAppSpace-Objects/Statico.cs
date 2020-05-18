using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSpace_Objects
{
    /// <summary>
    /// Medoto relativo agli oggetti statici
    /// </summary>
    class Statico : OggettoSpaziale
    {
        protected string[,] _matSfondo;
        public Statico(string forma, int x, int y, string[,] matSfondo) : base(x, y)
        {

            _matSfondo = matSfondo;
            //assegnazione dell'immagine nella matrice
            _matSfondo[x, y] = forma;
            
        }
        //metodo che verrà usato nella classe derivata
        public override void Step() { }

    }
}
