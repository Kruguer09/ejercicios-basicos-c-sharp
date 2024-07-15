using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("Hola soy Batman");

            //Añado texto sin saltos de línea
            sb.Append("Hola soy Batman");
            sb.Append(" y vivo en Gotham");
            Console.WriteLine(sb);
            Console.ReadLine();

            //Añado texto y salto de línea al final
            sb2.AppendLine(" y vivo en Gotham");
            //Añado texto aplicando un elemento de formato
            sb2.AppendFormat("Actualmente {0:dd/MM/yyyy}", DateTime.Now);
            Console.WriteLine(sb2);
            Console.ReadLine();

            //Cadena interpolada donde muestro el nº de caracteres de sb2
            Console.WriteLine($"La longitud de la cadena sb2 es {sb2.Length}");
            Console.ReadLine();
        }

    }
}
