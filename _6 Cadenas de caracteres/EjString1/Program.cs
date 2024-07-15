using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjString1
{
    class Program
    {
        static void Main(string[] args)

        {
            string villano = "Gru";
            string esbirros = "Minions";
            string frase = "Los minions ayudan a Gru a conquistar el mundo";

            //Concatenar cadenas
            Console.Write("CONCAT:\nvillano={0} + tiene + esbirros={1}\n",villano, esbirros);
            string concatenar = String.Concat(villano, " tiene ", esbirros);
            Console.WriteLine(concatenar);
            Console.ReadLine();

            //Encontrar cadena
            Console.Write("CONTAINS:\nCompruebo si la variable villano contiene la cadena \"ru\"");
            if (villano.Contains("ru"))
            {
                Console.Write("\nSí la contiene porque villano={0}\n", villano);
            }
            Console.ReadLine();

            //Encontrar cadena
            Console.Write("Compruebo si la variable esbirros contiene la cadena \"Minions\"");
            if (esbirros.Contains("Minions"))
            {
                Console.Write("\nSí la contiene porque esbirros={0}\n", esbirros);
            }
            Console.ReadLine();
            
            //Obtener subcadena
            Console.Write("SUBSTRING:\nExtraígo 7 caracteres a partir de la posición 4 en:\n"); 
            Console.Write("frase=\"Los minions ayudan a Gru a conquistar el mundo\"");
            string subcadena = frase.Substring(4, 7);
            Console.Write("\n=>{0}\n",subcadena);
            Console.ReadLine();

            //Buscar si la cadena acaba en...
            Console.Write("ENDSWITH:\nCompruebo si la variable frase acaba con \"mundo\"");
            if (frase.EndsWith("mundo"))
            {
                Console.Write("\nSí acaba porque frase={0}\n", frase);
            }
            Console.ReadLine();

            //Insertar una cadena en otra
            Console.Write("INSERT:\nInserto en la cadena frase={0}", frase);
            Console.Write("\nla cadena \" adorables\" en la posición 3 teniendo en cuenta que la 1ª posición es la 0\n");
            frase = frase.Insert(3, " adorables");
            Console.WriteLine(frase);
            Console.ReadLine();

            //Encontrar la última posicion en la que aparece una cadena
            Console.Write("LASTINDEXOF:\nBuscamos la última posición en la que aparece la cadena \" a \"");
            int posicion = frase.LastIndexOf(" a ");
            Console.Write("\nen la frase={0}\nLa posición es la {1}",frase,posicion);
            Console.ReadLine();

            //Encontrar la primera posicion de una cadena
            Console.Write("\nINDEXOF:\nBuscamos la primera posición en la que aparece la cadena \"mundo\"");
            posicion = frase.IndexOf("mundo");
            Console.Write("\nen la frase={0}\nLa posición es la {1}", frase, posicion);
            Console.ReadLine();

            //Borrar una subcadena
            Console.Write("\nREMOVE:\nBorramos la palabra \"adorables\" de la frase.");
            Console.Write("\nPara ello, obtenemos la posición en la que se encuentra esta palabra y borramos 10 caracteres\n");
            int posicion2 = frase.IndexOf("adorables");
            frase = frase.Remove(posicion2, 10);
            Console.WriteLine(frase);
            Console.ReadLine();

            //Reemplazar cadena
            Console.Write("REPLACE:\nReemplazamos la cadena \"el mundo\" por la cadena \"la luna\"\n");
            frase = frase.Replace("el mundo", "la luna");
            Console.WriteLine(frase);
            Console.ReadLine();

            //Dividir cadena
            Console.Write("SPLIT:\nSeparamos la frase en palabras, usando el delimitador ' '\n");
            var palabras = frase.Split(' ');
            foreach (var palabra in palabras)
            {
                Console.WriteLine(palabra);
            }
            Console.ReadLine();

            //Pasar mayusculas y minuculas
            Console.Write("TOUPPER Y TOLOWER:\n");
            string GRU = villano.ToUpper();
            string esbirros2 = esbirros.ToLower();
            Console.WriteLine("{0} y {1}",villano, GRU);
            Console.WriteLine("{0} y {1}", esbirros,esbirros2);
            Console.ReadLine();

            //Podar cadenas
            Console.Write("TRIMSTART, TRIMEND, TRIM:\n");
            Console.Write("Eliminar espacios del principio, del final y de ambos lados");
            string espaciosDelanteros = "  palabra";
            string espaciosTraseros = "palabras   ";
            string espacios = "   palabras   ";
            Console.WriteLine("\n{0}.\n{1}.",espaciosDelanteros,espaciosDelanteros.TrimStart());
            Console.WriteLine("\n{0}.\n{1}.",espaciosTraseros,espaciosTraseros.TrimEnd());
            Console.WriteLine("\n{0}.\n{1}.",espacios,espacios.Trim());
            Console.ReadLine();

            //Determinar la longitud de una cadena
            Console.Write("LENGTH:\n");
            Console.Write("La longitud de la frase:\"{0}\" es {1}", frase, frase.Length);
            Console.ReadLine();

            //Determinar qué cadena está antes alfabéticamente
            Console.Write("\nCOMPARETO:");
            string ciudad1 = "ALICANTE";
            string ciudad2 = "Alicante";

            if (ciudad1.CompareTo(ciudad2) == -1)
                Console.Write("\n{0} está antes que {1}",ciudad1,ciudad2);
            else if (ciudad1.CompareTo(ciudad2)==1)
                Console.Write("\n{0} está antes que {1}", ciudad2, ciudad1);
            else
                Console.Write("\n{0} es la misma cadena que {1}", ciudad1, ciudad2);
            Console.ReadLine();

        }
    }
}
