using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjFuncionesLocales
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 4;
            Console.WriteLine(EsPar(numero));
            Console.ReadLine();

        }

        static string EsPar(int num)
        {
            //Llamo a la función local
            string cadenaEsPar = DevuelveCadenaEsPar(num);
            
            return cadenaEsPar;
            
            //Función local
            string DevuelveCadenaEsPar(int dato)
            {
                if (dato % 2 == 0)
                    return "Es PAR";
                else
                    return "Es IMPAR";
            }
        }
    }
}
