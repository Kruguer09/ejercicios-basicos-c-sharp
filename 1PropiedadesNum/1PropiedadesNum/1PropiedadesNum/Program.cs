namespace _1PropiedadesNum;
public class Program
{
    static void Main(string[] args)
    {
        int numEntero;
        int opcion = 1; /*establezco una primera opción del switch con la intención de que entre una vez en el programa y 
                         * se vuelva a ejecutar hasta que no se pulse la opción de salir (opción 4)*/
        bool validarEntero = false;

        do
        {
            //Console.Clear(); //Si borro la terminal no se ven los resultados de las opciones elegidas
            Console.Write("\nInserte un número entero: ");
            do
            {
                validarEntero = Int32.TryParse(Console.ReadLine(), out numEntero);
                if (!validarEntero || numEntero < 1) Console.Write("¡Error! Inserte un número entero: ");
            } while (validarEntero == false || numEntero < 1);

            Console.WriteLine("\nEscoge entre las siguientes opciones\n\n\t1.Factorial\n\t2.Es Primo\n\t3.Divisores\n\t4.Salir\n");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.WriteLine("\nEl factorial de " + numEntero + " es: " + factorial(numEntero)); break;
                case 2: Console.WriteLine("\nEl número " + numEntero + (esPrimo(numEntero)? " es primo.":" no es primo")); break;
                case 3:
                    List<int> listaDivisores = divisores(numEntero);
                    Console.WriteLine($"\nLos divisores del número {numEntero} son los siguientes:");
                    foreach (int divisor in listaDivisores)
                    {
                        Console.Write(divisor + " ");
                    }
                    break;

                case 4: Console.WriteLine("\n---Fin del programa---"); break;
                default: Console.WriteLine("Error: Elige una opción correcta");break;
            }
        } while (opcion != 4);

    }

    public static bool esPrimo(int numero)
    {
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }

    public static List<int> divisores(int numero)
    {
        List<int> divisores = new List<int>();

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores.Add(i);
            }
        }

        return divisores;
    }

    public static int factorial(int numero) => numero == 0 || numero == 1 ? 1 : numero * factorial(numero - 1);
}