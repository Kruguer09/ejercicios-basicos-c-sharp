using System;

namespace Tuplas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            (valor1, valor2) = RegresarValores();
            Console.WriteLine(valor1 + " " + valor2);

        }

        public static (int, int) RegresarValores()
        {
            return (45, 28);
        }

    }
}
