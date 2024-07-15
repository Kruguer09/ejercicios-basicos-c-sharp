using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjConcatenarCadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string superheroe = "Superman";
            string procedencia = "Kripton";
            string superpoder = "super fuerza";

            //OPERADOR +
            string todosDatos = superheroe + " procede de " + procedencia + " y tiene " + superpoder;
            Console.WriteLine(todosDatos);
            Console.ReadLine();

            //CONCAT
            string todosDatosConcat = String.Concat(superheroe, " procede de ", procedencia, " y tiene ", superpoder);
            Console.WriteLine(todosDatosConcat);
            Console.ReadLine();

            //INTERPOLACIÓN
            string todosDatosInterpolation = $"{superheroe} procede de {procedencia} y tiene {superpoder}";
            string ejemploInterpolacion = $"{ 3 + 5 } es igual a 8?";
            Console.WriteLine(todosDatosInterpolation);
            Console.WriteLine(ejemploInterpolacion);
            Console.ReadLine();
        }


    }
}
