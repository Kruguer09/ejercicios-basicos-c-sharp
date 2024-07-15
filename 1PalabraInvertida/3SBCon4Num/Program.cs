using System.Text;

namespace _3SBCon4Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bValidaNumero = false;
            int iNumeroTemporal;
            StringBuilder sbCadenaNumeros = new StringBuilder();
            string[] sNumeros = new string[4];
            Console.WriteLine("Vamos a insertar un total de 4 números enteros y positivos!");
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    Console.WriteLine("Inserta el número " + (i + 1) + " :");

                } while (!Int32.TryParse(Console.ReadLine(), out iNumeroTemporal) || iNumeroTemporal < 0);
                sNumeros[i] = iNumeroTemporal.ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    sbCadenaNumeros.Append("El primer número introducido es el número " + sNumeros[i]);
                }
                else if (i == 1)
                {
                    sbCadenaNumeros.Append(" después se ha introducido el " + sNumeros[i]);
                }
                else if (i == 2)
                {
                    sbCadenaNumeros.Append(" y " + sNumeros[i]);
                }
                else
                {
                    sbCadenaNumeros.Append(" y finalmente el " + sNumeros[i]);
                }
            }
            Console.WriteLine(sbCadenaNumeros);
        }

    }
}