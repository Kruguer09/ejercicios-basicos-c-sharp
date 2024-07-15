namespace _4AbcInvertido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cLetra = 'Z';
            //Console.WriteLine(cLetra);
            //cLetra--;
            //Console.ReadLine();
            //Console.WriteLine(cLetra);
            //cLetra = 'a';
            //Console.WriteLine(cLetra);
            //cLetra++;
            //Console.ReadLine();
            //Console.WriteLine(cLetra);
            while (cLetra >= 'A')
            {
                Console.Write(cLetra + " ");
                cLetra--;
            }

            Console.ReadLine();
        }
    }
}