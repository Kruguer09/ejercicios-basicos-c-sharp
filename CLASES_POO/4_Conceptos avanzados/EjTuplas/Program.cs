namespace EjTuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Me creo una tupla llamada t
            (int, string, string) t = (1, "Rodrigo", "Sainz Rey");

            //Muestro el valor de cada elemento de la tupla
            Console.WriteLine($"La persona {t.Item1} es {t.Item2} {t.Item3}");

            Console.WriteLine("\nIntroduce una frase:");
            string cadena = Console.ReadLine();

            //Recojo los valores devueltos por el Metodo
            (int numPalabras, string ultPalabra) = SeparadorDeFrases(cadena);
            //Muestro cada uno de esos valores
            Console.WriteLine($"\nLa cadena \"{cadena}\":\n" +
                $"tiene {numPalabras} palabras y la útltima es {ultPalabra}");

            //Llamo al método que hace lo mismo pero pasándole la tupla
            PrintMsje(cadena, (numPalabras, ultPalabra));

            //Llamo al método que hace lo mismo pero pasándole la tupla
            PrintMsje2(cadena, (numPalabras, ultPalabra));

            Console.WriteLine("\nIntroduce otra frase:");
            string cadena2 = Console.ReadLine();

            //Muestro cada valor devuelto por el método
            Console.WriteLine($"La cadena \"{cadena2}\":\n" +
                $"tiene {SeparadorDeFrases(cadena2).Item1} palabras y la útltima" +
                $" es {SeparadorDeFrases(cadena2).Item2}");

            //Llamo a un método que recibe un único parámetro
            //de tipo Object y le paso una tupla
            MetodoConUnParametroObject(t);
        }


        //Recibe una cadena como parámetro, la separa en palabras y devuelve 
        //El nº de palabras de la cadena y la última palabra
        public static (int, string) SeparadorDeFrases(string cadena)
        {
            string[] palabras = cadena.Split();

            return (palabras.Length, palabras[palabras.Length - 1]);
        }

        //Implemento 2 métodos que van a recibir una cadena y una tupla llamada texto 
        //las muestro por consola

        //Forma 1, accedo a cada elemento de la tupla por su nombre
        public static void PrintMsje(string cad, (int num, string ultima) tex)
        {
            Console.WriteLine($"\n---MÉTODO PrintMsje\nLa cadena \"{cad}\":\n" +
                  $"tiene {tex.num} palabras y la útltima es {tex.ultima}");
        }

        //Forma 2, accedo a cada elemento de la tupla por Item1, Item2...
        public static void PrintMsje2(string cad, (int, string) tex)
        {
            Console.WriteLine($"\n---MÉTODO PrintMsje2\nLa cadena \"{cad}\":\n" +
                  $"tiene {tex.Item1} palabras y la útltima es {tex.Item2}");
        }

        //Método que recibe un parámetro de tipo object
        public static void MetodoConUnParametroObject(object parametro)
        {
            Console.WriteLine(parametro.ToString());
        }
    }
}