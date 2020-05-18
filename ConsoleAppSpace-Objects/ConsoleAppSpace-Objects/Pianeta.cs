using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSpace_Objects
{
    /// <summary>
    /// classe pianeta, non sono presenti movimenti in tale contesto
    /// </summary>
    class Pianeta : Statico
    {

        //costruttore avente come immagine la figura passatogli nel base
        public Pianeta(int x, int y, string[,] matSfondo) : base("()", x, y, matSfondo) { }

        /// <summary>
        /// Metodo step che serve ad animare l'oggetto
        /// </summary>
        public override void Step()
        {
            //Stampa l'immagine statica nella matrice
            StampaMatrice(ref base._matSfondo);
        }

    }
}
