using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods; //importo el espacio de nombres

namespace EjMetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Ejemplo de Métodos de Extensión";
            int num = s.WordCount();
            Console.WriteLine($"La cadena tiene {num} palabras.");
            Console.ReadKey();
        }
    }
 
}
