using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Enemigo
    {
        public int posicionX { get; set; }
        public int posicionY { get; set; }

        private int _puntos;
        public int Puntos
        {
            get
            {
                return _puntos;
            }

            set
            {
                if (value >= 100)
                {
                    _puntos = value;
                }
                else
                {
                    throw new Exception("El puntaje debe ser mayor que 100");
                }

            }
        }
        public void moverse()
        {

        }
        public void disparar ()
        {

        }
        public void explotar ()
        {

        }
    }
    
}
