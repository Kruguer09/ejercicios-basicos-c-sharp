using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjClasesYEstructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un instancia de la clase Point
            Point punto = new Point();
            punto.X = 10;
            punto.Y = 8;

            //Creo una instancia de la estructura PointStruct
            PointStruct puntoStruct = new PointStruct();
            puntoStruct.X = 20;
            puntoStruct.Y = 7;

            SumaCoordenadas(punto);
            SumarCoordenadas(puntoStruct);

            Console.WriteLine($"Suma de coordenadas clase: X={punto.X} Y={punto.Y}");
            Console.WriteLine($"Suma de coordenadas struct: X={puntoStruct.X} Y={puntoStruct.Y}");
            Console.ReadKey();
        }

        //Método que recibe la clase Point (por referencia)
        public static void SumaCoordenadas(Point point)
        {
            point.X = point.X + 10;
            point.Y = point.Y + 10;
        }

        //Método que recibe la estructura PointStruct (por valor)
        public static void SumarCoordenadas(PointStruct pointStruct)
        {
            pointStruct.X = pointStruct.X + 10;
            pointStruct.Y = pointStruct.Y + 10;
        }
    }
}

