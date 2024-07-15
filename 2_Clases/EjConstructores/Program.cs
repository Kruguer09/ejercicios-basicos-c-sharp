using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamo al constructor por defecto
            Punto punto = new Punto();
            Console.WriteLine($"X = {punto.X} Y = {punto.Y}");

            punto.X = 5;
            Console.WriteLine($"X = {punto.X} Y = {punto.Y}");

            //Al ser value=0, el descriptor set de X le va a asignar x=100
            punto.X = 0;
            Console.WriteLine($"X = {punto.X} Y = {punto.Y}");

            //Llamo al constructor que asigna valores a X e Y
            Punto punto2 = new Punto(10, 20);
            Console.WriteLine($"X = {punto2.X} Y = {punto2.Y}");

            //LLamo al constructor que asigna un valor a X y a Y=0
            Punto punto3 = new Punto(10);
            Console.WriteLine($"X = {punto3.X} Y = {punto3.Y}");
            
            Console.ReadKey();

        }
    }

    public class Punto
    {
        //Propiedad y descriptores de acceso
        private int x;
        //Bodied member
        public int X {
            //Si value!=0=> x=value, si no x=100 
            set => x = value != 0 ? value : 100;
            get => x; 
        }

        //-----------------------------------------
        //FORMA 1
        //public int Y { get; set; }

        //FORMA 2
        //Propiedad y descriptores de acceso
        private int y;
        public int Y
        {
            get => y;
            set => y = value;
        }
        //-----------------------------------------

        //Constructor por defecto
        public Punto()
        {
            X = 0; //Al ser value=0, el descriptor set de X le va a asignar x=100
            Y = 0;
        }

        //-----------------------------------------
        //Constructor con 2 parámetros
        //public Punto(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //}

        //Constructor con 2 parámetros 
        //como método de expresión corporal o bodied member
        public Punto(int x, int y) => (X, Y) = (x, y);
        //-----------------------------------------

        //Constructor con 1 parámetro
        //public Punto(int x)
        //{
        //    X = x;
        //    Y = 0;
        //}

        //Constructor con 1 parámetro 
        //como método de expresión corporal o bodied member
        public Punto(int x) => (X, Y) = (x, 0);
    }
}
