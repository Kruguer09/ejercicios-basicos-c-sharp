using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjElementosFormato
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] values = { 1603, 1794.68235, 2.45555 };
            string result;
            foreach (var value in values)
            {
                result = String.Format("{0,12:C2}   {0,12:E3}   {0,12:F4}   {0,12:N3}  {1,12:P2}\n", Convert.ToDouble(value), Convert.ToDouble(value) / 10000);
                Console.WriteLine(result);
                Console.ReadKey();

                // El ejemplo muestra una salida como ésta:
                //       $1,603.00     1,603E+003      1603,0000      1,603.000       16.03 %
                //    
                //       $1,794.68     1,795E+003      1794,6824      1,794.682       17,95 %
                //    
                //           $2,46     2,456E+000         2,4556          2,456        0,02 %
                //          moneda    exponencial     punto fijo   nº decimales    porcentaje
            }
        }
    }
}
