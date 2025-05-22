using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            char SBC = ' ';
            do
            {
                clsTriangulo Triangulo = new clsTriangulo();
                Console.WriteLine("Programa que calculo area y perimetro de un triangulo y a que equivale");
                
                Console.WriteLine("Captura el lado A del triangulo");
                Triangulo.LadoA = float.Parse(Console.ReadLine());
                Console.WriteLine("Captura el lado B del triangulo");
                Triangulo.LadoB = float.Parse(Console.ReadLine());
                Console.WriteLine("Captura el lado C del triangulo");
                Triangulo.LadoC = float.Parse(Console.ReadLine());
               
                Console.WriteLine($"\nEl area del triangulo es: {Triangulo.Area()} ");
                Console.WriteLine($"El perimetro del triangulo es: {Triangulo.Perimetro()} ");
                Console.WriteLine($"El tipo de triangulo es: {Triangulo.TipoTriangulo()} ");
                Console.WriteLine("\nOprima c/C para continuar");
                
                Console.WriteLine("Precione s/S para salir");
              
                Console.WriteLine("Oprima l/L para limpiar");
                SBC = char.Parse(Console.ReadLine());
                if (SBC == 'l' || SBC == 'L')
                {
                    Console.Clear();
                }

            } while (SBC != 's' && SBC != 'S');
            

            Console.ReadKey();
        }
    }
}
