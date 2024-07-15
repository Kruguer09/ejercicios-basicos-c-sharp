using System; //1er USO
using static System.Math; //2º USO
using static System.Console; //2º USO
using MiAlias = OtroNamespace.Ejemplo.ClaseEjemplo.Clase1EnEjemplo; //3er USO
namespace EjUsing
{
    internal class Program
    {

        static void Main(string[] args)
        {
            WriteLine($"La raíz cuadrada es {Sqrt(3 * 3 + 4 * 4)}");

            MiAlias instancia = new MiAlias();
            Console.WriteLine(instancia.ToString());
        }

    }
}