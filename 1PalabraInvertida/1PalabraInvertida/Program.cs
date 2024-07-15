namespace _1PalabraInvertida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sPalabra;
            Console.Write("Escriba un apalabra: ");
            sPalabra=Console.ReadLine();
            string sPalabraInvertida=invertir(sPalabra).ToLower();
            Console.WriteLine(sPalabraInvertida);
        }

        static string invertir(string sPalabra)
        {
            char[] aPalabra = sPalabra.ToCharArray();
            Array.Reverse(aPalabra);
            return new string(aPalabra);
        }
    }
}