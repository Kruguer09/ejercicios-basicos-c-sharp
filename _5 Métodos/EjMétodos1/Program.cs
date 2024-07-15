using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMétodos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cómo te llamas?: ");
            string miNombre = Console.ReadLine();
            Console.Write("¿Qué edad tienes?: ");
            int miEdad = int.Parse(Console.ReadLine());

            //Llamada a los procedimientos
            Imprimir(miNombre); 
            ImprimirSiMayoriaEdad(miEdad);

            Console.ReadKey();
        }
        //PROCEDIMIENTO = método que no devuelve nada
        //Recibe un parámetro de tipo string por valor
        public static void Imprimir(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        //PROCEDIMIENTO = método que no devuelve nada.
        //Recibe un parámetro de tipo int por valor
        public static void ImprimirSiMayoriaEdad(int edad)
        {
            string cadena = "eres mayor de edad";
            string cadAuxiliar;

            //Llamamos a la función VerificarEdad
            if (VerificarEdad(edad))
                cadAuxiliar = "Sí ";
            else
                cadAuxiliar = "No ";

            Console.WriteLine(cadAuxiliar + cadena);
        }

        //FUNCIÓN = método que devuelve uno o más valores
        //Recibe un parámetro de tipo int por valor
        public static bool VerificarEdad(int edad)
        {
            if (edad >= 18)
                return true;
            else
                return false;
        }
      
    }
}
