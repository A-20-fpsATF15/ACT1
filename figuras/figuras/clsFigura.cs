  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class clsFigura
    {
        //atributos
        protected string nombre;

        //propiedades
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string valor)
        {
            nombre = valor;
        }

        //constructor
        public clsFigura()
        {
            nombre = "";
        }

        //metodos
        public float Area()
        {
            float res = 0;
            return res;
        }

        public float Perimetro()
        {
            return 0;
        }
    }
}
