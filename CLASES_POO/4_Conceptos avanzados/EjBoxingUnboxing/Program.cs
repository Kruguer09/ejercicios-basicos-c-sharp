namespace EjBoxingUnboxing
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int i = 123;

            //BOXING: se copia el valor de i en el objeto o
            object o = i;

            o = 456;
            i = (int)o;  //UNBOXING


            int i2 = 123;
            object o2 = i2;  //BOXING implícito

            try
            {
                int j = (short)o2;  // intento de unbox
                                    //int j = (int)o2;

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Unboxing incorrecto.", e.Message);
            }
        }
    }
}
