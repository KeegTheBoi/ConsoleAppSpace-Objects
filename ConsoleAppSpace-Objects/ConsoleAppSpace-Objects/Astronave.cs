using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppSpace_Objects
{
    class Astronave : Dinamico
    {
        int i;
        string[,] _matBackground;
        int _velocita;
        public Astronave(string shape, int x, int y, string[,] matriceSfondo, int velocita) : base(shape, x, y, matriceSfondo)
        {
            _velocita = velocita;
            i = Y;
            _matBackground = matriceSfondo;
        }
        bool direzioneDestra = true;

        /// <summary>
        /// Metodo step che serve ad muovere lateralmente l'oggetto
        /// </summary>
        public override void Step()
        {
            //verifica se l'oggetto è nei limiti della finestra
            if (i < _matBackground.GetLength(1) && i >= 0)
            {
                //se raggiunge il bordo destro modifica la direzione dell'oggetto
                if (i == _matBackground.GetLength(1)-2)
                    direzioneDestra = false;
                //se raggiunge il bordo sinstro modifica la direzione dell'oggetto
                else if (i == 0)
                    direzioneDestra = true;
                //Muovi oggetto in base alla direazione
                Muovi(direzioneDestra);
            }
            
        }

        /// <summary>
        /// Muove l'oggetto lateralmente
        /// </summary>
        /// <param name="direzione"></param>
        private void Muovi(bool direzione)
        {
            //verifica quale direzione poter scegiere per effettuare il movimento
            if (direzione)
            {
                //muove verso destra
                _matBackground[X, i+= _velocita] = base._immagine;
                //elimina la stringa precedente
                _matBackground[X, i - _velocita] = " ";
            }
            else
            {
                _matBackground[X, i-= _velocita] = base._immagine;
                _matBackground[X, i + _velocita] = " ";
            }
            StampaMatrice(ref _matBackground);
            
        }
    }
}
