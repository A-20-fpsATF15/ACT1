using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class clsRectangulo: clsFigura //heredamos de la clase figura
    { //creamos los atributos 
        private float Altura;
        private float Ancho;

        //definimos propiedades de los atributos (lectura y escritura)
        public float getAltura()
        {
            return Altura;
        }
        public void setAltura(float valor)
        {
            Altura = valor;
        }

        public float getAncho()
        {
            return Ancho;
        }

        public void setAncho(float valor)
        {
            Ancho = valor;
        }

        //creamos el constructor
        public clsRectangulo()
        {
            nombre = "Rectangulo";
            Altura = 0;
            Ancho = 0;
        }

        public clsRectangulo(float ba, float al)
        {
            nombre = "Rectangulo";
            Altura = al;
            Ancho = ba;
        }
        //creamos metodo perimetro
        public float Perimetro()
        {
            float res = 0;
            //res = Altura * 2 + Ancho * 2;
            //res = Altura + Altura + Ancho + Ancho;
            res = (Altura + Ancho) * 2;
            return res;
        }

        public float Area()
        {
            float res = 0;
            res = Altura * Ancho;
            return res;
        }
    }
}
