using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjValoresPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1=0, valor2=0;

            //Llamada al método con el paso de los parámetros por referencia
            RegresarValores(ref valor1, ref valor2);
            
            Console.WriteLine(valor1 + " " + valor2);
            Console.ReadKey();

        }
        //Método que recibe 2 parámetros por referencia
        public static void RegresarValores(ref int num1, ref int num2)
        {
            num1 = 45;
            num2 = 28;
        }
    }
}
