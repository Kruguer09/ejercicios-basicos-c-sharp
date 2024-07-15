using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCamposOPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.Campo = 12;
            clase.Apellidos = "Lopez Serrano";
            //ERROR: No puedo asignarle un valor Edad porque el set de esta propiedad es private
            //clase.Edad = 12;

            //Le asigno un valor que no es válido
            //para que en el get se le asigne
            //999999999
            clase.Telefono = 123;

            //Muestro el valor de la propiedad Edad (asignada en el constructor)
            //y del Telefono
            Console.WriteLine($"Edad: {clase.Edad} y Telefono : {clase.Telefono.ToString()}");
            Console.ReadLine();

            Clase clase2 = new Clase();
            //ERROR: No puedo asignarle un valor Edad porque el set de esta propiedad es private
            //clase2.Edad = 25;

            //A través de Metodo sí que puedo
            clase2.Metodo(25);
            clase2.Telefono = 957474747;
            Console.WriteLine($"Edad: {clase2.Edad} y Telefono : {clase2.Telefono.ToString()}");
            Console.ReadLine();

        }
    }
}
