using System.Diagnostics;

namespace _2FraseDe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sCadena;
            int iLongCadena;
            int iNumeroPalabras;
            do
            {
                Console.WriteLine(" Introduce una frase de al menos 4 palabras y 20 caracteres");
                sCadena = Console.ReadLine();
                iLongCadena = sCadena.Length;
                iNumeroPalabras = cuenta(sCadena);

            } while (iLongCadena < 19 || iNumeroPalabras < 4);
            Console.WriteLine("La longitud de la cadena es: " + iLongCadena);
            string sCadenaDos = sCadena.Replace("A", "X");
            string sCadenaTres = sCadenaDos.Replace("a", "x");
            Console.WriteLine("La cadena resultante (A=>X, a=>x): " + sCadenaTres);
            Console.WriteLine("La cadena enb mayúsculas: " + sCadena.ToUpper());
            Console.WriteLine("La cadena enb minúsculas: " + sCadena.ToLower());
            Console.WriteLine("La cadena resultante de borrar las 3 primeras letras: " + sCadena.Remove(0, 3));
            Console.WriteLine("La subcadena extraída entre las posiciones 5 y 10: " + sCadena.Substring(5, 5));
            Console.WriteLine("La cadena invertida es: "+invertir(sCadena));
            Console.WriteLine("El número de palabras que tiene la cadena es: " + iNumeroPalabras);
            Console.WriteLine("La tercera palabra de la cadena es: " + terceraPalabra(sCadena));

        }

        private static string terceraPalabra(string sCadena)
        {
            string sTerceraPalabra = "";
            var palabras = sCadena.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                if (i == 2) sTerceraPalabra = palabras[i];
            }
            return sTerceraPalabra;
        }

        private static int cuenta(string sCadena)
        {
            int iTotalpalabras = 0;
            var palabras = sCadena.Split(' ');
            foreach (var palabra in palabras)
            {
                iTotalpalabras++;
            }
            return iTotalpalabras;
        }
        static string invertir(string sPalabra)
        {
            char[] aPalabra = sPalabra.ToCharArray();
            Array.Reverse(aPalabra);
            return new string(aPalabra);
        }
    }
}