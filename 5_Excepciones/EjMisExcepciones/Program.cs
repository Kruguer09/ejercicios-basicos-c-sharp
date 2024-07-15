using System;

namespace EjMisExcepciones
{
    //Me creo mi propia excepción
    public class MyException : ApplicationException
    {
        public MyException(): base("Esta es mi CustomException")
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Llamo a un método que devuelve un 1 si todo OK
                //si no, el método lanza una excepción del tipo
                //MyException
                int variable = Ejemplo();
            }
            catch (MyException ex)
            {
                //capturamos la exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //siempre se ejecuta
                Console.WriteLine("Hasta luego");
            }
        }

        public static int Ejemplo()
        {
            try
            {
                //bloque de código
                object obj = "aa";
                int variable = (int)obj;
            }
            catch (Exception ex)
            {
                //Lanzo mi propia excepción
                //y finaliza el método
                throw new MyException();
            }

            //Si no se ha producido ninguna excepción
            //devuelvo un 1
            return 1;

        }
    }
}
