using System;

namespace EjTuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            (valor1, valor2) = RegresarValores();
            Console.WriteLine(valor1 + " " +valor2);
        }
        
        //FUNCIÓN que devuelve una tupla con 2 valores enteros
        public static (int, int) RegresarValores()
        {
            return (45, 28);
        }
    }
}
