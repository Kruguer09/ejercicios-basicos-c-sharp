using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjVirtualesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Nieta na = new Nieta();
            //Se implementa en HijaAbstracta
            Console.WriteLine($"Suma: {na.MetodoAbstractoSumar(1, 2)}"); 
            //Se llama al método implementado en Nieta, porque en HijaAbstracta se define como abstracto
            Console.WriteLine($"Resta: {na.MetodoVirtualRestar(4, 2)}");
            //Se llama al método implementado en ClaseAbstracta
            Console.WriteLine($"Producto: {na.MetodoVirtualMultiplicar(4, 2)}");

            Console.ReadKey();

            //NO se pueden crear INSTANCIAS de una CLASE ABSTRACTA
            //ClaseAbstracta ca = new ClaseAbstracta();
            //HijaAbstracta ha = new HijaAbstracta();
            

        }
    }
}
