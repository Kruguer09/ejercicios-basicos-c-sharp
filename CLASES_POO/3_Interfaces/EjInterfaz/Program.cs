using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjInterfaz
{
    interface IPunto
    {
        // Firmas de propiedades
        int X { get; set; }

        int Y { get; set; }
        
        double Distancia { get; }
    }

    class Punto : IPunto
    {
        // Constructor:
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Implementaciones de propiedades
        public int X { get; set; }

        public int Y { get; set; }

        public double Distancia =>
           Math.Sqrt(X * X + Y * Y);
    }

    class Program
    {
        static void ImprimirPunto(Punto p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }

        static void Main()
        {
            Punto p = new Punto(2, 3);
            Console.Write("Mi Punto: ");
            ImprimirPunto(p);
            Console.ReadKey();
        }
    }
    // Salida: Mi Punto: x=2, y=3
 }
