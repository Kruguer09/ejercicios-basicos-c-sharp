using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjNivelesAccesibilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            //No puedo acceder a Edad ni a Apellidos
            //Edad es private en ClaseBase
            //Apellidos es protected en ClaseBase
            //Direccion es private protected en ClaseBase

            ClaseDerivada clasedev = new ClaseDerivada();
            clasedev.Nacionalidad = "Española"; //protected internal
            clasedev.Nombre = "Alejandro"; //internal
            clasedev.Telefono = "1122233"; //public
            
            Console.WriteLine("La suma es: {0}",clasedev.Sumar(6, 7)); //public
            Console.ReadKey();
        }
    }
}
