using System;

namespace EjExcepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código

                object obj = "aa";
                int variable = (int)obj;

                int valor = 0;
                int division = 6 / valor;

                int[] matriz = { 0, 1 };
                matriz[2] = 5;

                Console.Write("TEXTO: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (IndexOutOfRangeException ex)
            {
                //capturamos la exception
                Console.WriteLine($"catch1 : {ex.GetType()}");
            }
            catch (DivideByZeroException ex)
            {
                //capturamos la exception
                Console.WriteLine($"catch2 : {ex.GetType()}");
            }
            catch (InvalidCastException ex)
            {
                //capturamos la exception
                Console.WriteLine($"catch3 : {ex.GetType()}");
            }
            catch (Exception ex)
            {
                //capturamos la exception
                Console.WriteLine($"catch4 : {ex.GetType()}");
            }
            finally
            {
                //siempre se ejecuta
                Console.WriteLine("Fin del programa");
            }
        }
    }
}
