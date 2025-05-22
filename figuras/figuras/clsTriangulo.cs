using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace figuras
{
    internal class clsTriangulo : clsFigura
    {
        //atributos
        private float ladoA;
        private float ladoB;
        private float ladoC;

        //constructor 
        
        public clsTriangulo()
        {
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }
        public clsTriangulo(float A, float B, float C)
        {
            ladoA = A;
            ladoB = B;
            ladoC = C;
        }
        //propiedades
        public float LadoA
        {
            get { return ladoA; }
            set { ladoA = value; }
        }
        public float LadoB
        {
            get { return ladoB; }
            set { ladoB = value; }
        }
        public float LadoC
        {
            get { return ladoC; }
            set { ladoC = value; }
        }
        //metodos
        
        public double Area()
        {
            double res = 0;
            
            //se aplica formula de heron

            double s = (ladoA + ladoB + ladoC) / 2;
            res = Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));   
            return res;
        }
        public float Perimetro()
        {
            float res = 0;
            res = ladoA + ladoB + ladoC;
            return res;
        }
        public string TipoTriangulo()
        { 
            string res = "";
            if (ladoA == ladoB && ladoB == ladoC)
            {
                res = "Equilatero";
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                res = "Isosceles";
            }
            else
            {
                res = "Escaleno";
            }
            return res;
        }
    }
}
