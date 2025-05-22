using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class clsCuadrado: clsFigura //heredamos de la clase figura
    {
        private float Lado;

        //constructor
        public clsCuadrado()
        {
            Lado = 0;
        }

        public clsCuadrado(float valor)
        {
            Lado = valor;
        }

        public clsCuadrado(clsCuadrado x)
        {
            Lado = x.Lado;
        }

        //propiedades
        public float _lado
        {
            get { return Lado; }
            set { Lado = value; }
        }
        //opcion dos a propiedades
        public float getLado()
        {
            return Lado;
        }

        public void setLado(float valor)
        {
            Lado = valor;
        }

        //metodos
        public float Area()
        {
            float res = 0;
            res = Lado * Lado;
            return res;
        }

        public float Perimetro()
        {
            float res = 0;
            res = Lado * 4;
            return res;
        }
        
    }
}
