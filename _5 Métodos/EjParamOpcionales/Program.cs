using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjParamOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamamos a la función pasándole todos los parámetros
            Console.WriteLine("CON PROPINA-----");
            Console.WriteLine(CalcularImportePorPersona(37.65,2,1.50)+" euros.");
            Console.ReadLine();

            //Llamamos a la función sin pasarle la propina
            Console.WriteLine("SIN PROPINA-----");
            Console.WriteLine(CalcularImportePorPersona(37.65, 2) + " euros.");
            Console.ReadLine();
        }

        //Indicamos que el parámetro propina va a ser opcional al asignarle un valor en la declaración
        //de la función
        static double CalcularImportePorPersona(double importeComida, int numPersonas, double propina = 0)
        {
            double total = propina + importeComida;
            double totalPorPersona = total / numPersonas;
            return totalPorPersona;
        }
    }
}
