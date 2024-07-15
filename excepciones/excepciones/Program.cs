namespace excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bloque de código
                object obj = "aa";
                int variable = (int)obj;
            }
            catch (Exception ex)
            {
                //capturamos la exception
                //Mostramos el tipo de excepción
                Console.WriteLine(ex.GetType());
                //Motramos el error que se ha producido
                Console.WriteLine(ex.Message);
            }
        }
    }
}