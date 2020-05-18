using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppSpace_Objects
{
    /// <summary>
    /// clsse astratta per gli oggeti spaziali
    /// </summary>
    abstract class OggettoSpaziale
    {
        //costruttore contenente le coordinate dell'oggetto
        public OggettoSpaziale(int x, int y)
        {
            X = x;
            Y = y;
        }

        //coordinata x
        public int X { get; set; }
        public int Y { get; set; }
        //metodo astratto Step
        public abstract void Step();

        /// <summary>
        /// Stampa la matrice nella console
        /// </summary>
        /// <param name="matrice"></param>
        protected static void StampaMatrice(ref string[,] matrice)
        {
            //ciclo in cui viene stampato l'elemento della matrice
            for (int r = 0; r < matrice.GetLength(0); r++)
            {
                for (int c = 0; c < matrice.GetLength(1); c++)
                    Console.Write(matrice[r, c]);
                //dopo aver scritto una riga va a capo
                Console.Write("\n");
            }
            //Necessario per evitare che gli oggetti lampeggino
            Thread.Sleep(100);
            //Refresha la console per un'altra stampa
            Console.Clear();
        }
    }
}
