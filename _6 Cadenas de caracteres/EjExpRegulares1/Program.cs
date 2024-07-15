using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //para el uso de expresiones regulares

namespace EjExpRegulares1
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIOS EJEMPLOS DE EXPRESIONES REGULARES

            //1) La calificación de un estudiante debe consistir en:
            //A, B o C por su logro, seguida de 1, 2 ó 3 por su esfuerzo. 
            string[] calificaciones = { " a4", "A2", "a3", "c6", "D 9" };
            foreach (var elemento in calificaciones)
            {
                if (Regex.IsMatch(elemento, "^[ABC][123]$"))
                    Console.Write(String.Format($"La calificación \"{elemento}\" es correcta").PadRight(40));
                else
                    Console.Write(String.Format($"La calificación \"{elemento}\" NO es correcta").PadRight(40));
            }

            Console.Write("\n\n");

            //2) El código de un producto debe consistir en una letra mayúscula seguida de un dígito
            string[] codProductos = { " a4", "A4", "a4", "c6", "D 9" };
            foreach (var elemento in codProductos)
            {
                if (Regex.IsMatch(elemento, "^[A-Z][0123456789]$"))
                    Console.Write(String.Format($"El código \"{elemento}\" es correcto").PadRight(40));
                else
                    Console.Write(String.Format($"El código \"{elemento}\" NO es correcto").PadRight(40));
            }

            Console.Write("\n\n");

            //3) Un número de teléfono de Córdoba capital debe tener 9 dígitos y empezar por 957
            //Consideramos que puede haber un espacio entre el prefijo y los 6 dígitos restantes
            string[] telfs = { "957404040", "957 123434", "956777777", "9571234" };
            foreach (var elemento in telfs)
            {
                if (Regex.IsMatch(elemento, "^957[0123456789]{6}$") || Regex.IsMatch(elemento, "^957 [0123456789]{6}$"))
                    Console.Write(String.Format($"El teléfono \"{elemento}\" es correcto").PadRight(40));
                else
                    Console.Write(String.Format($"El teléfono \"{elemento}\" NO es correcto").PadRight(40));
            }
            Console.ReadLine();
        }
    }
}
