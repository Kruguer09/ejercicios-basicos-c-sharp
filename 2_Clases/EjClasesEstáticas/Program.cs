using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjClasesEstáticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona el = new Persona();
            el.Nombre = "Juan";
            el.FechaNacimiento = new DateTime(1982,6,25);
            el.Altura = 183;
            el.Peso = 97;

            //No podemos setear la Edad
            //persona.Edad = 50;
            
            WriteLine($"{el.Nombre} nació el {el.FechaNacimiento.ToLongDateString()} y tiene {el.Edad} años.");
            WriteLine($"Su IMC es de {Persona.CalcularIMC(el.Altura, el.Peso):N2}");
            ReadKey();
        }
    }

    //Clase Estática
    public static class UtilidadesDeFechas
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year,
                       fechaNacimiento.Month, fechaNacimiento.Day);

            if (temp > DateTime.Today)
                edad--;
           
            return edad;
        }
    }
    //Esto no podría hacerlo porque nunca se puede heredar
    //de una clase estática
    //public class Persona:UtilidadesDeFechas
    public class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }

        //Declaramos la Edad como una propiedad que no se puede setear
        public int Edad
        {
            get
            {
                return UtilidadesDeFechas.CalcularEdad(FechaNacimiento);
            }
        }

        //Método estático
        public static double CalcularIMC(int altura, int peso)
        {
            return peso / Math.Pow((double) altura/100, 2);
        }
       
    }
}
