using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjDateTimeToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //FORMAS de inicializar un objeto de la estructura DateTime
            DateTime fecha = new DateTime();
            fecha = DateTime.Now;

            DateTime fecha2 = new DateTime(2021, 10, 2, 20, 36, 46);

            string strFecha3 = "6/1/2016 6:34:53";
            DateTime fecha3 = DateTime.Parse(strFecha3);

            //02/10/2021 20:36:46
            Console.WriteLine("ToLocalTime: " + fecha.ToLocalTime());

            //sábado, 02 de octubre de 2021
            Console.WriteLine("ToLongDateString: " + fecha.ToLongDateString());

            //20:36:46
            Console.WriteLine("ToLongTimeString: " + fecha.ToLongTimeString());

            //02/10/2021
            Console.WriteLine("ToShortDateString: " + fecha.ToShortDateString());

            //20:36
            Console.WriteLine("ToShortTimeString: " + fecha.ToShortTimeString());

            //02/10/2021 20:36:46
            Console.WriteLine("ToString: " + fecha.ToString());

            //02/10/2021 18:36:46
            Console.WriteLine("ToUniversalTime: " + fecha.ToUniversalTime());
            Console.ReadLine();

            //02/10/2021 08:36:46
            string fechaString = String.Format("La fecha de hoy es: {0:dd/MM/yyyy hh:mm:ss}", DateTime.Now);
            Console.WriteLine(fechaString);

            //sábado, 2 de octubre de 2021 20:36
            fechaString = String.Format("La fecha de hoy es: {0:dddd, d\" de \"MMMM\" de \"yyyy HH:mm}", DateTime.Now);
            Console.WriteLine(fechaString);
            Console.ReadLine();
        }
    }
}
