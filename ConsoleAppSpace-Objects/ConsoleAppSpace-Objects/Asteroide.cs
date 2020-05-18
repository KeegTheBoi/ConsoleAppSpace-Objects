using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSpace_Objects
{
    class Asteroide : Dinamico
    {
        int _speed;
        bool direzioneDestra = true;
        int posY, posX;
        string[,] _matBackground;
        public Asteroide(string shape, int x, int y, string[,] matSfondo, int velocita) : base (shape, x, y, matSfondo)
        {
            posY = Y; posX = X;
            _matBackground = matSfondo;
            _speed = velocita;
            _matBackground[x, y] = " ";
        }

        /// <summary>
        /// Metodo step che serve a muovere l'oggetto
        /// </summary>
        public override void Step()
        {

            if (posY < _matBackground.GetLength(1) && posY >= 0 && posX >= 0 && posX < _matBackground.GetLength(0))
            {
                if (posY == _matBackground.GetLength(1) - 1)
                    _speed = -_speed;
                else if (posY == 0)
                    direzioneDestra = true;
                if (posX == _matBackground.GetLength(0) - 2)
                {
                    direzioneDestra = false;
                    _speed = -_speed;
                }
                else if (posX == 0)
                {
                    direzioneDestra = true;
                    _speed = -_speed;
                }

                Muovi(direzioneDestra);
            }

        }

        private void Muovi(bool direzione)
        {
            
            if (direzione)
            {
                _matBackground[posX+=2, posY += _speed] = base._immagine;
                _matBackground[posX - 2, posY - _speed] = " ";
            }
            else
            {
                _matBackground[posX-=2, posY -= _speed] = base._immagine;
                _matBackground[posX + 2, posY + _speed] = " ";
            }
            StampaMatrice(ref _matBackground);
        }

       
        
    }
}
